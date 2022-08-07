using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoldSrcGameInfoGenerator.Utils
{
    class BoolConverter
    {
        public static string ConvertBool(bool obj)
        {
            if(obj == true)
            {
                return "1";
            }
            else
            {
                return "0";
            }
        }
    }
}
