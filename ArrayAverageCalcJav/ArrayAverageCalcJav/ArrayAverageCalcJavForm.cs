/*
 * Created by: Javiera Diaz
 * Created on: 29/11/18
 * Created for: ICS3U Programming
 * Daily Assignment – Day #36 - Introduction to Arrays
 * This program generates 10 numbers from an array when the user clicks the start button. Then when they click the "Calculate Average" button, the average is calclated from the array and displayed in a label.
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArrayAverageCalcJav
{
    public partial class frmArrayAverageCalcJav : Form
    {
        //declare global variables and constants
        const int MAX_ARRAY_SIZE = 10;
        int[] arrayOfNumbers = new int[MAX_ARRAY_SIZE];

        public frmArrayAverageCalcJav()
        {
            InitializeComponent();
        }

        private void frmArrayAverageCalcJav_Load(object sender, EventArgs e)
        {
            this.lblAverage.Hide();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            //declare local variables
            int randomNumber;
            int index;
            Random randomNumberGenerator = new Random();

            //clear the listbox
            this.lstNumbers.Items.Clear();

            for(index = 0; index<MAX_ARRAY_SIZE; index++)
            {
                //generate new random number between 1 and max array size
                randomNumber = randomNumberGenerator.Next(1, MAX_ARRAY_SIZE + 1);

                //assign random number to the cell position index in the array
                arrayOfNumbers[index] = randomNumber;

                //add number to listbox
                lstNumbers.Items.Add(randomNumber);

                //refresh form to display new items in the listbpx
                this.Refresh();
            }
        }

        private void btnCalcAverage_Click(object sender, EventArgs e)
        {
            //declare local variables and intialize values
            double average = 0;
            double sum = 0;
            int index;

            //calculate sum of all values in the array
            for (index = 0; index < arrayOfNumbers.Length; index++)
            {
                sum = sum + arrayOfNumbers[index];
            }

            //calculate the average of values in the array
            average = sum / arrayOfNumbers.Length;

            //shows average label
            this.lblAverage.Show();

            //display average
            this.lblAverage.Text = "The average is: " + average;
        }

        private void mniExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {

            //clear listbox
            this.lstNumbers.Items.Clear();

            //hide label
            lblAverage.Hide();
        }
    }
}
