
namespace GoldSrcGameInfoGenerator
{
    partial class AboutForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.subtitleLabel = new System.Windows.Forms.Label();
            this.bgPanel = new System.Windows.Forms.Panel();
            this.titleLabel = new System.Windows.Forms.Label();
            this.closeButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.linksGroupBox = new System.Windows.Forms.GroupBox();
            this.linkLabelGitHub = new System.Windows.Forms.LinkLabel();
            this.linkLabelWebsite = new System.Windows.Forms.LinkLabel();
            this.bgPanel.SuspendLayout();
            this.linksGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // subtitleLabel
            // 
            this.subtitleLabel.AutoSize = true;
            this.subtitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.subtitleLabel.Location = new System.Drawing.Point(486, 50);
            this.subtitleLabel.Name = "subtitleLabel";
            this.subtitleLabel.Size = new System.Drawing.Size(45, 15);
            this.subtitleLabel.TabIndex = 1;
            this.subtitleLabel.Text = "By KZL";
            // 
            // bgPanel
            // 
            this.bgPanel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.bgPanel.Controls.Add(this.subtitleLabel);
            this.bgPanel.Controls.Add(this.titleLabel);
            this.bgPanel.Location = new System.Drawing.Point(0, 0);
            this.bgPanel.Name = "bgPanel";
            this.bgPanel.Size = new System.Drawing.Size(818, 85);
            this.bgPanel.TabIndex = 1;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.titleLabel.Location = new System.Drawing.Point(19, 26);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(478, 39);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "GoldSrc Game Info Generator";
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(647, 259);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(140, 25);
            this.closeButton.TabIndex = 2;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(734, 50);
            this.label1.TabIndex = 3;
            this.label1.Text = "GoldSrc Game Info Generator by KZL (KZL00) is an Open-Source tool written in C#\r\n" +
    "for Half-Life Modders to speed up the process of making liblist.gam file.";
            // 
            // linksGroupBox
            // 
            this.linksGroupBox.Controls.Add(this.linkLabelGitHub);
            this.linksGroupBox.Controls.Add(this.linkLabelWebsite);
            this.linksGroupBox.Location = new System.Drawing.Point(12, 254);
            this.linksGroupBox.Name = "linksGroupBox";
            this.linksGroupBox.Size = new System.Drawing.Size(100, 30);
            this.linksGroupBox.TabIndex = 4;
            this.linksGroupBox.TabStop = false;
            this.linksGroupBox.Text = "Links";
            // 
            // linkLabelGitHub
            // 
            this.linkLabelGitHub.AutoSize = true;
            this.linkLabelGitHub.Location = new System.Drawing.Point(58, 16);
            this.linkLabelGitHub.Name = "linkLabelGitHub";
            this.linkLabelGitHub.Size = new System.Drawing.Size(40, 13);
            this.linkLabelGitHub.TabIndex = 1;
            this.linkLabelGitHub.TabStop = true;
            this.linkLabelGitHub.Text = "GitHub";
            this.linkLabelGitHub.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelGitHub_LinkClicked);
            // 
            // linkLabelWebsite
            // 
            this.linkLabelWebsite.AutoSize = true;
            this.linkLabelWebsite.Location = new System.Drawing.Point(6, 16);
            this.linkLabelWebsite.Name = "linkLabelWebsite";
            this.linkLabelWebsite.Size = new System.Drawing.Size(46, 13);
            this.linkLabelWebsite.TabIndex = 0;
            this.linkLabelWebsite.TabStop = true;
            this.linkLabelWebsite.Text = "Website";
            this.linkLabelWebsite.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelWebsite_LinkClicked);
            // 
            // AboutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 296);
            this.Controls.Add(this.linksGroupBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.bgPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "AboutForm";
            this.ShowIcon = false;
            this.Text = "About GoldSrc Game Info Generator";
            this.bgPanel.ResumeLayout(false);
            this.bgPanel.PerformLayout();
            this.linksGroupBox.ResumeLayout(false);
            this.linksGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label subtitleLabel;
        private System.Windows.Forms.Panel bgPanel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox linksGroupBox;
        private System.Windows.Forms.LinkLabel linkLabelGitHub;
        private System.Windows.Forms.LinkLabel linkLabelWebsite;
    }
}