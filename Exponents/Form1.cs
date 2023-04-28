using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

/**************************************
 * Name:Eric Villa
 * Date:4/27/2023
 * Description: A program using user-created method
 *              for the math function Square and Cube
 * Assistance:
 *************************************/

namespace Exponents
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void xGoButton_Click(object sender, EventArgs e)
        {
            // STORAGE
            int userInput = Convert.ToInt32(xInputTextBox.Text);

            // INPUT

            // PROCESS
            /* calculate the square of the number and add it to the output - 
             * do this with a method call that allows you to pass the number
             * and then receive the answer */
            int squareInput = Square(userInput);

            /* calculate the cube of the number and add it to the output - 
             * do this by creating a methd as in the squaring example above */
            int cubeInput = Cube(userInput);
            // OUTPUT
            // set the output to visible
            xOutputLabel.Text = $"The Square of {userInput} is \n{squareInput} and the Cubed is {cubeInput}.";
            xOutputLabel.Visible = true;
            // turn the Go button off
            xGoButton.Enabled = false;
        }

        public int Square(int num)
        {
            // we will create this code in class
            return  num * num;
            
        }

        public int Cube(int num)
        {
            // we will create this code in class
            return  num * num * num;
        }

        private void xResetButton_Click(object sender, EventArgs e)
        {
            // the input and output text should be emptied
            // turn the output to invisible
            // turn the Go button back on
            xInputTextBox.Text = "";
            xOutputLabel.Text = "";
            xOutputLabel.Visible = false;
            xGoButton.Enabled = true;
        }

    }
}
