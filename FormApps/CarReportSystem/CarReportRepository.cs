using CarReportSystem;
using Microsoft.Data.Sqlite;
using System.Diagnostics;
using System.Globalization;
using System.Xml.Linq;

namespace SQLiteProductSample;

//Productsテーブルに対するDB操作をまとめたクラス
//CRUD (Create / Read / Update / Delete)を担当する
public class CarReportRepository
{
    
    public List<CarReport> GetAll() {
        var reports = new List<CarReport>();

        using var connection = Database.GetConnection();
        connection.Open();

        //SQLを実行するためのコマンドオブジェクトを作る
        using var command = connection.CreateCommand();

        //Productsテーブルを作るSQL
        command.CommandText =
            """
            SELECT Id, Data, Author, Maker, CarName, Report, Picture
            FROM CarReports
            ORDER BY Id;
            """;

        //SELECTを実行し、複数行の検索結果を読み取る
        using var reader =  command.ExecuteReader();

        while (reader.Read()) {
            reports.Add(new CarReport {
                Id = reader.GetInt32(0),
                Date = DateTime.ParseExact(
                    reader.GetString(1),
                    "yyyy-MM-dd",
                    CultureInfo.InvariantCulture),

                Author = reader.GetString(2),
                Maker = (CarReport.MakerGroup)reader.GetInt32(3),
                CarName = reader.GetString(4),
                Report = reader.GetString(5),
                //Picture = 
            });
        }
        return reports;
    }

    //商品を1件追加する。Create（INSERT)に相当する
    //戻り値として自動採番されたIdを返す
    public int Add(string name , int price) {
        //接続オブジェクトを生成する。
        using var connection = Database.GetConnection();

        //DBを開く
        connection.Open();

        //SQLを実行するためのコマンドオブジェクトを作る
        using var command = connection.CreateCommand();

        //Productsテーブルを作るSQL
        //IF NOT EXISTSにより、既にテーブルがあってもエラーにならない
        command.CommandText =
            """
            INSERT INTO CarReports 
            (Data, Author, Maker, CarName, Report, Picture)
            VALUES 
            ($data, $author, $carname, $report, $picture);

            SELECT last_insert_rowid();
            """;

        command.Parameters.AddWithValue("$name", name);
        command.Parameters.AddWithValue("$price", price);

        //一つの値を返すSQLを実行する
        var result = command.ExecuteScalar();

        if (result is null)
            throw new InvalidOperationException("登場した商品のIDを取得できませんでした。");

        //SQLiteのINTEGERはlongとして返るため、intへ変換する
        return Convert.ToInt32((long)result);

    }

    public void Update(CarReport product) {
        //接続オブジェクトを生成する。
        using var connection = Database.GetConnection();        
        connection.Open();
        using var command = connection.CreateCommand();

        command.CommandText =
            """
            UPDATE CarReports
            SET Data = $data, Author = $author, Maker = $maker,
                CarName = $carName, Report = $report, Picture = $picture
            WHERE Id = $id;            
            """;

      
        command.Parameters.AddWithValue("$id", product.Id);

        //更新件数が0なら対象が存在しない
        if (command.ExecuteNonQuery() == 0)
            throw new InvalidOperationException("修正対象の商品が見つかりませんでした。");
    }
    public void Delete(int id) {
        using var connection = Database.GetConnection();
        connection.Open();

        using var command = connection.CreateCommand();
        command.CommandText =
            """
            DELETE FROM CarReports
            WHERE Id = $id;
            """;

        command.Parameters.AddWithValue("$id", id);
        command.ExecuteNonQuery();
    }
}
