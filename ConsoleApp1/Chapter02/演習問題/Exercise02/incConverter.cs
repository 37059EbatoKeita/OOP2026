using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise02 {
    internal class incConverter {
        private static readonly double ratio = 0.0254;

        public static double Frominch(double inch) {
            return inch / ratio;
        }
    }
}
