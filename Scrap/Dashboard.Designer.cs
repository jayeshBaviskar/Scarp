namespace Scrap
{
    partial class Dashboard
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
            this.label1 = new System.Windows.Forms.Label();
            this.pnl_Nifty50 = new System.Windows.Forms.Panel();
            this.lbl_rise_Nifty50 = new System.Windows.Forms.Label();
            this.lbl_val__Nifty50 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pnl_Sensex = new System.Windows.Forms.Panel();
            this.lbl_rise_Sensex = new System.Windows.Forms.Label();
            this.lbl_Val__Sensex = new System.Windows.Forms.Label();
            this.pnl_BankNifty = new System.Windows.Forms.Panel();
            this.lbl_rise_BankNifty = new System.Windows.Forms.Label();
            this.lbl_val_BankNifty = new System.Windows.Forms.Label();
            this.timer_Nifty50 = new System.Windows.Forms.Timer(this.components);
            this.timer_Sensex = new System.Windows.Forms.Timer(this.components);
            this.timer_BankNifty = new System.Windows.Forms.Timer(this.components);
            this.pnl_Nifty50.SuspendLayout();
            this.pnl_Sensex.SuspendLayout();
            this.pnl_BankNifty.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 607);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 46);
            this.button1.TabIndex = 0;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(431, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "NIFTY 50";
            // 
            // pnl_Nifty50
            // 
            this.pnl_Nifty50.BackColor = System.Drawing.Color.LightGreen;
            this.pnl_Nifty50.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_Nifty50.Controls.Add(this.lbl_rise_Nifty50);
            this.pnl_Nifty50.Controls.Add(this.lbl_val__Nifty50);
            this.pnl_Nifty50.Location = new System.Drawing.Point(375, 66);
            this.pnl_Nifty50.Name = "pnl_Nifty50";
            this.pnl_Nifty50.Size = new System.Drawing.Size(247, 139);
            this.pnl_Nifty50.TabIndex = 2;
            // 
            // lbl_rise_Nifty50
            // 
            this.lbl_rise_Nifty50.Location = new System.Drawing.Point(3, 90);
            this.lbl_rise_Nifty50.Name = "lbl_rise_Nifty50";
            this.lbl_rise_Nifty50.Size = new System.Drawing.Size(239, 29);
            this.lbl_rise_Nifty50.TabIndex = 3;
            this.lbl_rise_Nifty50.Text = "93.30 (0.73%)";
            this.lbl_rise_Nifty50.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_val__Nifty50
            // 
            this.lbl_val__Nifty50.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_val__Nifty50.Location = new System.Drawing.Point(3, 27);
            this.lbl_val__Nifty50.Name = "lbl_val__Nifty50";
            this.lbl_val__Nifty50.Size = new System.Drawing.Size(239, 52);
            this.lbl_val__Nifty50.TabIndex = 2;
            this.lbl_val__Nifty50.Text = "00000.00";
            this.lbl_val__Nifty50.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(666, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 37);
            this.label2.TabIndex = 1;
            this.label2.Text = "SENSEX";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(895, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(208, 37);
            this.label3.TabIndex = 1;
            this.label3.Text = "BANK NIFTY";
            // 
            // pnl_Sensex
            // 
            this.pnl_Sensex.BackColor = System.Drawing.Color.LightGreen;
            this.pnl_Sensex.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_Sensex.Controls.Add(this.lbl_rise_Sensex);
            this.pnl_Sensex.Controls.Add(this.lbl_Val__Sensex);
            this.pnl_Sensex.Location = new System.Drawing.Point(628, 66);
            this.pnl_Sensex.Name = "pnl_Sensex";
            this.pnl_Sensex.Size = new System.Drawing.Size(247, 139);
            this.pnl_Sensex.TabIndex = 4;
            // 
            // lbl_rise_Sensex
            // 
            this.lbl_rise_Sensex.Location = new System.Drawing.Point(3, 90);
            this.lbl_rise_Sensex.Name = "lbl_rise_Sensex";
            this.lbl_rise_Sensex.Size = new System.Drawing.Size(239, 29);
            this.lbl_rise_Sensex.TabIndex = 3;
            this.lbl_rise_Sensex.Text = "93.30 (0.73%)";
            this.lbl_rise_Sensex.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Val__Sensex
            // 
            this.lbl_Val__Sensex.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Val__Sensex.Location = new System.Drawing.Point(3, 27);
            this.lbl_Val__Sensex.Name = "lbl_Val__Sensex";
            this.lbl_Val__Sensex.Size = new System.Drawing.Size(239, 52);
            this.lbl_Val__Sensex.TabIndex = 2;
            this.lbl_Val__Sensex.Text = "00000.00";
            this.lbl_Val__Sensex.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnl_BankNifty
            // 
            this.pnl_BankNifty.BackColor = System.Drawing.Color.LightGreen;
            this.pnl_BankNifty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_BankNifty.Controls.Add(this.lbl_rise_BankNifty);
            this.pnl_BankNifty.Controls.Add(this.lbl_val_BankNifty);
            this.pnl_BankNifty.Location = new System.Drawing.Point(881, 66);
            this.pnl_BankNifty.Name = "pnl_BankNifty";
            this.pnl_BankNifty.Size = new System.Drawing.Size(247, 139);
            this.pnl_BankNifty.TabIndex = 4;
            // 
            // lbl_rise_BankNifty
            // 
            this.lbl_rise_BankNifty.Location = new System.Drawing.Point(3, 90);
            this.lbl_rise_BankNifty.Name = "lbl_rise_BankNifty";
            this.lbl_rise_BankNifty.Size = new System.Drawing.Size(239, 29);
            this.lbl_rise_BankNifty.TabIndex = 3;
            this.lbl_rise_BankNifty.Text = "93.30 (0.73%)";
            this.lbl_rise_BankNifty.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_val_BankNifty
            // 
            this.lbl_val_BankNifty.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_val_BankNifty.Location = new System.Drawing.Point(3, 27);
            this.lbl_val_BankNifty.Name = "lbl_val_BankNifty";
            this.lbl_val_BankNifty.Size = new System.Drawing.Size(239, 52);
            this.lbl_val_BankNifty.TabIndex = 2;
            this.lbl_val_BankNifty.Text = "00000.00";
            this.lbl_val_BankNifty.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer_Nifty50
            // 
            this.timer_Nifty50.Enabled = true;
            this.timer_Nifty50.Tick += new System.EventHandler(this.timer_Nifty50_Tick);
            // 
            // timer_Sensex
            // 
            this.timer_Sensex.Enabled = true;
            this.timer_Sensex.Tick += new System.EventHandler(this.timer_Sensex_Tick);
            // 
            // timer_BankNifty
            // 
            this.timer_BankNifty.Enabled = true;
            this.timer_BankNifty.Tick += new System.EventHandler(this.timer_BankNifty_Tick);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1470, 665);
            this.Controls.Add(this.pnl_BankNifty);
            this.Controls.Add(this.pnl_Sensex);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pnl_Nifty50);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.pnl_Nifty50.ResumeLayout(false);
            this.pnl_Sensex.ResumeLayout(false);
            this.pnl_BankNifty.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnl_Nifty50;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_val__Nifty50;
        private System.Windows.Forms.Label lbl_rise_Nifty50;
        private System.Windows.Forms.Panel pnl_Sensex;
        private System.Windows.Forms.Label lbl_rise_Sensex;
        private System.Windows.Forms.Label lbl_Val__Sensex;
        private System.Windows.Forms.Panel pnl_BankNifty;
        private System.Windows.Forms.Label lbl_rise_BankNifty;
        private System.Windows.Forms.Label lbl_val_BankNifty;
        private System.Windows.Forms.Timer timer_Nifty50;
        private System.Windows.Forms.Timer timer_Sensex;
        private System.Windows.Forms.Timer timer_BankNifty;
    }
}