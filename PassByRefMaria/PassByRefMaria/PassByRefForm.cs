/*
 * Created by: Maria
 * Created on: Day-Month-Year
 * Created for: ICS3U Programming
 * Daily Assignment – Day #31 - Rounding Program
 * This program...
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

namespace PassByRefMaria
{
    public partial class frmPassByRef : Form
    {
        public frmPassByRef()
        {
            InitializeComponent();
        }

        //Function: Round
        //Input: int deciNumber
        //Output: void
        //Description: This function takes the decimal number passed by value and displays
        //a message box with the rounded decimal 
        //Declare variables

        public void Round(ref number, int number)
        {
            //declare local variables 
        }


        private void btnRound_Click(object sender, EventArgs e)
        {
            //Declare variables
            int deciNumber;

            //convert the input decimal from a string to an int
            deciNumber = Convert.ToInt32(this.txtnumber.Text);

            //call the function to round the decimal
            //this.Round(deciNumber);
        }
    }
}
//double.parse