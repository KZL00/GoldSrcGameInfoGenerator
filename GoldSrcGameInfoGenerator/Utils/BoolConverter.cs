using System;
using System.Collections.Generic;

namespace GoldSrcGameInfoGenerator.Utils
{
    class BoolConverter
    {
        public static string ConvertBool(bool _bool)
        {
            switch(_bool) 
            {
                case true: return "1";
                case false: return "0";
            }
        }
    }
}