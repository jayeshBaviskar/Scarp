namespace Scrap
{
    partial class YahooAnalysis
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cmbShares = new System.Windows.Forms.ComboBox();
            this.dateFrom = new System.Windows.Forms.DateTimePicker();
            this.dateTo = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.rdBSE = new System.Windows.Forms.RadioButton();
            this.rdNSE = new System.Windows.Forms.RadioButton();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdDefault = new System.Windows.Forms.RadioButton();
            this.rdSelected = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 152);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1445, 578);
            this.dataGridView1.TabIndex = 0;
            // 
            // cmbShares
            // 
            this.cmbShares.FormattingEnabled = true;
            this.cmbShares.Location = new System.Drawing.Point(945, 24);
            this.cmbShares.Name = "cmbShares";
            this.cmbShares.Size = new System.Drawing.Size(351, 28);
            this.cmbShares.TabIndex = 1;
            this.cmbShares.SelectedIndexChanged += new System.EventHandler(this.cmbShares_SelectedIndexChanged);
            // 
            // dateFrom
            // 
            this.dateFrom.Location = new System.Drawing.Point(945, 58);
            this.dateFrom.Name = "dateFrom";
            this.dateFrom.Size = new System.Drawing.Size(174, 26);
            this.dateFrom.TabIndex = 2;
            // 
            // dateTo
            // 
            this.dateTo.Location = new System.Drawing.Point(1125, 58);
            this.dateTo.Name = "dateTo";
            this.dateTo.Size = new System.Drawing.Size(171, 26);
            this.dateTo.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1325, 1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 49);
            this.button1.TabIndex = 4;
            this.button1.Text = "Verify Symbols";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(10, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "...";
            // 
            // rdBSE
            // 
            this.rdBSE.AutoSize = true;
            this.rdBSE.Checked = true;
            this.rdBSE.Location = new System.Drawing.Point(26, 38);
            this.rdBSE.Name = "rdBSE";
            this.rdBSE.Size = new System.Drawing.Size(67, 24);
            this.rdBSE.TabIndex = 6;
            this.rdBSE.TabStop = true;
            this.rdBSE.Text = "BSE";
            this.rdBSE.UseVisualStyleBackColor = true;
            // 
            // rdNSE
            // 
            this.rdNSE.AutoSize = true;
            this.rdNSE.Location = new System.Drawing.Point(99, 37);
            this.rdNSE.Name = "rdNSE";
            this.rdNSE.Size = new System.Drawing.Size(67, 24);
            this.rdNSE.TabIndex = 7;
            this.rdNSE.Text = "NSE";
            this.rdNSE.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(946, 90);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(350, 30);
            this.button2.TabIndex = 8;
            this.button2.Text = "Scan";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 734);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1451, 33);
            this.panel1.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdNSE);
            this.groupBox1.Controls.Add(this.rdBSE);
            this.groupBox1.Location = new System.Drawing.Point(413, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(188, 73);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Market";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdDefault);
            this.groupBox2.Controls.Add(this.rdSelected);
            this.groupBox2.Location = new System.Drawing.Point(607, 24);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(258, 73);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Shares";
            // 
            // rdDefault
            // 
            this.rdDefault.AutoSize = true;
            this.rdDefault.Location = new System.Drawing.Point(138, 38);
            this.rdDefault.Name = "rdDefault";
            this.rdDefault.Size = new System.Drawing.Size(86, 24);
            this.rdDefault.TabIndex = 7;
            this.rdDefault.Text = "Default";
            this.rdDefault.UseVisualStyleBackColor = true;
            this.rdDefault.CheckedChanged += new System.EventHandler(this.rdDefault_CheckedChanged);
            // 
            // rdSelected
            // 
            this.rdSelected.AutoSize = true;
            this.rdSelected.Checked = true;
            this.rdSelected.Location = new System.Drawing.Point(26, 38);
            this.rdSelected.Name = "rdSelected";
            this.rdSelected.Size = new System.Drawing.Size(97, 24);
            this.rdSelected.TabIndex = 6;
            this.rdSelected.TabStop = true;
            this.rdSelected.Text = "Selected";
            this.rdSelected.UseVisualStyleBackColor = true;
            this.rdSelected.CheckedChanged += new System.EventHandler(this.rdDefault_CheckedChanged);
            // 
            // YahooAnalysis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1452, 767);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dateTo);
            this.Controls.Add(this.dateFrom);
            this.Controls.Add(this.cmbShares);
            this.Controls.Add(this.dataGridView1);
            this.Name = "YahooAnalysis";
            this.Text = "Analysis";
            this.Load += new System.EventHandler(this.YahooAnalysis_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cmbShares;
        private System.Windows.Forms.DateTimePicker dateFrom;
        private System.Windows.Forms.DateTimePicker dateTo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rdBSE;
        private System.Windows.Forms.RadioButton rdNSE;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdDefault;
        private System.Windows.Forms.RadioButton rdSelected;
    }
}