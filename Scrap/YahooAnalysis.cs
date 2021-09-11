using Scarp;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using YahooFinanceApi;

namespace Scrap
{
    public partial class YahooAnalysis : Form
    {
        public YahooAnalysis()
        {
            InitializeComponent();
        }

        private void YahooAnalysis_Load(object sender, EventArgs e)
        {
            String[] lines = File.ReadAllLines("YahooSymbols.txt");
            foreach (String line in lines)
            {
                cmbShares.Items.Add(line);
            }

            dateFrom.Value = DateTime.Today.AddDays(-5);
            dateTo.Value = DateTime.Today;
        }

        private async void cmbShares_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            List<String> allValidShares = new List<string>();
            String exchange = rdBSE.Checked ? ".BO" : ".NS";
            for (int i = 0; i < cmbShares.Items.Count; ++i)
            {
                try
                {
                    var history = await Yahoo.GetHistoricalAsync(cmbShares.Items[i].ToString() + exchange, dateFrom.Value, dateTo.Value, Period.Daily);

                    dataGridView1.DataSource = history;

                    foreach (DataGridViewRow row in dataGridView1.Rows)
                        if (Convert.ToDecimal(row.Cells[1].Value) >= Convert.ToDecimal(row.Cells[4].Value))
                        {
                            row.DefaultCellStyle.BackColor = Color.LightPink;
                        }
                        else
                        {
                            row.DefaultCellStyle.BackColor = Color.LightGreen;
                        }

                    dataGridView1.Refresh();
                    allValidShares.Add(cmbShares.Items[i].ToString().Substring(0, cmbShares.Items[i].ToString().LastIndexOf(".")));
                    label1.Text = (i) + " of " + cmbShares.Items.Count;
                }
                catch (Exception)
                {
                    File.AppendAllText("Failed.txt", cmbShares.Items[i].ToString() + "\n");
                    label1.Text = (i) + " of " + cmbShares.Items.Count;
                }
            }

            List<string> distinctItems = allValidShares.Distinct().ToList();
            foreach (var item in distinctItems)
            {
                File.AppendAllText("Passed.txt", item + "\n");
            }
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            SortableBindingList<Analysis> lstAnalysis = new SortableBindingList<Analysis>();

            String exchange = rdBSE.Checked ? ".BO" : ".NS";
            for (int i = 0; i < cmbShares.Items.Count; ++i)            
            {
                Analysis analysis = new Analysis();
                analysis.Share = cmbShares.Items[i].ToString();

                try
                {
                    var history = await Yahoo.GetHistoricalAsync(cmbShares.Items[i].ToString() + exchange, dateFrom.Value, dateTo.Value, Period.Daily);

                    dataGridView1.DataSource = history;

                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        decimal close = Convert.ToDecimal(row.Cells[4].Value);
                        decimal open = Convert.ToDecimal(row.Cells[1].Value);
                        decimal changePerc = Convert.ToDecimal(row.Cells[8].Value);
                        decimal change = Convert.ToDecimal(row.Cells[7].Value);

                        analysis.TotalAmountGained += change;
                        analysis.TotalPercentage += changePerc;

                        analysis.Current = close;

                        if(analysis.Low == 0)
                        {
                            analysis.Low = close;
                        }

                        if (analysis.Low > close)
                        {
                            analysis.Low = close;
                        }

                        if (analysis.High < close)
                        {
                            analysis.High = close;
                        }

                        if (open >= close)
                        {
                            row.DefaultCellStyle.BackColor = Color.LightPink;
                            ++analysis.Looser;
                        }
                        else
                        {
                            row.DefaultCellStyle.BackColor = Color.LightGreen;
                            ++analysis.Gainer;
                        }

                        dataGridView1.Refresh();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.StackTrace);
                }
                finally
                {
                    label1.Text = (i + 1) + " of " + cmbShares.Items.Count;
                }

                lstAnalysis.Add(analysis);
            }

            dataGridView1.DataSource = lstAnalysis;
            dataGridView1.Refresh();
        }

        private void rdDefault_CheckedChanged(object sender, EventArgs e)
        {
            if(rdDefault.Checked)
            {

            }
            else if(rdSelected.Checked)
            {

            }
        }
    }
}