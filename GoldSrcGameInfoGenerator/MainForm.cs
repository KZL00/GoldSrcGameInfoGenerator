﻿using System;
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

        }

        private void generateButton_Click(object sender, EventArgs e)
        {

        }
    }
}
