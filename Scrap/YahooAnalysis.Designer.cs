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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
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
            this.cmbShares.Location = new System.Drawing.Point(470, 13);
            this.cmbShares.Name = "cmbShares";
            this.cmbShares.Size = new System.Drawing.Size(448, 28);
            this.cmbShares.TabIndex = 1;
            this.cmbShares.SelectedIndexChanged += new System.EventHandler(this.cmbShares_SelectedIndexChanged);
            // 
            // dateFrom
            // 
            this.dateFrom.Location = new System.Drawing.Point(470, 58);
            this.dateFrom.Name = "dateFrom";
            this.dateFrom.Size = new System.Drawing.Size(200, 26);
            this.dateFrom.TabIndex = 2;
            // 
            // dateTo
            // 
            this.dateTo.Location = new System.Drawing.Point(718, 58);
            this.dateTo.Name = "dateTo";
            this.dateTo.Size = new System.Drawing.Size(200, 26);
            this.dateTo.TabIndex = 3;
            // 
            // YahooAnalysis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1452, 746);
            this.Controls.Add(this.dateTo);
            this.Controls.Add(this.dateFrom);
            this.Controls.Add(this.cmbShares);
            this.Controls.Add(this.dataGridView1);
            this.Name = "YahooAnalysis";
            this.Text = "YahooAnalysis";
            this.Load += new System.EventHandler(this.YahooAnalysis_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cmbShares;
        private System.Windows.Forms.DateTimePicker dateFrom;
        private System.Windows.Forms.DateTimePicker dateTo;
    }
}