using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirstDesktopApp
{
    public partial class HesapMakinesi : Form
    {
        decimal number = 0;
        string operations = "";
        public HesapMakinesi()
        {
            InitializeComponent();
        }

        private void btnOne_Click(object sender, EventArgs e)
        {
            txtProgress.Text += "1";
        }

        private void btnTwo_Click(object sender, EventArgs e)
        {
            txtProgress.Text += "2";
        }

        private void btnThree_Click(object sender, EventArgs e)
        {
            txtProgress.Text += "3";
        }

        private void btnFour_Click(object sender, EventArgs e)
        {
            txtProgress.Text += "4";
        }

        private void btnFive_Click(object sender, EventArgs e)
        {
            txtProgress.Text += "5";
        }

        private void btnSix_Click(object sender, EventArgs e)
        {
            txtProgress.Text += "6";
        }

        private void btnSeven_Click(object sender, EventArgs e)
        {
            txtProgress.Text += "7";
        }

        private void btnEight_Click(object sender, EventArgs e)
        {
            txtProgress.Text += "8";
        }

        private void btnNine_Click(object sender, EventArgs e)
        {
            txtProgress.Text += "9";
        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            txtProgress.Text += "0";
        }

        private void btnReset_Click_1(object sender, EventArgs e)
        {
            txtProgress.Text += "";
            lbResult.Text = "Sonuç:";
            lbOperations.Text = "İşlemler:";
            number = 0;
            operations = "";
        }

        private void txtProgress_TextChanged(object sender, EventArgs e)
        {
            //if (txtProgress.Text == "") txtProgress.Text = "0";
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            if(txtProgress.Text != "")
            {
                if (operations == "")
                {
                    operations = txtProgress.Text;
                }
                else
                {
                    operations = number + " + " + txtProgress.Text;
                }
                lbOperations.Text = "İşlemler: " + operations;
            }
            decimal txtNumber = txtProgress.Text == "" ? 0 : Convert.ToDecimal(txtProgress.Text);
            number += txtNumber;
            lbResult.Text = "Sonuç: " + number;
            txtProgress.Text = "";
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {

            if (txtProgress.Text != "")
            {
                if (operations == "")
                {
                    operations = txtProgress.Text;
                }
                else
                {
                    operations = number + " - " + txtProgress.Text;
                }
                lbOperations.Text = "İşlemler: " + operations;
            }

            decimal txtNumber = txtProgress.Text == "" ? 0 : Convert.ToDecimal(txtProgress.Text);
            number -= txtNumber;
            lbResult.Text = "Sonuç: " + number;
            txtProgress.Text = "";
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {

            if (txtProgress.Text != "")
            {
                if (operations == "")
                {
                    operations = txtProgress.Text;
                }
                else
                {
                    operations = number + " * " + txtProgress.Text;
                }
                lbOperations.Text = "İşlemler: " + operations;
            }

            decimal txtNumber = txtProgress.Text == "" ? 0 : Convert.ToDecimal(txtProgress.Text);
            number *= txtNumber;
            lbResult.Text = "Sonuç: " + number;
            txtProgress.Text = "";
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {

            if (txtProgress.Text != "")
            {
                if (operations == "")
                {
                    operations = txtProgress.Text;
                }
                else
                {
                    operations = number + " / " + txtProgress.Text;
                }
                lbOperations.Text = "İşlemler: " + operations;
            }

            decimal txtNumber = txtProgress.Text == "" ? 1 : Convert.ToDecimal(txtProgress.Text);
            number /= txtNumber;
            lbResult.Text = "Sonuç: " + number;
            txtProgress.Text = "";
        }

        private void txtProgress_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!char.IsDigit(ch))
            {
                e.Handled = true;
            }

            if(ch == '+')
            {
                e.Handled = true;
                btnPlus_Click(sender, e);
            } else if(ch == '-') { 
                e.Handled = true;
                btnMinus_Click(sender, e);
            } else if(ch == '/') {
                e.Handled |= true;
                btnDivision_Click(sender, e);
            } else if(ch == '*') {
                e.Handled &= true;
                btnMultiply_Click(sender, e);
            }
        }
    }
}
