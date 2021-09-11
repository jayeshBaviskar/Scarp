using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Scrap.Investing.com;

namespace Scrap
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            frm1.ShowDialog();
            
        }

        private void DashBoardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dashboard frm1 = new Dashboard();
            frm1.ShowDialog();

        }

        private void OptionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Options frm1 = new Options();
            frm1.Show();
        }

        private void bSECronToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
    }
}
