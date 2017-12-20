using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;
using System.Collections.Generic;

namespace FxWA
{
    public partial class Form1 : Form
    {
        public int TPPips { get; set; }
        public int SLPips { get; set; }
        public Form1()
        {
            InitializeComponent();
            cbMarketExecutionType.Items.Insert(0, "BUY");
            cbMarketExecutionType.Items.Insert(1, "SELL");
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            TPPips = int.Parse(tbTPPips.Text);
            SLPips = int.Parse(tbSLPips.Text);
            if (tbEntryPrice.Text.ToLower().Contains("jpy"))
            {
                if (cbMarketExecutionType.SelectedIndex == 0)
                {
                    lbTakeProfit.Text = double.Parse(tbEntryPrice1.Text) + 0.01*TPPips + "";
                    lbStopLoss.Text = double.Parse(tbEntryPrice1.Text) - 0.01*SLPips + "";
                }
                else
                {
                    lbTakeProfit.Text = double.Parse(tbEntryPrice1.Text) - 0.01 * TPPips + "";
                    lbStopLoss.Text = double.Parse(tbEntryPrice1.Text) + 0.01 * SLPips + "";
                }
            }
            else
            {

                if (cbMarketExecutionType.SelectedIndex == 0)
                {
                    lbTakeProfit.Text = double.Parse(tbEntryPrice1.Text) + 0.0001 * TPPips + "";
                    lbStopLoss.Text = double.Parse(tbEntryPrice1.Text) - 0.0001 * SLPips + "";
                }
                else
                {
                    lbTakeProfit.Text = double.Parse(tbEntryPrice1.Text) - 0.0001 * TPPips + "";
                    lbStopLoss.Text = double.Parse(tbEntryPrice1.Text) + 0.0001 * SLPips + "";
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
