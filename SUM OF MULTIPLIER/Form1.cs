using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SUM_OF_MULTIPLIER
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void InputTxtBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            int size = 12;

            int[] numbers = Enumerable.Range(1, size).ToArray();

            foreach (int result in numbers)
            {
                OutputLbl.Text += result + ", ";
            }
        }

        private void OutputLbl_Click(object sender, EventArgs e)
        {

        }
    }
}
