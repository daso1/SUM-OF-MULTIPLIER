using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace SUM_OF_MULTIPLIER
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                InputValidator.CheckNullTxtBox(InputTxtBox.Text);
                int input = Int32.Parse(InputTxtBox.Text);
                InputValidator.CheckRange(input);

                OutputLbl1.Text = ($"Method1 - Sum of % 3 or 5 by {input} equals to: {FindSumOfMultiple1(input)}");
                OutputLbl2.Text = ($"Method2 - Sum of % 3 or 5 by {input} equals to: {FindSumOfMultiple2(input)}");
            }
            catch (FormatException ex)
            {
                MessageBox.Show($"{ex.Message}", "Input error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                InputTxtBox.SelectAll();
                InputTxtBox.Focus();
            }
            catch (Exception)
            {
                MessageBox.Show($"Critical error. Try again.", "Critical error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                InputTxtBox.Focus();
            }
        }
        public string FindSumOfMultiple1(int input)
        {
            int[] numbers = Enumerable.Range(1, input).ToArray();
            uint sum = 0;
            foreach (int value in numbers.Where((number) => number % 3 == 0 || number % 5 == 0))
            {
                sum += (uint)value;
            }
            return sum.ToString("N0");
        }
        public string FindSumOfMultiple2(int input)
        {
            int[] numbers = Enumerable.Range(1, input).ToArray();

            IEnumerable<int> multipleCollection = from i in numbers
                                                  where i % 3 == 0 || i % 5 == 0
                                                  select i;
            uint sum = 0;
            foreach (int number in multipleCollection)
            {
                sum += (uint)number;
            }
            return sum.ToString("N0");
        }
        private void InputTxtBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
