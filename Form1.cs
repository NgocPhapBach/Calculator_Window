using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calc_Phap
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Double Result_Value = 0;
        String Operator_Performed = " ";
        bool PerformedOp = false;

        private void NhapSo(object sender, EventArgs e)
        {
            if (txtResult.Text == "0" || PerformedOp)
                txtResult.Clear();

            PerformedOp = false;
            Button button = (Button)sender;
            if (button.Text == ".")
            {
                if (!txtResult.Text.Contains("."))
                    txtResult.Text += button.Text;
            }

            else
                txtResult.Text += button.Text;
        }

        private void Operator_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (Result_Value != 0)
            {
                btnBang.PerformClick();
                Operator_Performed = button.Text;
                lblShow.Text = Result_Value + " " + Operator_Performed;
                PerformedOp = true;
            }
            else
            {

                Operator_Performed = button.Text;
                Result_Value = Double.Parse(txtResult.Text);
                lblShow.Text = Result_Value + " " + Operator_Performed;
                PerformedOp = true;
            }
        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            string text = txtResult.Text;

            if (text.Length == 1)
                txtResult.Text = "0";
            else
                txtResult.Text = text.Remove(text.Length - 1);
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            txtResult.Text = "0";
            Result_Value = 0;
            lblShow.Text = " ";
        }

        private void btnBang_Click(object sender, EventArgs e)
        {
            double tam = Double.Parse(txtResult.Text);
            switch (Operator_Performed)
            {
                case "+":
                    txtResult.Text = (Result_Value + tam).ToString();
                    break;

                case "-":
                    txtResult.Text = (Result_Value - tam).ToString();
                    break;

                case "*":
                    txtResult.Text = (Result_Value * tam).ToString();
                    break;

                case "/":
                    txtResult.Text = (Result_Value / tam).ToString();
                    break;
                case "%":
                    txtResult.Text = (tam / 100).ToString();
                    break;
                case "+/-":
                    txtResult.Text = (-1 * tam).ToString();
                    break;

                default:
                    break;

            }
            Result_Value = Double.Parse(txtResult.Text);
            lblShow.Text = " ";
        }

    }
}
