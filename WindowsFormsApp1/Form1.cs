using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            lstPrimeNumbers.Items.Add("Prime Numbers From 0 To 1000.");
            for (int i = 0; i < 100000; i++)
            {
                if (CheckNumberPrimeNumber(i) == true) lstPrimeNumbers.Items.Add(i.ToString());
            }
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            //Exit from this form.  
            this.Dispose();
        }

        public static bool CheckNumberPrimeNumber(int num)
        {
            bool CheckPrimeNumber = true;
            int factor = num / 2;
            int i = 0;
            for (i = 2; i <= factor; i++)
            {
                if ((num % i) == 0) CheckPrimeNumber = false;
            }
            return CheckPrimeNumber;
        }

        private void btnClearListBox_Click(object sender, EventArgs e)
        {
            lstPrimeNumbers.Items.Clear();
        }
    }
}
