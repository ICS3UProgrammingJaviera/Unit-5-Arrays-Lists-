/*
 * Created by: Javiera Diaz
 * Created on: 03-12-18
 * Created for: ICS3U Programming
 * Daily Assignment – Day #37 - Find Max Value
 * This program that generates 10 random numbers from 1 - 500 in an array after the user clicks the start button. Then the largest random number is displayed in a label on the form.
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

namespace FindMaxValJav
{
    public partial class frmFindMaxValJav : Form
    {
        public frmFindMaxValJav()
        {
            InitializeComponent();
        }
        //Function: GetMaxValue
        //Input: int[] tmpArrayOfIntergers
        //Output: max value in he array
        //Description: This function accepts an array of intergers, scane array and returns greatest value in the array
        private int GetMaxValue(int[] tmpArrayOfIntegers)
        {
            int maxVal = 0;
            foreach(int value in tmpArrayOfIntegers)
            {
                if (value > maxVal)
                {
                    maxVal = value;
                }
            }
            return maxVal;
        }
        private void frmFindMaxValJav_Load(object sender, EventArgs e)
        {
            this.lblMaxValue.Hide();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            Random randomNumGen = new Random();
            int[] valueOfArray = new int[10];
            int value;
            lstRandomNumbers.Items.Clear();

            for (int index = 0; index < 10; index ++)
            {
                value = randomNumGen.Next(1, 500);
                valueOfArray[index] = value;
                lstRandomNumbers.Items.Add(value);

                this.Refresh();
            }

            int displayVal = GetMaxValue(valueOfArray);
            this.lblMaxValue.Text = "The maximum value is " + displayVal;

            this.lblMaxValue.Show();
        }

        private void mniExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mniRefresh_Click(object sender, EventArgs e)
        {
            //clear the itwems form the listbox
            this.lstRandomNumbers.Items.Clear();
            //hide this label
            this.lblMaxValue.Hide();
        }
    }
}
