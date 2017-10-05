using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsTest1
{
    public static class ExtClass
    {
        public static string ExtendedString(this string s) {
            return "{{ " + s + " }}";
        }

        public static int Per2(this int i) {
            return i * 2;
        }
    }
}
