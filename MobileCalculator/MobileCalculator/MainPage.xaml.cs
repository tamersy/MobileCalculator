using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MobileCalculator
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public double number1, number2, result;
        public char op;

        public MainPage()
        {
            InitializeComponent();
        }

        public void btn1_Clicked(object sender, EventArgs e)
        {
            txtCalculate.Text += "1";
        }

        private void btn2_Clicked(object sender, EventArgs e)
        {
            txtCalculate.Text += "2";
        }

        private void btn3_Clicked(object sender, EventArgs e)
        {
            txtCalculate.Text += "3";
        }

        private void btnplus_Clicked(object sender, EventArgs e)
        {
            op = '+';
            number1 = Convert.ToDouble(txtCalculate.Text);
            txtCalculate.Text = "";
        }

        private void btn4_Clicked(object sender, EventArgs e)
        {
            txtCalculate.Text += "4";
        }

        private void btn5_Clicked(object sender, EventArgs e)
        {
            txtCalculate.Text += "5";
        }

        private void btn6_Clicked(object sender, EventArgs e)
        {
            txtCalculate.Text += "6";
        }

        private void btnminus_Clicked(object sender, EventArgs e)
        {
            op = '-';
            number1 = Convert.ToDouble(txtCalculate.Text);
            txtCalculate.Text = "";
        }

        private void btn7_Clicked(object sender, EventArgs e)
        {
            txtCalculate.Text += "7";
        }

        private void btn8_Clicked(object sender, EventArgs e)
        {
            txtCalculate.Text += "8";
        }

        private void btn9_Clicked(object sender, EventArgs e)
        {
            txtCalculate.Text += "9";
        }

        private void btnmultiplication_Clicked(object sender, EventArgs e)
        {
            op = '*';
            number1 = Convert.ToDouble(txtCalculate.Text);
            txtCalculate.Text = "";
        }

        private void btnclear_Clicked(object sender, EventArgs e)
        {
            txtCalculate.Text = "";
        }

        private void btn0_Clicked(object sender, EventArgs e)
        {
            txtCalculate.Text += "0";
        }

        private void btndot_Clicked(object sender, EventArgs e)
        {
            txtCalculate.Text += ".";
        }

        private void btndivide_Clicked(object sender, EventArgs e)
        {
            op = '/';
            number1 = Convert.ToDouble(txtCalculate.Text);
            txtCalculate.Text = "";
        }

        private void btnequal_Clicked(object sender, EventArgs e)
        {
            number2 = Convert.ToDouble(txtCalculate.Text);

            switch (op)
            {
                case '+':
                    result = number1 + number2;
                    break;
                case '-':
                    result = number1 - number2;
                    break;
                case '*':
                    result = number1 * number2;
                    break;
                case '/':
                    result = number1 / number2;
                    break;
            }

            txtCalculate.Text = Convert.ToString(result);
        }
    }
}
