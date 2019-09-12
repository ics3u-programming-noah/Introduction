/*
 * Created by: Noah Colbourne
 * Created on: 10-September-2019
 * Created for: ICS3U Programming
 * Daily Assignment – Day #6 - Hello World International
 * This program displays the greeting in different languages 
 * depending on which radio button is clicked.
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

namespace HellointNoah
{
    public partial class frmHelloint : System.Windows.Forms.Form
    {
        public frmHelloint()
        {
            InitializeComponent();
        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void LblGreeting_Click(object sender, EventArgs e)
        {

        }

        private void RadSwedish_CheckedChanged(object sender, EventArgs e)
        {
            //Change the greeting to Swedish
            this.lblGreeting.Text = "Hej världen!";
        }

        private void RadRussian_CheckedChanged(object sender, EventArgs e)
        {
            //Change the greeting to Russian 
            this.lblGreeting.Text = "Привет, мир!";
        }

        private void RadEnglish_CheckedChanged(object sender, EventArgs e)
        {
            //Change the greeting to English
            this.lblGreeting.Text = "Hello, World!";
        }

        private void RadJapanese_CheckedChanged(object sender, EventArgs e)
        {
            //Change greeting to Japanese
            this.lblGreeting.Text = "こんにちは世界！";
        }
    }
}
