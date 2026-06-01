using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise01 {
    //5.1.1
    public class YearMonth {
        public string Year { get; private set; }
        public string Month { get; private set; }

        public YearMonth(string Year, string Month) {
            Year = Year;
            Month = Month;
        }
   
        }
    }

