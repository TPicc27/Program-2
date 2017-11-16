// Tony Piccirilli
// CIS 199-01-4162
// Program 2
// March 6, 2016
// This program will take a student's first letter of their last name
// and what their credit hours are and it will give them
// the earliest day and time the can begin registering 
// for classes next year.
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timeButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Declare constants
                const double SOPHOMORE_HOURS = 30;
                const double JUNIOR_HOURS = 60;
                const double SENIOR_HOURS = 90;
                const string FRESHMAN_DAY1 = "Tuesday, April 5";
                const string FRESHMAN_DAY2 = "Wednesday, April 6";
                const string SOPHOMORE_DAY1 = "Friday, April 1";
                const string SOPHOMORE_DAY2 = "Monday, April 4";
                const string JUNIOR_DAY = "Thursday, March 31";
                const string SENIOR_DAY = "Wednesday, March 30";
                const string TIME1 = "8:30 a.m.";
                const string TIME2 = "10 a.m.";
                const string TIME3 = "11:30 a.m.";
                const string TIME4 = "2:00 p.m.";
                const string TIME5 = "4:00 p.m";

                // Declare local variables
                string lastName;
                double creditHours;
                
                // Find the student's last name.
                lastName = lastNameAnswer.Text;
                lastName = lastName.ToUpper();
               
                // Validate the credit hours entered.
                if (double.TryParse(creditHourAnswer.Text, out creditHours))
                {
                    if (creditHours < 0)
                    {
                        MessageBox.Show("The number you entered is invaild");
                    }
                }
                    
                    // Determine what registration time is for student's with at least 90 hours. 
                if (creditHours >= SENIOR_HOURS)
                {
                    dateOutput.Text = SENIOR_DAY;

                    if (lastName == "A" || lastName == "B" || lastName == "C" || lastName == "D")
                    {
                        timeOutput.Text = TIME5;
                    }

                    if (lastName == "E" || lastName == "F" || lastName == "G" || lastName == "H" || lastName == "I")
                    {
                        timeOutput.Text = TIME1;

                    }
                    if (lastName == "J" || lastName == "K" || lastName == "L" || lastName == "M" || lastName == "N" || lastName == "O")
                    {

                        timeOutput.Text = TIME2;

                    }
                    if (lastName == "P" || lastName == "Q" || lastName == "R" || lastName == "S")
                    {

                        timeOutput.Text = TIME3;

                    }
                    if (lastName == "T" || lastName == "U" || lastName == "V" || lastName == "W" || lastName == "X" || lastName == "Y" || lastName == "Z")
                    {

                        timeOutput.Text = TIME4;

                    }
                }

                    // Determine what registration time is for students with less than 90 hours but at least 60 hours.
                if (creditHours >= JUNIOR_HOURS && creditHours < SENIOR_HOURS) 
                {
                    dateOutput.Text = JUNIOR_DAY;
                    
                    if (lastName == "A" || lastName == "B" || lastName == "C" || lastName == "D")
                    {

                        timeOutput.Text = TIME5;

                    }
                    if (lastName == "E" || lastName == "F" || lastName == "G" || lastName == "H" || lastName == "I")
                    {

                        timeOutput.Text = TIME1;

                    }
                    if (lastName == "J" || lastName == "K" || lastName == "L" || lastName == "M" || lastName == "N" || lastName == "O")
                    {
                        
                        timeOutput.Text = TIME2;

                    }
                    if (lastName == "P" || lastName == "Q" || lastName == "R" || lastName == "S")
                    {
                        
                        timeOutput.Text = TIME3;

                    }
                    if (lastName == "T" || lastName == "U" || lastName == "V" || lastName == "W" || lastName == "X" || lastName == "Y" || lastName == "Z")
                    {

                        timeOutput.Text = TIME4;

                    }
                }
                    // Display the Registration time for student's with less than 60 hours but at least 30 hours.

                if ((creditHours >= SOPHOMORE_HOURS && creditHours < JUNIOR_HOURS))
                {

                    if (lastName == "A" || lastName == "B")
                    {

                        dateOutput.Text = SOPHOMORE_DAY2;
                        timeOutput.Text = TIME4;

                    }
                    if (lastName == "C" || lastName == "D")
                    {

                        dateOutput.Text = SOPHOMORE_DAY2;
                        timeOutput.Text = TIME5;

                    }

                    if (lastName == "E" || lastName == "F")
                    {

                        dateOutput.Text = SOPHOMORE_DAY1;
                        timeOutput.Text = TIME1;

                    }
                    if (lastName == "G" || lastName == "H" || lastName == "I")
                    {

                        dateOutput.Text = SOPHOMORE_DAY1;
                        timeOutput.Text = TIME2;

                    }
                    if (lastName == "J" || lastName == "K" || lastName == "L")
                    {

                        dateOutput.Text = SOPHOMORE_DAY1;
                        timeOutput.Text = TIME3;

                    }
                    if (lastName == "M" || lastName == "N" || lastName == "O")
                    {

                        dateOutput.Text = SOPHOMORE_DAY1;
                        timeOutput.Text = TIME4;

                    }
                    if (lastName == "P" || lastName == "Q")
                    {

                        dateOutput.Text = SOPHOMORE_DAY1;
                        timeOutput.Text = TIME5;

                    }
                    if (lastName == "R" || lastName == "S")
                    {

                        dateOutput.Text = SOPHOMORE_DAY2;
                        timeOutput.Text = TIME1;

                    }
                    if (lastName == "T" || lastName == "U" || lastName == "V")
                    {

                        dateOutput.Text = SOPHOMORE_DAY2;
                        timeOutput.Text = TIME2;

                    }
                    if (lastName == "W" || lastName == "X" || lastName == "Y" || lastName == "Z")
                    {

                        dateOutput.Text = SOPHOMORE_DAY2;
                        timeOutput.Text = TIME3;

                    }
                }

                    // Display the Registration time for students with less than 30 hours.

                if (creditHours < SOPHOMORE_HOURS)
                {
                    if (lastName == "A" || lastName == "B")
                    {

                        dateOutput.Text = FRESHMAN_DAY2;
                        timeOutput.Text = TIME4;

                    }
                    if (lastName == "C" || lastName == "D")
                    {

                        dateOutput.Text = FRESHMAN_DAY2;
                        timeOutput.Text = TIME5;

                    }
                    if (lastName == "E" || lastName == "F")
                    {

                        dateOutput.Text = FRESHMAN_DAY1;
                        timeOutput.Text = TIME1;

                    }
                    if (lastName == "G" || lastName == "H" || lastName == "I")
                    {

                        dateOutput.Text = FRESHMAN_DAY1;
                        timeOutput.Text = TIME2;

                    }
                    if (lastName == "J" || lastName == "K" || lastName == "L")
                    {

                        dateOutput.Text = FRESHMAN_DAY1;
                        timeOutput.Text = TIME3;

                    }
                    if (lastName == "M" || lastName == "N" || lastName == "O")
                    {

                        dateOutput.Text = FRESHMAN_DAY1;
                        timeOutput.Text = TIME4;

                    }
                    if (lastName == "P" || lastName == "Q")
                    {

                        dateOutput.Text = FRESHMAN_DAY1;
                        timeOutput.Text = TIME5;

                    }
                    if (lastName == "R" || lastName == "S")
                    {

                        dateOutput.Text = FRESHMAN_DAY2;
                        timeOutput.Text = TIME1;

                    }
                    if (lastName == "T" || lastName == "U" || lastName == "V")
                    {

                        dateOutput.Text = FRESHMAN_DAY2;
                        timeOutput.Text = TIME2;

                    }
                    if (lastName == "W" || lastName == "X" || lastName == "Y" || lastName == "Z")
                    {

                        dateOutput.Text = FRESHMAN_DAY2;
                        timeOutput.Text = TIME3;

                    }
                }
                    
                    

                    
            }
            catch
            {
            }


                    
            
      }
        private void clearButton_Click(object sender, EventArgs e)
        {
            // Clear the form for another student
            lastNameAnswer.Text = "";
            creditHourAnswer.Text = "";
            dateOutput.Text = "";
            timeOutput.Text = "";
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form
            this.Close();
        }

    }
}
