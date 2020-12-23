namespace Sibor
{
    partial class TabWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TabWindow));
            this.toolbarBackground = new System.Windows.Forms.Panel();
            this.bookmarksButton = new System.Windows.Forms.PictureBox();
            this.settingsButton = new System.Windows.Forms.PictureBox();
            this.homeButton = new System.Windows.Forms.PictureBox();
            this.forwardButton = new System.Windows.Forms.PictureBox();
            this.backButton = new System.Windows.Forms.PictureBox();
            this.bookmarksBar = new System.Windows.Forms.ToolStrip();
            this.urlTextBox = new System.Windows.Forms.TextBox();
            this.urlBoxBackground = new System.Windows.Forms.Panel();
            this.bookmarksMore = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolbarBackground.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bookmarksButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.settingsButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.homeButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.forwardButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.backButton)).BeginInit();
            this.bookmarksBar.SuspendLayout();
            this.urlBoxBackground.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolbarBackground
            // 
            this.toolbarBackground.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.toolbarBackground.Controls.Add(this.bookmarksButton);
            this.toolbarBackground.Controls.Add(this.settingsButton);
            this.toolbarBackground.Controls.Add(this.homeButton);
            this.toolbarBackground.Controls.Add(this.forwardButton);
            this.toolbarBackground.Controls.Add(this.backButton);
            this.toolbarBackground.Dock = System.Windows.Forms.DockStyle.Top;
            this.toolbarBackground.Location = new System.Drawing.Point(0, 0);
            this.toolbarBackground.Name = "toolbarBackground";
            this.toolbarBackground.Size = new System.Drawing.Size(534, 38);
            this.toolbarBackground.TabIndex = 2;
            // 
            // bookmarksButton
            // 
            this.bookmarksButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bookmarksButton.BackColor = System.Drawing.Color.Transparent;
            this.bookmarksButton.Image = global::Sibor.Resources.AddFavorite;
            this.bookmarksButton.Location = new System.Drawing.Point(466, 5);
            this.bookmarksButton.Margin = new System.Windows.Forms.Padding(4, 4, 3, 3);
            this.bookmarksButton.Name = "bookmarksButton";
            this.bookmarksButton.Size = new System.Drawing.Size(29, 28);
            this.bookmarksButton.TabIndex = 6;
            this.bookmarksButton.TabStop = false;
            this.bookmarksButton.MouseEnter += new System.EventHandler(this.Button_MouseEnter);
            this.bookmarksButton.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
            // 
            // settingsButton
            // 
            this.settingsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.settingsButton.BackColor = System.Drawing.Color.Transparent;
            this.settingsButton.Image = global::Sibor.Resources.MenuActive;
            this.settingsButton.Location = new System.Drawing.Point(498, 5);
            this.settingsButton.Margin = new System.Windows.Forms.Padding(4, 4, 3, 3);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Size = new System.Drawing.Size(29, 28);
            this.settingsButton.TabIndex = 5;
            this.settingsButton.TabStop = false;
            this.settingsButton.MouseEnter += new System.EventHandler(this.Button_MouseEnter);
            this.settingsButton.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
            // 
            // homeButton
            // 
            this.homeButton.BackColor = System.Drawing.Color.Transparent;
            this.homeButton.Image = global::Sibor.Resources.HomeActive;
            this.homeButton.Location = new System.Drawing.Point(38, 5);
            this.homeButton.Margin = new System.Windows.Forms.Padding(4, 4, 3, 3);
            this.homeButton.Name = "homeButton";
            this.homeButton.Size = new System.Drawing.Size(28, 28);
            this.homeButton.TabIndex = 4;
            this.homeButton.TabStop = false;
            this.homeButton.Click += new System.EventHandler(this.HomeButton_Click);
            this.homeButton.MouseEnter += new System.EventHandler(this.Button_MouseEnter);
            this.homeButton.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
            // 
            // forwardButton
            // 
            this.forwardButton.BackColor = System.Drawing.Color.Transparent;
            this.forwardButton.Image = global::Sibor.Resources.ForwardActive;
            this.forwardButton.Location = new System.Drawing.Point(69, 5);
            this.forwardButton.Margin = new System.Windows.Forms.Padding(4, 4, 3, 3);
            this.forwardButton.Name = "forwardButton";
            this.forwardButton.Size = new System.Drawing.Size(28, 28);
            this.forwardButton.TabIndex = 3;
            this.forwardButton.TabStop = false;
            this.forwardButton.Click += new System.EventHandler(this.ForwardButton_Click);
            this.forwardButton.MouseEnter += new System.EventHandler(this.Button_MouseEnter);
            this.forwardButton.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.Transparent;
            this.backButton.Image = global::Sibor.Resources.BackActive;
            this.backButton.Location = new System.Drawing.Point(6, 5);
            this.backButton.Margin = new System.Windows.Forms.Padding(4, 4, 3, 3);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(28, 28);
            this.backButton.TabIndex = 2;
            this.backButton.TabStop = false;
            this.backButton.Click += new System.EventHandler(this.BackButton_Click);
            this.backButton.MouseEnter += new System.EventHandler(this.Button_MouseEnter);
            this.backButton.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
            // 
            // bookmarksBar
            // 
            this.bookmarksBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.bookmarksBar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bookmarksBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bookmarksMore});
            this.bookmarksBar.Location = new System.Drawing.Point(0, 38);
            this.bookmarksBar.Name = "bookmarksBar";
            this.bookmarksBar.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.bookmarksBar.Size = new System.Drawing.Size(534, 25);
            this.bookmarksBar.TabIndex = 3;
            this.bookmarksBar.Text = "Bookmarks Bar";
            // 
            // urlTextBox
            // 
            this.urlTextBox.BackColor = System.Drawing.Color.Gray;
            this.urlTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.urlTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.urlTextBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.urlTextBox.Location = new System.Drawing.Point(5, 3);
            this.urlTextBox.Margin = new System.Windows.Forms.Padding(9);
            this.urlTextBox.MinimumSize = new System.Drawing.Size(0, 28);
            this.urlTextBox.Name = "urlTextBox";
            this.urlTextBox.Size = new System.Drawing.Size(346, 18);
            this.urlTextBox.TabIndex = 1;
            this.urlTextBox.WordWrap = false;
            this.urlTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.UrlTextBox_KeyDown);
            // 
            // urlBoxBackground
            // 
            this.urlBoxBackground.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.urlBoxBackground.BackColor = System.Drawing.Color.Gray;
            this.urlBoxBackground.Controls.Add(this.urlTextBox);
            this.urlBoxBackground.ForeColor = System.Drawing.Color.Silver;
            this.urlBoxBackground.Location = new System.Drawing.Point(103, 5);
            this.urlBoxBackground.Name = "urlBoxBackground";
            this.urlBoxBackground.Padding = new System.Windows.Forms.Padding(5, 3, 5, 0);
            this.urlBoxBackground.Size = new System.Drawing.Size(356, 28);
            this.urlBoxBackground.TabIndex = 2;
            // 
            // bookmarksMore
            // 
            this.bookmarksMore.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.bookmarksMore.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.None;
            this.bookmarksMore.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bookmarksMore.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bookmarksMore.Name = "bookmarksMore";
            this.bookmarksMore.Size = new System.Drawing.Size(13, 22);
            this.bookmarksMore.Text = "toolStripDropDownButton1";
            // 
            // TabWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(534, 411);
            this.Controls.Add(this.bookmarksBar);
            this.Controls.Add(this.urlBoxBackground);
            this.Controls.Add(this.toolbarBackground);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TabWindow";
            this.Text = "TabWindow";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TabWindow_FormClosing);
            this.toolbarBackground.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bookmarksButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.settingsButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.homeButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.forwardButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.backButton)).EndInit();
            this.bookmarksBar.ResumeLayout(false);
            this.bookmarksBar.PerformLayout();
            this.urlBoxBackground.ResumeLayout(false);
            this.urlBoxBackground.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel toolbarBackground;
        private System.Windows.Forms.PictureBox backButton;
        private System.Windows.Forms.PictureBox forwardButton;
        private System.Windows.Forms.PictureBox homeButton;
        private System.Windows.Forms.ToolStrip bookmarksBar;
        private System.Windows.Forms.TextBox urlTextBox;
        private System.Windows.Forms.Panel urlBoxBackground;
        private System.Windows.Forms.PictureBox settingsButton;
        private System.Windows.Forms.PictureBox bookmarksButton;
        private System.Windows.Forms.ToolStripDropDownButton bookmarksMore;
    }
}