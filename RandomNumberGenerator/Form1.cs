using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RandomNumberGenerator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // eventhandler
        private void buttonGenerateNumber_Click(object sender, EventArgs e)
        {
            int size = 5;
            int index;

            int[] randomNumbers = new int[size];

            Random myRandom = new Random();

            // generate random numbers 0 to 99 and assigns it to randomNumbers[index]
            for (index = 0; index < randomNumbers.Length; index++)
            {
                randomNumbers[index] = myRandom.Next(100);
            }

            // display array elements
            label1.Text = randomNumbers[0].ToString();
            label2.Text = randomNumbers[1].ToString();
            label3.Text = randomNumbers[2].ToString();
            label4.Text = randomNumbers[3].ToString();
            label5.Text = randomNumbers[4].ToString();

        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
