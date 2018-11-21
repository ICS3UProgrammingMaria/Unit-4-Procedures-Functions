/*
 * Created by: Maria
 * Created on: 21-11-2018
 * Created for: ICS3U Programming
 * Daily Assignment – Day #33 - Percentage Program
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

namespace SwitchMaria
{
    public partial class frmSwitch : Form
    {
        int percentage;
        public frmSwitch()
        {
            InitializeComponent();
        }

        private int ConvertToPercent(String level)
        {


            switch (level)
            {
                case "4++":
                    percentage = 98;
                    break;
                case "4+":
                    percentage = 95;
                    break;
                case "4":
                    percentage = 87;
                    break;
                case "4-":
                    percentage = 83;
                    break;
                case "3+":
                    percentage = 78;
                    break;
                case "3":
                    percentage = 75;
                    break;
                case "3-":
                    percentage = 72;
                    break;
                case "2+":
                    percentage = 68;
                    break;
                case "2":
                    percentage = 65;
                    break;
                case "2-":
                    percentage = 62;
                    break;
                case "1+":
                    percentage = 58;
                    break;
                case "1":
                    percentage = 55;
                    break;
                case "1-":
                    percentage = 52;
                    break;
                case "0+":
                    percentage = 45;
                    break;
                case "0":
                    percentage = 40;
                    break;
                case "0-":
                    percentage = 35;
                    break;
                case "0--":
                    percentage = 30;
                    break;
                case "0---":
                    percentage = 20;
                    break;
                case "0----":
                    percentage = 10;
                    break;
                default:
                    percentage = -1;
                    break;
            }
            return percentage;
        }


        private void btnEnter_Click_1(object sender, EventArgs e)
        {
            //declare local variables
            int userGrade;

            //get the users grade
            userGrade = Convert.ToInt16(this.txtuserGrade.Text);

            //display a message box stating the users percentage
            MessageBox.Show("is equivalent to" + percentage);
        }
    }
}
