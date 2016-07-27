using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cursOOP {
    public static class StringExtension {
        public static String RemoveVoyels(this String str) {
            return str.Replace("a", "");
        }
    }
}
