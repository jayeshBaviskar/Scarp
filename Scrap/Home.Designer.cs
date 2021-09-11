namespace Scrap
{
    partial class Home
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modulesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.form1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dashBoardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bSECronToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.modulesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1067, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(116, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // modulesToolStripMenuItem
            // 
            this.modulesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.form1ToolStripMenuItem,
            this.dashBoardToolStripMenuItem,
            this.optionsToolStripMenuItem,
            this.bSECronToolStripMenuItem});
            this.modulesToolStripMenuItem.Name = "modulesToolStripMenuItem";
            this.modulesToolStripMenuItem.Size = new System.Drawing.Size(80, 24);
            this.modulesToolStripMenuItem.Text = "Modules";
            // 
            // form1ToolStripMenuItem
            // 
            this.form1ToolStripMenuItem.Name = "form1ToolStripMenuItem";
            this.form1ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.form1ToolStripMenuItem.Text = "Form1";
            this.form1ToolStripMenuItem.Click += new System.EventHandler(this.Form1ToolStripMenuItem_Click);
            // 
            // dashBoardToolStripMenuItem
            // 
            this.dashBoardToolStripMenuItem.Name = "dashBoardToolStripMenuItem";
            this.dashBoardToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.dashBoardToolStripMenuItem.Text = "Dashboard";
            this.dashBoardToolStripMenuItem.Click += new System.EventHandler(this.DashBoardToolStripMenuItem_Click);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.optionsToolStripMenuItem.Text = "Options";
            this.optionsToolStripMenuItem.Click += new System.EventHandler(this.OptionsToolStripMenuItem_Click);
            // 
            // bSECronToolStripMenuItem
            // 
            this.bSECronToolStripMenuItem.Name = "bSECronToolStripMenuItem";
            this.bSECronToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.bSECronToolStripMenuItem.Text = "BSECron";
            this.bSECronToolStripMenuItem.Click += new System.EventHandler(this.bSECronToolStripMenuItem_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modulesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem form1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dashBoardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bSECronToolStripMenuItem;
    }
}