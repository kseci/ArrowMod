using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArrowMod
{
    public partial class Form1 : Form
    {
        bool dec2bin = true;
        int REMOVEME = 15;
        long numberToConvert;
        long convertedNumber;
        string binaryFormForModulo;
        long moduloNumber;
        long result;
        long messageInput;
        public Form1()
        {
            InitializeComponent();
        }
        private void CalculateModulo(string binaryString, long modulo)
        {
            char[] binaryCharArray = binaryString.ToCharArray();
            Array.Reverse(binaryCharArray);
            long temp = messageInput;
            long factor = 1;
            string[] currentPosition = {"\u2070","\u00B9", "\u00B2", "\u00B3", "\u2074", "\u2075", "\u2076", "\u2077", "\u2078", "\u2079", "\u00B9\u2070", "\u00B9\u00B9", "\u00B9\u00B2", "\u00B9\u00B3", "\u00B9\u2074", "\u00B9\u2075", "\u00B9\u2076", "\u00B9\u2077", "\u00B9\u2078", "\u00B9\u2079", ".....", ".....", ".....", ".....", ".....", ".....", ".....", ".....", ".....", ".....", ".....", ".....", ".....", ".....", ".....", ".....", ".....", ".....", ".....", ".....", ".....", ".....", ".....", ".....", ".....", ".....", ".....", ".....", ".....", ".....", ".....", ".....", ".....", ".....", ".....", ".....", ".....", ".....", ".....", "....." };
            string[] currentPosition2 = { "\u00B9", "\u00B2", "\u2074", "\u2078", "\u00B9\u2076", "\u00B3\u00B2", "\u2076\u2074", "\u00B9\u00B2\u2078", "\u00B2\u2075\u2076", "\u2075\u00B9\u00B2", "\u00B9\u2070\u00B2\u2074", "\u00B2\u2070\u2074\u2078", "\u2074\u2070\u2079\u2076", "\u2078\u00B9\u2079\u00B2", "\u00B9\u2076\u00B3\u2078\u2074", "\u00B3\u00B2\u2077\u2076\u2078", "...", "...", "...", "...", "...", "...", "...", "...", "...", "...", "...", "...", "...", "...", "...", "...", "...", "...", "...", "...", "...", "...", "...", "...", "...", "...", "...", "...", "...", "...", "...", "...", "...", "...", "...", "...", "...", "...", "...", "...", "...", "...", "...", "...", "...", "...", "...", "...", "...", "...", "...", "...", "...", "...", "...", "...", "...", "...", "...", "...", "...", "...", "...", "...", "..." };
            for (int x = 0; x < binaryCharArray.Length; x++)
            {
                temp %= modulo;
                
                if (binaryCharArray[x] == '1')
                {
                    factor = (factor * temp) % modulo;
                    outputBox2.AppendText("2" + currentPosition[x] + "*");
                    outputBox2.AppendText(Environment.NewLine);
                }
                else
                {
                    outputBox2.AppendText("2" + currentPosition[x]);
                    outputBox2.AppendText(Environment.NewLine);
                }
                outputBox1.AppendText(x.ToString());
                outputBox1.AppendText(Environment.NewLine);
                outputBox3.AppendText(messageInput + currentPosition2[x] + " mod " + modulo + " = " + temp);
                outputBox3.AppendText(Environment.NewLine);
                outputBox4.AppendText(factor.ToString());
                outputBox4.AppendText(Environment.NewLine);
                temp = (long)Math.Pow(temp, 2);
            }
            this.result = factor;
        }
        private void ConvertToBinary(long number)
        {
            long rest = number;
            long remainder;
            string bitString = "";
            while (rest > 0)
            {
                remainder = rest % 2;
                rest = rest / 2;
                bitString = remainder.ToString() + bitString;
            }
            outputNumberBox.Text = bitString;
            binaryInputBox.Text = bitString;
            long.TryParse(bitString, out convertedNumber);
        }
        private void ConvertToDecimal(long number)
        {
            int decimalSum = 0;
            string numberString = number.ToString();
            char[] numberArray = numberString.ToCharArray();
            Array.Reverse(numberArray);

            for (int x = 0; x < numberArray.Length; x++)
            {
                if (numberArray[x] == '1')
                {
                    decimalSum += (int)Math.Pow(2,x);
                }
            }
            outputNumberBox.Text = decimalSum.ToString();
            convertedNumber = decimalSum;
        }
        private void inputNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void decimalToBinary_CheckedChanged(object sender, EventArgs e)
        {
            dec2bin = true;
        }

        private void binaryToDecimal_CheckedChanged(object sender, EventArgs e)
        {
            dec2bin = false;
        }

        private void convertButton_Click(object sender, EventArgs e)
        {
            long inputNumber;
            if (long.TryParse(inputNumberBox.Text, out inputNumber))
            {
                this.numberToConvert = inputNumber;
                if (dec2bin == true)
                {
                    ConvertToBinary(numberToConvert);
                } else
                {
                    ConvertToDecimal(numberToConvert);
                }
            }
            else
            {
                MessageBox.Show("Input is not a number or too large (max 19 decimals)!");
                return;
            }
        }

        private void outputNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void calculateModuloButton_Click(object sender, EventArgs e)
        {
            long inputNumber2;
            long inputNumber3;
            if (long.TryParse(moduloInputBox.Text, out inputNumber2) && long.TryParse(messageBox.Text, out inputNumber3))
            {
                outputBox1.Text = "";
                outputBox2.Text = "";
                outputBox3.Text = "";
                outputBox4.Text = "";
                this.binaryFormForModulo = binaryInputBox.Text;
                this.moduloNumber = inputNumber2;
                this.messageInput = inputNumber3;

                CalculateModulo(binaryFormForModulo, moduloNumber);
            }
            else
            {
                MessageBox.Show("One input is not a number!");
                return;
            }
        }

        private void binaryInputBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void moduloInputBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void outputBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void message_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void outputBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
