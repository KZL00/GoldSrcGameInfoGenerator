
namespace GoldSrcGameInfoGenerator
{
    partial class MainForm
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.bgPanel = new System.Windows.Forms.Panel();
            this.subtitleLabel = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.modGroupBox = new System.Windows.Forms.GroupBox();
            this.modIconTextBox = new System.Windows.Forms.TextBox();
            this.modIconLabel = new System.Windows.Forms.Label();
            this.modTypeComboBox = new System.Windows.Forms.ComboBox();
            this.modTypeLabel = new System.Windows.Forms.Label();
            this.modNameTextBox = new System.Windows.Forms.TextBox();
            this.modNameLabel = new System.Windows.Forms.Label();
            this.dllGroupBox = new System.Windows.Forms.GroupBox();
            this.linuxGameLibraryTextBox = new System.Windows.Forms.TextBox();
            this.osxGameLibraryTextBox = new System.Windows.Forms.TextBox();
            this.osxGameLibraryLabel = new System.Windows.Forms.Label();
            this.linuxGameLibraryLabel = new System.Windows.Forms.Label();
            this.winGameLibraryTextBox = new System.Windows.Forms.TextBox();
            this.winGameLibraryLabel = new System.Windows.Forms.Label();
            this.developerGroupBox = new System.Windows.Forms.GroupBox();
            this.developerWebpageTextBox = new System.Windows.Forms.TextBox();
            this.developerWebpageLabel = new System.Windows.Forms.Label();
            this.developerNameTextBox = new System.Windows.Forms.TextBox();
            this.developerNameLabel = new System.Windows.Forms.Label();
            this.trainingMapTextBox = new System.Windows.Forms.TextBox();
            this.trainingMapLabel = new System.Windows.Forms.Label();
            this.startMapTextBox = new System.Windows.Forms.TextBox();
            this.startMapLabel = new System.Windows.Forms.Label();
            this.mapsGroupBox = new System.Windows.Forms.GroupBox();
            this.aboutButton = new System.Windows.Forms.Button();
            this.generateButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.bgPanel.SuspendLayout();
            this.modGroupBox.SuspendLayout();
            this.dllGroupBox.SuspendLayout();
            this.developerGroupBox.SuspendLayout();
            this.mapsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // bgPanel
            // 
            this.bgPanel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.bgPanel.Controls.Add(this.subtitleLabel);
            this.bgPanel.Controls.Add(this.titleLabel);
            this.bgPanel.Location = new System.Drawing.Point(-6, -13);
            this.bgPanel.Name = "bgPanel";
            this.bgPanel.Size = new System.Drawing.Size(818, 85);
            this.bgPanel.TabIndex = 0;
            // 
            // subtitleLabel
            // 
            this.subtitleLabel.AutoSize = true;
            this.subtitleLabel.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.subtitleLabel.Location = new System.Drawing.Point(529, 58);
            this.subtitleLabel.Name = "subtitleLabel";
            this.subtitleLabel.Size = new System.Drawing.Size(51, 16);
            this.subtitleLabel.TabIndex = 1;
            this.subtitleLabel.Text = "By KZL";
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Montserrat", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.titleLabel.Location = new System.Drawing.Point(19, 26);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(528, 48);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "GoldSrc GameInfo Generator";
            // 
            // modGroupBox
            // 
            this.modGroupBox.Controls.Add(this.modIconTextBox);
            this.modGroupBox.Controls.Add(this.modIconLabel);
            this.modGroupBox.Controls.Add(this.modTypeComboBox);
            this.modGroupBox.Controls.Add(this.modTypeLabel);
            this.modGroupBox.Controls.Add(this.modNameTextBox);
            this.modGroupBox.Controls.Add(this.modNameLabel);
            this.modGroupBox.Location = new System.Drawing.Point(13, 79);
            this.modGroupBox.Name = "modGroupBox";
            this.modGroupBox.Size = new System.Drawing.Size(385, 102);
            this.modGroupBox.TabIndex = 1;
            this.modGroupBox.TabStop = false;
            this.modGroupBox.Text = "Mod";
            // 
            // modIconTextBox
            // 
            this.modIconTextBox.Location = new System.Drawing.Point(123, 73);
            this.modIconTextBox.Name = "modIconTextBox";
            this.modIconTextBox.Size = new System.Drawing.Size(250, 20);
            this.modIconTextBox.TabIndex = 5;
            // 
            // modIconLabel
            // 
            this.modIconLabel.AutoSize = true;
            this.modIconLabel.Location = new System.Drawing.Point(8, 73);
            this.modIconLabel.Name = "modIconLabel";
            this.modIconLabel.Size = new System.Drawing.Size(51, 13);
            this.modIconLabel.TabIndex = 4;
            this.modIconLabel.Text = "Mod icon";
            // 
            // modTypeComboBox
            // 
            this.modTypeComboBox.FormattingEnabled = true;
            this.modTypeComboBox.Items.AddRange(new object[] {
            "singleplayer_only",
            "multiplayer_only"});
            this.modTypeComboBox.Location = new System.Drawing.Point(123, 46);
            this.modTypeComboBox.Name = "modTypeComboBox";
            this.modTypeComboBox.Size = new System.Drawing.Size(250, 21);
            this.modTypeComboBox.TabIndex = 3;
            // 
            // modTypeLabel
            // 
            this.modTypeLabel.AutoSize = true;
            this.modTypeLabel.Location = new System.Drawing.Point(8, 46);
            this.modTypeLabel.Name = "modTypeLabel";
            this.modTypeLabel.Size = new System.Drawing.Size(51, 13);
            this.modTypeLabel.TabIndex = 2;
            this.modTypeLabel.Text = "Mod type";
            // 
            // modNameTextBox
            // 
            this.modNameTextBox.Location = new System.Drawing.Point(123, 20);
            this.modNameTextBox.Name = "modNameTextBox";
            this.modNameTextBox.Size = new System.Drawing.Size(250, 20);
            this.modNameTextBox.TabIndex = 1;
            // 
            // modNameLabel
            // 
            this.modNameLabel.AutoSize = true;
            this.modNameLabel.Location = new System.Drawing.Point(8, 20);
            this.modNameLabel.Name = "modNameLabel";
            this.modNameLabel.Size = new System.Drawing.Size(57, 13);
            this.modNameLabel.TabIndex = 0;
            this.modNameLabel.Text = "Mod name";
            // 
            // dllGroupBox
            // 
            this.dllGroupBox.Controls.Add(this.linuxGameLibraryTextBox);
            this.dllGroupBox.Controls.Add(this.osxGameLibraryTextBox);
            this.dllGroupBox.Controls.Add(this.osxGameLibraryLabel);
            this.dllGroupBox.Controls.Add(this.linuxGameLibraryLabel);
            this.dllGroupBox.Controls.Add(this.winGameLibraryTextBox);
            this.dllGroupBox.Controls.Add(this.winGameLibraryLabel);
            this.dllGroupBox.Location = new System.Drawing.Point(13, 187);
            this.dllGroupBox.Name = "dllGroupBox";
            this.dllGroupBox.Size = new System.Drawing.Size(385, 102);
            this.dllGroupBox.TabIndex = 1;
            this.dllGroupBox.TabStop = false;
            this.dllGroupBox.Text = "Dynamic-Link Libs";
            // 
            // linuxGameLibraryTextBox
            // 
            this.linuxGameLibraryTextBox.Location = new System.Drawing.Point(123, 47);
            this.linuxGameLibraryTextBox.Name = "linuxGameLibraryTextBox";
            this.linuxGameLibraryTextBox.Size = new System.Drawing.Size(250, 20);
            this.linuxGameLibraryTextBox.TabIndex = 6;
            // 
            // osxGameLibraryTextBox
            // 
            this.osxGameLibraryTextBox.Location = new System.Drawing.Point(123, 73);
            this.osxGameLibraryTextBox.Name = "osxGameLibraryTextBox";
            this.osxGameLibraryTextBox.Size = new System.Drawing.Size(250, 20);
            this.osxGameLibraryTextBox.TabIndex = 5;
            // 
            // osxGameLibraryLabel
            // 
            this.osxGameLibraryLabel.AutoSize = true;
            this.osxGameLibraryLabel.Location = new System.Drawing.Point(8, 73);
            this.osxGameLibraryLabel.Name = "osxGameLibraryLabel";
            this.osxGameLibraryLabel.Size = new System.Drawing.Size(92, 13);
            this.osxGameLibraryLabel.TabIndex = 4;
            this.osxGameLibraryLabel.Text = "Game DLL (OS X)";
            // 
            // linuxGameLibraryLabel
            // 
            this.linuxGameLibraryLabel.AutoSize = true;
            this.linuxGameLibraryLabel.Location = new System.Drawing.Point(8, 46);
            this.linuxGameLibraryLabel.Name = "linuxGameLibraryLabel";
            this.linuxGameLibraryLabel.Size = new System.Drawing.Size(92, 13);
            this.linuxGameLibraryLabel.TabIndex = 2;
            this.linuxGameLibraryLabel.Text = "Game DLL (Linux)";
            // 
            // winGameLibraryTextBox
            // 
            this.winGameLibraryTextBox.Location = new System.Drawing.Point(123, 20);
            this.winGameLibraryTextBox.Name = "winGameLibraryTextBox";
            this.winGameLibraryTextBox.Size = new System.Drawing.Size(250, 20);
            this.winGameLibraryTextBox.TabIndex = 1;
            // 
            // winGameLibraryLabel
            // 
            this.winGameLibraryLabel.AutoSize = true;
            this.winGameLibraryLabel.Location = new System.Drawing.Point(8, 20);
            this.winGameLibraryLabel.Name = "winGameLibraryLabel";
            this.winGameLibraryLabel.Size = new System.Drawing.Size(58, 13);
            this.winGameLibraryLabel.TabIndex = 0;
            this.winGameLibraryLabel.Text = "Game DLL";
            // 
            // developerGroupBox
            // 
            this.developerGroupBox.Controls.Add(this.developerWebpageTextBox);
            this.developerGroupBox.Controls.Add(this.developerWebpageLabel);
            this.developerGroupBox.Controls.Add(this.developerNameTextBox);
            this.developerGroupBox.Controls.Add(this.developerNameLabel);
            this.developerGroupBox.Location = new System.Drawing.Point(404, 79);
            this.developerGroupBox.Name = "developerGroupBox";
            this.developerGroupBox.Size = new System.Drawing.Size(385, 76);
            this.developerGroupBox.TabIndex = 7;
            this.developerGroupBox.TabStop = false;
            this.developerGroupBox.Text = "Developer";
            // 
            // developerWebpageTextBox
            // 
            this.developerWebpageTextBox.Location = new System.Drawing.Point(123, 47);
            this.developerWebpageTextBox.Name = "developerWebpageTextBox";
            this.developerWebpageTextBox.Size = new System.Drawing.Size(250, 20);
            this.developerWebpageTextBox.TabIndex = 6;
            // 
            // developerWebpageLabel
            // 
            this.developerWebpageLabel.AutoSize = true;
            this.developerWebpageLabel.Location = new System.Drawing.Point(8, 46);
            this.developerWebpageLabel.Name = "developerWebpageLabel";
            this.developerWebpageLabel.Size = new System.Drawing.Size(106, 13);
            this.developerWebpageLabel.TabIndex = 2;
            this.developerWebpageLabel.Text = "Developer Webpage";
            // 
            // developerNameTextBox
            // 
            this.developerNameTextBox.Location = new System.Drawing.Point(123, 20);
            this.developerNameTextBox.Name = "developerNameTextBox";
            this.developerNameTextBox.Size = new System.Drawing.Size(250, 20);
            this.developerNameTextBox.TabIndex = 1;
            // 
            // developerNameLabel
            // 
            this.developerNameLabel.AutoSize = true;
            this.developerNameLabel.Location = new System.Drawing.Point(8, 20);
            this.developerNameLabel.Name = "developerNameLabel";
            this.developerNameLabel.Size = new System.Drawing.Size(85, 13);
            this.developerNameLabel.TabIndex = 0;
            this.developerNameLabel.Text = "Developer name";
            // 
            // trainingMapTextBox
            // 
            this.trainingMapTextBox.Location = new System.Drawing.Point(123, 47);
            this.trainingMapTextBox.Name = "trainingMapTextBox";
            this.trainingMapTextBox.Size = new System.Drawing.Size(250, 20);
            this.trainingMapTextBox.TabIndex = 6;
            // 
            // trainingMapLabel
            // 
            this.trainingMapLabel.AutoSize = true;
            this.trainingMapLabel.Location = new System.Drawing.Point(8, 46);
            this.trainingMapLabel.Name = "trainingMapLabel";
            this.trainingMapLabel.Size = new System.Drawing.Size(97, 13);
            this.trainingMapLabel.TabIndex = 2;
            this.trainingMapLabel.Text = "Training map name";
            // 
            // startMapTextBox
            // 
            this.startMapTextBox.Location = new System.Drawing.Point(123, 20);
            this.startMapTextBox.Name = "startMapTextBox";
            this.startMapTextBox.Size = new System.Drawing.Size(250, 20);
            this.startMapTextBox.TabIndex = 1;
            // 
            // startMapLabel
            // 
            this.startMapLabel.AutoSize = true;
            this.startMapLabel.Location = new System.Drawing.Point(8, 20);
            this.startMapLabel.Name = "startMapLabel";
            this.startMapLabel.Size = new System.Drawing.Size(81, 13);
            this.startMapLabel.TabIndex = 0;
            this.startMapLabel.Text = "Start map name";
            // 
            // mapsGroupBox
            // 
            this.mapsGroupBox.Controls.Add(this.trainingMapTextBox);
            this.mapsGroupBox.Controls.Add(this.trainingMapLabel);
            this.mapsGroupBox.Controls.Add(this.startMapTextBox);
            this.mapsGroupBox.Controls.Add(this.startMapLabel);
            this.mapsGroupBox.Location = new System.Drawing.Point(404, 161);
            this.mapsGroupBox.Name = "mapsGroupBox";
            this.mapsGroupBox.Size = new System.Drawing.Size(385, 76);
            this.mapsGroupBox.TabIndex = 8;
            this.mapsGroupBox.TabStop = false;
            this.mapsGroupBox.Text = "Maps";
            // 
            // aboutButton
            // 
            this.aboutButton.Location = new System.Drawing.Point(404, 243);
            this.aboutButton.Name = "aboutButton";
            this.aboutButton.Size = new System.Drawing.Size(191, 23);
            this.aboutButton.TabIndex = 9;
            this.aboutButton.Text = "About";
            this.aboutButton.UseVisualStyleBackColor = true;
            // 
            // generateButton
            // 
            this.generateButton.Location = new System.Drawing.Point(404, 266);
            this.generateButton.Name = "generateButton";
            this.generateButton.Size = new System.Drawing.Size(383, 23);
            this.generateButton.TabIndex = 10;
            this.generateButton.Text = "Generate";
            this.generateButton.UseVisualStyleBackColor = true;
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(596, 243);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(191, 23);
            this.exitButton.TabIndex = 11;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 296);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.generateButton);
            this.Controls.Add(this.aboutButton);
            this.Controls.Add(this.mapsGroupBox);
            this.Controls.Add(this.developerGroupBox);
            this.Controls.Add(this.dllGroupBox);
            this.Controls.Add(this.modGroupBox);
            this.Controls.Add(this.bgPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.Text = "GoldSrc Game Info Generator";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.bgPanel.ResumeLayout(false);
            this.bgPanel.PerformLayout();
            this.modGroupBox.ResumeLayout(false);
            this.modGroupBox.PerformLayout();
            this.dllGroupBox.ResumeLayout(false);
            this.dllGroupBox.PerformLayout();
            this.developerGroupBox.ResumeLayout(false);
            this.developerGroupBox.PerformLayout();
            this.mapsGroupBox.ResumeLayout(false);
            this.mapsGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel bgPanel;
        private System.Windows.Forms.Label subtitleLabel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.GroupBox modGroupBox;
        private System.Windows.Forms.Label modNameLabel;
        private System.Windows.Forms.ComboBox modTypeComboBox;
        private System.Windows.Forms.Label modTypeLabel;
        private System.Windows.Forms.TextBox modNameTextBox;
        private System.Windows.Forms.TextBox modIconTextBox;
        private System.Windows.Forms.Label modIconLabel;
        private System.Windows.Forms.GroupBox dllGroupBox;
        private System.Windows.Forms.TextBox osxGameLibraryTextBox;
        private System.Windows.Forms.Label osxGameLibraryLabel;
        private System.Windows.Forms.Label linuxGameLibraryLabel;
        private System.Windows.Forms.TextBox winGameLibraryTextBox;
        private System.Windows.Forms.Label winGameLibraryLabel;
        private System.Windows.Forms.TextBox linuxGameLibraryTextBox;
        private System.Windows.Forms.GroupBox developerGroupBox;
        private System.Windows.Forms.TextBox developerWebpageTextBox;
        private System.Windows.Forms.Label developerWebpageLabel;
        private System.Windows.Forms.TextBox developerNameTextBox;
        private System.Windows.Forms.Label developerNameLabel;
        private System.Windows.Forms.TextBox trainingMapTextBox;
        private System.Windows.Forms.Label trainingMapLabel;
        private System.Windows.Forms.TextBox startMapTextBox;
        private System.Windows.Forms.Label startMapLabel;
        private System.Windows.Forms.GroupBox mapsGroupBox;
        private System.Windows.Forms.Button aboutButton;
        private System.Windows.Forms.Button generateButton;
        private System.Windows.Forms.Button exitButton;
    }
}

