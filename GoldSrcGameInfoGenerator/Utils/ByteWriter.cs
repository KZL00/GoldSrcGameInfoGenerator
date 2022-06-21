using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoldSrcGameInfoGenerator.Utils
{
    class ByteWriter
    {
        public void AddText(FileStream fs, string value)
        {
            byte[] data = new UTF8Encoding(true).GetBytes(value);
            fs.Write(data, 0, data.Length);
        }
    }
}
