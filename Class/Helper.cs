using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnalisadorLexico.Class
{
    static class Helper
    {
        public static string ReturnSpace(int spaceAdditional, int lengthText = 0, int maxLength = 0)
        {
            int calc = maxLength - lengthText;
            string space = string.Empty;

            for (int i = 0; i < (calc + spaceAdditional); i++)
                space += " ";

            return space;
        }

        public static string ReturnTrace(int amount)
        {
            string trace = string.Empty;
            for (int i = 0; i < amount; i++)
                trace += "-";
            
            return trace;
        }
    }
}
