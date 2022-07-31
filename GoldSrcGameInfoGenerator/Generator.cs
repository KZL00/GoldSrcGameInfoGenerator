using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GoldSrcGameInfoGenerator.Utils;
using System.IO;
using System.Windows.Forms;

namespace GoldSrcGameInfoGenerator
{
    class Generator
    {
        public void Generate(string MOD_NAME, string MOD_TYPE, string MOD_ICON, string GAME_DLL, string GAME_DLL_LINUX, string GAME_DLL_OSX, string DEVELOPER_NAME, string DEVELOPER_WEBPAGE, string STARTING_MAP, string TRAINING_MAP, string SECURE, string NO_HI_MODELS, string OUTPUT_DIRECTORY)
        {
            using (FileStream fs = File.Create(OUTPUT_DIRECTORY))
            {
                // "Watermark"
                ByteWriter.AddText(fs, "// Made with GoldSrc Game Info Generator (by KZL)." + Environment.NewLine);
                ByteWriter.AddText(fs, "// Source code: https://github.com/KZL00/GoldSrcGameInfoGenerator" + Environment.NewLine);
                ByteWriter.AddText(fs, "// Download: https://kzl00.github.io/goldsrc-gameinfo/" + Environment.NewLine + Environment.NewLine);

                // Project
                ByteWriter.AddText(fs, $"game \"{MOD_NAME}\"" + Environment.NewLine);
                ByteWriter.AddText(fs, $"type \"{MOD_TYPE}\"" + Environment.NewLine);
                ByteWriter.AddText(fs, $"icon \"{MOD_ICON}\"" + Environment.NewLine);

                // DLLs
                ByteWriter.AddText(fs, $"gamedll \"{GAME_DLL}\"" + Environment.NewLine);
                ByteWriter.AddText(fs, $"gamedll_linux \"{GAME_DLL_LINUX}\"" + Environment.NewLine);
                ByteWriter.AddText(fs, $"gamedll_osx \"{GAME_DLL_OSX}\"" + Environment.NewLine);

                // Developer
                ByteWriter.AddText(fs, $"developer \"{DEVELOPER_NAME}\"" + Environment.NewLine);
                ByteWriter.AddText(fs, $"developer_url \"{DEVELOPER_WEBPAGE}\"" + Environment.NewLine);

                // Maps
                ByteWriter.AddText(fs, $"startmap \"{STARTING_MAP}\"" + Environment.NewLine);
                ByteWriter.AddText(fs, $"trainmap \"{TRAINING_MAP}\"" + Environment.NewLine);

                // Advanced
                ByteWriter.AddText(fs, $"secure \"{SECURE}\"" + Environment.NewLine);
                ByteWriter.AddText(fs, $"nohimodels \"{NO_HI_MODELS}\"" + Environment.NewLine);
            }

            MessageBox.Show("The file has been successfully generated.", "GoldSrc Game Info Generator", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
