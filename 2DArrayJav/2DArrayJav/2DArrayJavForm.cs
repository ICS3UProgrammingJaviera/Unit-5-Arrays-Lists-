/*
 * Created by: Javiera Diaz
 * Created on: 12-12-18
 * Created for: ICS3U Programming
 * Daily Assignment – Day #39 - 2D Arrays
 * This program creates a 2D array of numbers in a textbox using the length and width desired by the user to make the array. It uses random numbers.
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

namespace _2DArrayJav
{
    public partial class frm2DArrayJav : Form
    {
        public frm2DArrayJav()
        {
            InitializeComponent();
        }
        //Function: GetArrayAverage
        //Input: int anArray2D
        //Output: average of all the numbers in the array
        //Description: This function accepts an array as a paramater and uses it to find the average of all the numbers in the array
        private int GetArrayAverage( int[,] tmp2DArrayOfIntergers)
        {
            //declare and intialize variables.
            int average = 0;
            int sum = 0;
            int index = 0;
            int length = 0;
            int width = 0;

            //calculate sum and average of the array
            for (index = 0; index < tmp2DArrayOfIntergers.Length; index ++)
            {
                sum = sum + tmp2DArrayOfIntergers[length, width];
                average = sum / tmp2DArrayOfIntergers.Length;
            }
            return average;

            lblAverageOfArray.Text = "The average of this array is: " + average;
        }
        private void btnCreate_Click(object sender, EventArgs e)
        {
            //declare local variables
            int length, width, aRandomNumber;
            Random randomNumberGenerator = new Random();
            string aPieceOfText = null;

            //get user's length and width
            width = Convert.ToInt16(this.nudWidth.Value);
            length = Convert.ToInt16(this.nudLength.Value);

            //declare a new array with user's length and width
            int[,] a2DArray = new int[width, length];

            //loop through values in user's width
            for (int widthIndex = 0; widthIndex < width; widthIndex++)
            {
                //loop through user's values for length
                for (int lengthIndex = 0; lengthIndex < length; lengthIndex++)
                {
                    //get random number between 0 and 9
                    aRandomNumber = randomNumberGenerator.Next(0, 9 + 1);
                    //place random number in array with user's length and width
                    a2DArray[widthIndex, lengthIndex] = aRandomNumber;
                    //add random number to string of array numbers
                    aPieceOfText = aPieceOfText + "" + aRandomNumber;
                }
                //add line break at end of line to show a row
                aPieceOfText = aPieceOfText + "\r" + "\n";
            }
            //insert string into the textbox
            this.txtArray.Text = aPieceOfText;
            //show this label
            this.lblAverageOfArray.Show();
        }

        private void frm2DArrayJav_Load(object sender, EventArgs e)
        {
            //hide this label
            this.lblAverageOfArray.Hide();
        }
    }
}
