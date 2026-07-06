namespace Test01_01 {
    public class ScoreCounter {
        private IEnumerable<Student> _score;

        // コンストラクタ
        public ScoreCounter(string filePath) {
            _score = ReadScore(filePath);
        }
        //メソッドの概要：
        private static IEnumerable<Student> ReadScore(string filePath) {
            var score = new List<Student>();
            var lines = File.ReadAllLines(filePath);
            foreach (var line in lines) {
                var scores = line.Split(',');
                var student = new Student {
                    Name = scores[0],
                    Subject = scores[1],
                    Score = int.Parse(scores[2]),
                };
                score.Add(student);
            }
            return score;
        }

        //メソッドの概要：
        public IDictionary<string, int> GetPerStudentScore() {
            var dict = new Dictionary<string, int>();
            
            foreach (var student in _score){
                if (dict.ContainsKey(student.Subject))
                    dict[student.Subject] += student.Score;
                else
                    dict[student.Subject] = student.Score;
            }
            return dict;
        }
    }
}
