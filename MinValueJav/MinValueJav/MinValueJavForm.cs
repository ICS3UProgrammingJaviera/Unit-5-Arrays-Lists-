/*
 * Created by: Javiera Diaz
 * Created on: 05-12-18
 * Created for: ICS3U Programming
 * Daily Assignment – Day #39 - 2D Arrays
 * This program creates an array of 10 numbers, generating rnadom numbers between 1 to 500, then a
 * function is called to scan through all the values in the array, and dislays the smallest number in a label.
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

namespace MinValueJav
{
    public partial class frmMinValueJav : Form
    {
        public frmMinValueJav()
        {
            InitializeComponent();
        }
        //Function: GetMinValue
        //Input: int[] tmpArrayOfInts
        //Output: minValue in tmpArrayOfInts
        //Description: This function accepts an array of randmly generated intergers, scans the array to find the smallest number in the array, then returns it.
        private int GetMinValue(int[] tmpArrayOfInts)
        {
            //declare local variable
            int minVal = 501;

            //for each value in the array of number, scan the number, and if it's smaller the minimum vlaue becomes the value until it finds the smalllest.
            foreach(int value in tmpArrayOfInts)
            {
                if(value < minVal)
                {
                    minVal = value;
                }
            }
            //return int (the minVal)
            return minVal;
        }
        private void frmMinValueJav_Load(object sender, EventArgs e)
        {
            //hide this label
            this.lblMinValue.Hide();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            //Generate random number for the array
            Random randomNumGen = new Random();
            //set value of array to 10 numbers
            int[] valueOfArray = new int[10];
            //declare local variable
            int value;
            //clear items from the listbox
            lstRandomNumbers.Items.Clear();

            //declare and initialize index, set condtion of index needs to be < 10, increment index
            for(int index = 0; index < 10; index ++)
            {
                //assign random number generator to value, generate any number form 1 to 500
                value = randomNumGen.Next(1, 500);
                //assign index/ position in array to the value
                valueOfArray[index] = value;
                //add numbers to the listbox
                lstRandomNumbers.Items.Add(value);

                //refresh the form to show the new items in the listbox
                this.Refresh();

                //call the function and assign returned value to new variable "displayVal"
                int displayVal = GetMinValue(valueOfArray);
                //Change label text and assign the minimum value form funciton to the label
                lblMinValue.Text = "The minimum value is " + displayVal;
                //show the label
                this.lblMinValue.Show();
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mniRefresh_Click(object sender, EventArgs e)
        {
            //clear items form the listbox
            this.lstRandomNumbers.Items.Clear();
            //hide this label
            this.lblMinValue.Hide();
        }
    }
}
