using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoldSrcGameInfoGenerator
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Console.WriteLine("GoldSrcGameInfoGenerator UI ready.");
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void aboutButton_Click(object sender, EventArgs e)
        {
            AboutForm about = new AboutForm();
            about.Show();
        }

        private void generateButton_Click(object sender, EventArgs e)
        {
            // Project
            string MOD_NAME = modNameTextBox.Text;
            string MOD_TYPE = modTypeComboBox.Text;
            string MOD_ICON = modIconTextBox.Text;

            // DLLs
            string GAME_DLL = winGameLibraryTextBox.Text;
            string GAME_DLL_LINUX = linuxGameLibraryTextBox.Text;
            string GAME_DLL_OSX = osxGameLibraryTextBox.Text;

            // Developer
            string DEVELOPER_NAME = developerNameTextBox.Text;
            string DEVELOPER_WEBPAGE = developerWebpageTextBox.Text;

            // Maps
            string STARTING_MAP = startingMapTextBox.Text;
            string TRAINING_MAP = trainingMapTextBox.Text;

            // Advanced
            //TODO: Frontend
            string SECURE = "1";
            string NO_HI_MODELS = "1";

            // Output Location
            string OUTPUT_DIRECTORY;
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "GAM File|*.gam";
            saveFileDialog.Title = "Save an liblist.gam file";
            saveFileDialog.ShowDialog();

            if (saveFileDialog.FileName != "")
            {
                OUTPUT_DIRECTORY = saveFileDialog.FileName;

                if (MOD_TYPE == "singleplayer_only" || MOD_TYPE == "multiplayer_only")
                {
                    Generator gen = new Generator();
                    gen.Generate(MOD_NAME, MOD_TYPE, MOD_ICON, GAME_DLL, GAME_DLL_LINUX, GAME_DLL_OSX, DEVELOPER_NAME, DEVELOPER_WEBPAGE, STARTING_MAP, TRAINING_MAP, SECURE, NO_HI_MODELS, OUTPUT_DIRECTORY); 
                }
                else
                {
                    MessageBox.Show("Wrong type. Use 'singleplayer_only' or 'multiplayer_only' to continue.", "GoldSrc Game Info Generator", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
