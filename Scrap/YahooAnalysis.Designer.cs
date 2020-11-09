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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 205);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1422, 538);
            this.dataGridView1.TabIndex = 0;
            // 
            // cmbShares
            // 
            this.cmbShares.FormattingEnabled = true;
            this.cmbShares.Location = new System.Drawing.Point(12, 43);
            this.cmbShares.Name = "cmbShares";
            this.cmbShares.Size = new System.Drawing.Size(448, 28);
            this.cmbShares.TabIndex = 1;
            this.cmbShares.SelectedIndexChanged += new System.EventHandler(this.cmbShares_SelectedIndexChanged);
            // 
            // dateFrom
            // 
            this.dateFrom.Location = new System.Drawing.Point(12, 88);
            this.dateFrom.Name = "dateFrom";
            this.dateFrom.Size = new System.Drawing.Size(200, 26);
            this.dateFrom.TabIndex = 2;
            // 
            // dateTo
            // 
            this.dateTo.Location = new System.Drawing.Point(260, 88);
            this.dateTo.Name = "dateTo";
            this.dateTo.Size = new System.Drawing.Size(200, 26);
            this.dateTo.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 132);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(448, 49);
            this.button1.TabIndex = 4;
            this.button1.Text = "Verify Symbols";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(580, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "label1";
            // 
            // rdBSE
            // 
            this.rdBSE.AutoSize = true;
            this.rdBSE.Checked = true;
            this.rdBSE.Location = new System.Drawing.Point(13, 13);
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
            this.rdNSE.Location = new System.Drawing.Point(86, 12);
            this.rdNSE.Name = "rdNSE";
            this.rdNSE.Size = new System.Drawing.Size(67, 24);
            this.rdNSE.TabIndex = 7;
            this.rdNSE.Text = "NSE";
            this.rdNSE.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(467, 132);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(178, 49);
            this.button2.TabIndex = 8;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // YahooAnalysis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1452, 746);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.rdNSE);
            this.Controls.Add(this.rdBSE);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dateTo);
            this.Controls.Add(this.dateFrom);
            this.Controls.Add(this.cmbShares);
            this.Controls.Add(this.dataGridView1);
            this.Name = "YahooAnalysis";
            this.Text = "YahooAnalysis";
            this.Load += new System.EventHandler(this.YahooAnalysis_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}