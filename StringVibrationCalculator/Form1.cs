using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StringVibrationCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double f1 = 0;
        double f2 = 0;
        double f3 = 0;


        private void button1_Click(object sender, EventArgs e)
        {
            double ten;
            double beam;
            double len;
            double.TryParse(txtTn.Text, out ten);
            double.TryParse(txtBm.Text, out beam);
            double.TryParse(txtUl.Text, out len);

            if (txtTn.Text == "" || txtBm.Text == "" || txtUl.Text == "")
            {
                MessageBox.Show("Please enter values!", "Warning!");
            }
            else
            {
                f1 = (Math.PI / (2 * Math.PI)) * Math.Sqrt((ten * 9805) / (len * Math.Pow(beam, 2)));
                f2 = (2 * Math.PI / (2 * Math.PI)) * Math.Sqrt((ten * 9805) / (len * Math.Pow(beam, 2)));
                f3 = (3 * Math.PI / (2 * Math.PI)) * Math.Sqrt((ten * 9805) / (len * Math.Pow(beam, 2)));
                f1 = Math.Round(f1, 2);
                f2 = Math.Round(f2, 2);
                f3 = Math.Round(f3, 2);
                lbF1.Text = Convert.ToString(f1);
                lbF2.Text = Convert.ToString(f2);
                lbF3.Text = Convert.ToString(f3);
                hz1.Visible = true;
                hz2.Visible = true;
                hz3.Visible = true;
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            lbF1.Text = "";
            lbF2.Text = "";
            lbF3.Text = "";
            hz1.Visible = false;
            hz2.Visible = false;
            hz3.Visible = false;
            txtTn.Text = "";
            txtBm.Text = "";
            txtUl.Text = "";
        }

        private void txtTn_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(Char.IsNumber(e.KeyChar) || e.KeyChar == 8 || e.KeyChar == 46);
            if (txtTn.Text.Length == 0)
            {
                if (e.KeyChar == '.')
                {
                    e.Handled = true;
                }
            }
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 46)
            {
                e.Handled = true;
            }
            if (e.KeyChar == '.' && txtTn.Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
            if (txtTn.Text.StartsWith("0") && !txtTn.Text.StartsWith("0.") && e.KeyChar != '\b' && e.KeyChar != (int)'.')
            {
                e.Handled = true;
            }
        }

        private void txtBm_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(Char.IsNumber(e.KeyChar) || e.KeyChar == 8 || e.KeyChar == 46);
            if (txtBm.Text.Length == 0)
            {
                if (e.KeyChar == '.')
                {
                    e.Handled = true;
                }
            }
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 46)
            {
                e.Handled = true;
            }
            if (e.KeyChar == '.' && txtBm.Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
            if (txtBm.Text.StartsWith("0") && !txtBm.Text.StartsWith("0.") && e.KeyChar != '\b' && e.KeyChar != (int)'.')
            {
                e.Handled = true;
            }
        }

        private void txtUl_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(Char.IsNumber(e.KeyChar) || e.KeyChar == 8 || e.KeyChar == 46);
            if (txtUl.Text.Length == 0)
            {
                if (e.KeyChar == '.')
                {
                    e.Handled = true;
                }
            }
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 46)
            {
                e.Handled = true;
            }
            if (e.KeyChar == '.' && txtUl.Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
            if (txtUl.Text.StartsWith("0") && !txtUl.Text.StartsWith("0.") && e.KeyChar != '\b' && e.KeyChar != (int)'.')
            {
                e.Handled = true;
                //sss
            }
        }
    }
}
