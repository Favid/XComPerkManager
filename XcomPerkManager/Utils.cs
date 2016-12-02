using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XcomPerkManager
{
    public static class Utils
    {
        public static int parseStringToInt(string str)
        {
            int result = 0;
            if (!int.TryParse(str, out result))
            {
                //error
            }

            return result;
        }

        public static string encaseStringInQuotes(string str)
        {
            return "\"" + str + "\"";
        }
    }
}
