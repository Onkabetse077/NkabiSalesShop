using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nkabi_Sales_Shop
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }
        string initialPrice;
        double day1;
        double day2;
        double day3;
        double day4;
        double day5;


        private void btnCalculatePrice_Main_Click(object sender, EventArgs e)
        {
            if(tbInitialPrice_Main.Text == "")
            {
                MessageBox.Show("Please Enter the Initial Price!!!", "Error Message",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                initialPrice = tbInitialPrice_Main.Text.Trim();

                if (initialPrice.Contains(",") && !initialPrice.Contains(".")) {
                    day1 = Convert.ToDouble(initialPrice);
                    day2 = Math.Round(day1 * 0.90, 2);
                    day3 = Math.Round(day2 * 0.90, 2);
                    day4 = Math.Round(day3 * 0.90, 2);
                    day5 = Math.Round(day4 * 0.90, 2);

                    lblPrice1_Main.Text = initialPrice;
                    lblPrice2_Main.Text = Convert.ToString(day2);
                    lblPrice3_Main.Text = Convert.ToString(day3);
                    lblPrice4_Main.Text = Convert.ToString(day4);
                    lblPrice5_Main.Text = Convert.ToString(day5);
                }
                else
                {
                    MessageBox.Show("Please Enter the Initial Price Correctly", "Error Message",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                lblPrice1_Main.Text = initialPrice;
                lblPrice2_Main.Text = Convert.ToString(day2);
                lblPrice3_Main.Text = Convert.ToString(day3);
                lblPrice4_Main.Text = Convert.ToString(day4);
                lblPrice5_Main.Text = Convert.ToString(day5);
            }
        }

        private void lblX_Main_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are sure you want to Exit?", "Confirmation Message", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
