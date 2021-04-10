namespace Scrap
{
    partial class Options
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
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.button2 = new System.Windows.Forms.Button();
            this.cmbTime = new System.Windows.Forms.ComboBox();
            this.lblLastExecutedOn = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCallOpenInterest = new System.Windows.Forms.Label();
            this.lblPutOpenInterest = new System.Windows.Forms.Label();
            this.lblsign = new System.Windows.Forms.Label();
            this.lblSignal = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(18, 159);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(209, 69);
            this.button1.TabIndex = 1;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 10000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(18, 61);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(439, 38);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(248, 159);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(209, 69);
            this.button2.TabIndex = 3;
            this.button2.Text = "Stop";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // cmbTime
            // 
            this.cmbTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTime.FormattingEnabled = true;
            this.cmbTime.Items.AddRange(new object[] {
            "1",
            "2",
            "5",
            "10",
            "15"});
            this.cmbTime.Location = new System.Drawing.Point(18, 105);
            this.cmbTime.Name = "cmbTime";
            this.cmbTime.Size = new System.Drawing.Size(439, 39);
            this.cmbTime.TabIndex = 4;
            // 
            // lblLastExecutedOn
            // 
            this.lblLastExecutedOn.AutoSize = true;
            this.lblLastExecutedOn.ForeColor = System.Drawing.Color.White;
            this.lblLastExecutedOn.Location = new System.Drawing.Point(8, 8);
            this.lblLastExecutedOn.Name = "lblLastExecutedOn";
            this.lblLastExecutedOn.Size = new System.Drawing.Size(240, 32);
            this.lblLastExecutedOn.TabIndex = 5;
            this.lblLastExecutedOn.Text = "Last Executed On";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1942, 167);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(251, 32);
            this.label1.TabIndex = 7;
            this.label1.Text = "Call Open Interest:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1942, 228);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(244, 32);
            this.label2.TabIndex = 7;
            this.label2.Text = "Put Open Interest:";
            // 
            // lblCallOpenInterest
            // 
            this.lblCallOpenInterest.AutoSize = true;
            this.lblCallOpenInterest.Location = new System.Drawing.Point(2226, 167);
            this.lblCallOpenInterest.Name = "lblCallOpenInterest";
            this.lblCallOpenInterest.Size = new System.Drawing.Size(93, 32);
            this.lblCallOpenInterest.TabIndex = 7;
            this.lblCallOpenInterest.Text = "label1";
            // 
            // lblPutOpenInterest
            // 
            this.lblPutOpenInterest.AutoSize = true;
            this.lblPutOpenInterest.Location = new System.Drawing.Point(2226, 228);
            this.lblPutOpenInterest.Name = "lblPutOpenInterest";
            this.lblPutOpenInterest.Size = new System.Drawing.Size(93, 32);
            this.lblPutOpenInterest.TabIndex = 7;
            this.lblPutOpenInterest.Text = "label1";
            // 
            // lblsign
            // 
            this.lblsign.AutoSize = true;
            this.lblsign.Location = new System.Drawing.Point(1942, 298);
            this.lblsign.Name = "lblsign";
            this.lblsign.Size = new System.Drawing.Size(104, 32);
            this.lblsign.TabIndex = 7;
            this.lblsign.Text = "Signal:";
            // 
            // lblSignal
            // 
            this.lblSignal.AutoSize = true;
            this.lblSignal.Location = new System.Drawing.Point(2226, 298);
            this.lblSignal.Name = "lblSignal";
            this.lblSignal.Size = new System.Drawing.Size(93, 32);
            this.lblSignal.TabIndex = 7;
            this.lblSignal.Text = "label1";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1702, 73);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(217, 159);
            this.button3.TabIndex = 8;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbTime);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(40, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(475, 250);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Scrap Data";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.lblLastExecutedOn);
            this.panel1.Location = new System.Drawing.Point(30, 1404);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(2460, 49);
            this.panel1.TabIndex = 11;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(543, 41);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(284, 219);
            this.button4.TabIndex = 12;
            this.button4.Text = "Bank Nifty Historical Graph";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Options
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(2544, 1460);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.lblSignal);
            this.Controls.Add(this.lblPutOpenInterest);
            this.Controls.Add(this.lblsign);
            this.Controls.Add(this.lblCallOpenInterest);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Options";
            this.Text = "Options";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Options_Load);
            this.groupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox cmbTime;
        private System.Windows.Forms.Label lblLastExecutedOn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblCallOpenInterest;
        private System.Windows.Forms.Label lblPutOpenInterest;
        private System.Windows.Forms.Label lblsign;
        private System.Windows.Forms.Label lblSignal;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button4;
    }
}