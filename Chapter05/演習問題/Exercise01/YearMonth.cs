using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise01 {
    //5.1.1
    public class YearMonth {
        public string Year { get; init; }
        public string Month { get; init; }

        public YearMonth(string Year, string Month) {
            Year = Year;
            Month = Month;
        }
        //5.1.2
        public bool Is21Century => YearMonth + Is21Century;
        }
    }

