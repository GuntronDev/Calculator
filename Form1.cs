using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Button_Click(object sender, EventArgs e)
        {
            Button ButtonPress = (Button)sender;
            TextBoxResult.Text += ButtonPress.Text;
        }

        private void ButtonEquels_Click(object sender, EventArgs e)
        {
            if (TextBoxResult.Text != String.Empty && TextBoxOperation.Text != String.Empty && TextBoxLastNumber.Text != String.Empty && TextBoxResult.Text != ",")
            {

                decimal FirstNumber = Convert.ToDecimal(TextBoxLastNumber.Text);
                decimal SecondNumber = Convert.ToDecimal(TextBoxResult.Text);

                switch (TextBoxOperation.Text)
                {
                    case "+":
                        TextBoxResult.Text = Convert.ToString(FirstNumber + SecondNumber);
                        break;

                    case "-":
                        TextBoxResult.Text = Convert.ToString(FirstNumber - SecondNumber);
                        break;

                    case "/":

                        try
                        {
                            TextBoxResult.Text = Convert.ToString(FirstNumber / SecondNumber);
                        }
                        catch (DivideByZeroException)
                        {
                            TextBoxResult.Text = "0";
                        }


                        break;

                    case "*":
                        TextBoxResult.Text = Convert.ToString(FirstNumber * SecondNumber);
                        break;
                }
                TextBoxOperation.Text = null;
                TextBoxLastNumber.Text = null;
            }
            else
            {
                return;
            }
        }

        private void ButtonOperation_Click(object sender, EventArgs e)
        {
            Button ButtonOperation = (Button)sender;

            if (TextBoxResult.Text != ",")
            {
                if (TextBoxLastNumber.Text == String.Empty && TextBoxOperation.Text == String.Empty && TextBoxResult.Text != String.Empty)
                {
                    TextBoxOperation.Text = ButtonOperation.Text;
                    TextBoxLastNumber.Text = TextBoxResult.Text;
                    TextBoxResult.Text = null;
                }
                else if (TextBoxLastNumber.Text == String.Empty && TextBoxOperation.Text == String.Empty && TextBoxResult.Text == String.Empty)
                {
                    TextBoxLastNumber.Text = "0";
                    TextBoxOperation.Text = ButtonOperation.Text;
                }
                else if (TextBoxLastNumber.Text != String.Empty && TextBoxOperation.Text != String.Empty && TextBoxResult.Text == String.Empty)
                {
                    TextBoxOperation.Text = ButtonOperation.Text;
                }
                else if (TextBoxResult.Text != String.Empty && TextBoxOperation.Text != String.Empty && TextBoxLastNumber.Text != String.Empty)
                {
                    ButtonEquels_Click(this, EventArgs.Empty);
                    TextBoxLastNumber.Text = TextBoxResult.Text;
                    TextBoxOperation.Text = ButtonOperation.Text;
                    TextBoxResult.Text = null;
                }
            }
            else { return; }
        }

        private void ButtonC_Click(object sender, EventArgs e)
        {
            TextBoxOperation.Text = null;
            TextBoxLastNumber.Text = null;
            TextBoxResult.Text = null;
        }

        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            if (TextBoxResult.Text != String.Empty)
            {
                TextBoxResult.Text = TextBoxResult.Text.Remove(TextBoxResult.Text.Length - 1);
            }
        }

        private void ButtonPeriod_Click(object sender, EventArgs e)
        {
            Button ButtonPress = (Button)sender;
            int PeriodCount = 0;

            foreach (char Number in TextBoxResult.Text)
            {
                if (Number == ',')
                {
                    PeriodCount++;
                }
            }
            if (PeriodCount == 0)
            {
                TextBoxResult.Text += ButtonPress.Text;
            }
            else { return; }
        }

    }
}
