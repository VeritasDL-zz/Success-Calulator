using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace simpleflipssuccessrate
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }  
        int getcount = 0;             // how many times you get it
        int notcount = 0;            // how many times you dont
        double rate = 0.0;          // get count / total
        int total = 0;             // get count + not count
        double Rate = 0.0;        // used to round rate to 2 dec places
        int getstreak = 0;       // current streak
        int higheststreak = 0 ; // highest streak
        private void button1_Click(object sender, EventArgs e)
        {
            getcount++;        // adds one to get count
            getstreak++;       // adds one to get streak
            button1.Text = "Got It " + "(" + getcount + ")";        // sets button1.text to getcount
            total = getcount + notcount; //sets total value
            rate = (double)getcount / (double)total * 100.0;       // getcount / total * 100
            Rate = Math.Round(rate, 2);  //rounds rate to 2 dec place
            label1.Text = "Success Rate: " + Rate + "%";  // sets label 1
            label2.Text = "Get Streak: " + getstreak;    // sets label 2
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            notcount++;  // adds one to not count
            button2.Text = "Nah " + "(" + notcount + ")";  // sets button2.text to notcount
            total = getcount + notcount;    //sets total value
            rate = (float)getcount / (float)total * 100;    // getcount / total * 100
            Rate = Math.Round(rate, 2); //rounds rate to 2 dec place
            label1.Text = "Success Rate: " + Rate + "%"; // sets label 1
            label2.Text = "Get Streak: " + getstreak; // sets label 2
            label3.Text = "Previous Streak: " + getstreak; //sets label 3
            if (higheststreak < getstreak) // checks if getstreak is higher then higheststreak 
            {
                higheststreak = getstreak; //sets highest to getstreak
                label4.Text = "Highest Streak: " + getstreak; //sets label 4 
            }

            getstreak = 0; //resets getsreak
            label2.Text = "Get Streak: " + getstreak; //resets label 2
            
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            getcount = 0;
            notcount = 0;
            rate = 0.0;
            total = 0;
            Rate = 0.0;
            getstreak = 0;
            rate = (float)getcount / (float)total * 100;
            button1.Text = "Got It " + "(" + getcount + ")";
            button2.Text = "Nah " + "(" + notcount + ")";
            label1.Text = "Success Rate: " + Rate + "%";
            label2.Text = "Get Streak: " + getstreak;
            label3.Text = "Previous Streak: " + getstreak;


        }

        private void GetStripMenuItem2_Click(object sender, EventArgs e)
        {
            getcount++;
            getstreak++;
            button1.Text = "Got It " + "(" + getcount + ")";
            total = getcount + notcount;
            rate = (double)getcount / (double)total * 100.0;
            Rate = Math.Round(rate, 2);
            label1.Text = "Success Rate: " + Rate + "%";
            label2.Text = "Get Streak: " + getstreak;

        }

        private void NahStripMenuItem3_Click(object sender, EventArgs e)
        {
            notcount++;
            button2.Text = "Nah " + "(" + notcount + ")";
            total = getcount + notcount;
            rate = (float)getcount / (float)total * 100;
            Rate = Math.Round(rate, 2);
            label1.Text = "Success Rate: " + Rate + "%";
            label2.Text = "Get Streak: " + getstreak;
            label3.Text = "Previous Streak: " + getstreak;
            if (higheststreak < getstreak)
            {
                higheststreak = getstreak;
                label4.Text = "Highest Streak: " + getstreak;
            }

            getstreak = 0;
            label2.Text = "Get Streak: " + getstreak;

        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                contextMenuStrip1.Show((Form)sender, e.Location);

            }
        }

        private void getToolStripMenuItem_Click(object sender, EventArgs e)
        {
            getcount++;
            getstreak++;
            button1.Text = "Got It " + "(" + getcount + ")";
            total = getcount + notcount;
            rate = (double)getcount / (double)total * 100.0;
            Rate = Math.Round(rate, 2);
            label1.Text = "Success Rate: " + Rate + "%";
            label2.Text = "Get Streak: " + getstreak;

        }

        private void nahToolStripMenuItem_Click(object sender, EventArgs e)
        {
            notcount++;
            button2.Text = "Nah " + "(" + notcount + ")";
            total = getcount + notcount;
            rate = (float)getcount / (float)total * 100;
            Rate = Math.Round(rate, 2);
            label1.Text = "Success Rate: " + Rate + "%";
            label2.Text = "Get Streak: " + getstreak;
            label3.Text = "Previous Streak: " + getstreak;
            if (higheststreak < getstreak)
            {
                higheststreak = getstreak;
                label4.Text = "Highest Streak: " + getstreak;
            }

            getstreak = 0;
            label2.Text = "Get Streak: " + getstreak;
        }

        private void resetToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            getcount = 0;
            notcount = 0;
            rate = 0.0;
            total = 0;
            Rate = 0.0;
            getstreak = 0;
            rate = (float)getcount / (float)total * 100;
            button1.Text = "Got It " + "(" + getcount + ")";
            button2.Text = "Nah " + "(" + notcount + ")";
            label1.Text = "Success Rate: " + Rate + "%";
            label2.Text = "Get Streak: " + getstreak;
            label3.Text = "Previous Streak: " + getstreak;

        }

        private void creditsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("VeritasDL - Creator & Coder \n\nSimpleFlips - For Being A God \n\nDan - Helped Me Not Be C# Scrub", "Credits", System.Windows.Forms.MessageBoxButtons.OK);
        }
    }
}
