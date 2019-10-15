/*
 * Created by: Noah Colbourne
 * Created on: 10-Sep-2019
 * Created for: ICS3U Programming
 * Daily Assignment – Day #6 - Day #7 - Perimeter, Area, Volume 
 * This program calculates the perimeter of a rectangle, 
 * the area of a circle and the volume of  a sphere. 
 * It displays the answers in labels when the respective
 * button is clicked.
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

namespace PerAreaVolNoahC
{
    public partial class PerAreaVolForm : Form
    {
        public PerAreaVolForm()
        {
            InitializeComponent();
        }

        private void LblAPerimeter_Click(object sender, EventArgs e)
        {

        }

        private void PerAreaVolForm_Load(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            // This will solve the equation of "What is the volume of a sphere with a radius of 4cm"
            lblAVolume.Text = Convert.ToString((double)4/(double)3 * Math.PI * Math.Pow(4, 3)) + " cm³ ";
        }

        private void BtnQArea_Click(object sender, EventArgs e)
        {
            // This will solve the equation of "What is the area of a sphere with a radius of 7 cm"
            lblAArea.Text = Convert.ToString(Math.PI * Math.Pow(7, 2)) + " cm² ";
        }

        private void BtnQPerimeter_Click(object sender, EventArgs e)
        {
            // This will solve the equation of " What is the perimeter of a rectangle with a legth of 5cm and width of 8cm"
            lblAPerimeter.Text = Convert.ToString(8 + 8 + 5 + 5) + " cm ";
        }
    }
}
