using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsAppDemo
{
    public partial class CalculatorForm : Form
    {
        public CalculatorForm()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnMul_Click(object sender, EventArgs e)
        {
            int a, b, c;
            a = Convert.ToInt32(txtFirst.Text);
            b = Convert.ToInt32(txtSecond.Text);
            c = a * b;
            lblMsg.Text = c.ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //lblMsg.Text = txtFirst.Text + txtSecond.Text;
           
            int a, b, c;
            a = Convert.ToInt32(txtFirst.Text);
            b = Convert.ToInt32(txtSecond.Text);
            c = a + b;
           lblMsg.Text = c.ToString();
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            int a, b, c;
            a = Convert.ToInt32(txtFirst.Text);
            b = Convert.ToInt32(txtSecond.Text);
            c = a - b;
            lblMsg.Text = c.ToString();
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            int a, b, c;
            a = Convert.ToInt32(txtFirst.Text);
            b = Convert.ToInt32(txtSecond.Text);
            c = a / b;
            lblMsg.Text = c.ToString();
        }
    }
}
