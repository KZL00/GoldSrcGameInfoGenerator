using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoldSrcGameInfoGenerator.Utils
{
    static class LinkOpener
    {
        public static void OpenLink(string url)
        {
            System.Diagnostics.Process.Start(url);
        }
    }
}
