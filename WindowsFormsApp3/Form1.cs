using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Storeing the values to variables

            DateTime datTime = Convert.ToDateTime(txtdateTime1.Text);
            CAP1.setstdate(datTime);// passing the value of datetime variable to another variable dtTime of the setdate method in class1.
            string courseno = txtcoursenumber.Text;
            // the following code tests the first textbox No. of Course Taken
            // it checks if the value entered is integer if not it shows an error.
            try
            {
                int NoCourse = int.Parse(txtenrolled1.Text, System.Globalization.NumberStyles.None); // parses the string in CrsTaken text box.
                CAP1.setscours(NoCourse); // passing the value of NoOfCourse variable to another variable course of the setsnocours method in class1.
            }

            catch (Exception)
            {
                MessageBox.Show("Enter the Number of Courses Taken. Enter the values in form of Numbers only.");
                txtenrolled1.Clear();// Clears the TextBox CrsTaken

            }

            // the following code tests the Second textbox Student Name
            // it checks if the value entered ends with or starts with a space if it does it shows an error.
            string SName = txtstdname1.Text; // storeing of value to variable
            if (SName.EndsWith(" ") || SName.StartsWith(" ")) // the code checks if the string starts with or ends with a Blank
            {
                MessageBox.Show("Student Name Cannot Start or End with a Space");
                txtstdname1.Clear();

            }
            else
            { }
            //the following code tests the Second textbox Student Name
            // it checks if the value entered consist of a space if it doesn't it shows an error.
            if (SName.Contains(" ")) // the code that checks if there is space between first name and last name.
            {
                CAP1.setsn(SName); // passing the value of StudentName variable to another variable sname of the sets1 method in class1.
            }
            else
            {
                MessageBox.Show("There should be a space between First name and Last name");
                txtstdname1.Clear();
            }

            if (txtradioButton2.Checked == true)
            {
                string t = "in class";
                CAP1.settype(t);

            }

            else
            {
                txtradioButton1.Checked = true;
                string type = "Hybrid";
                CAP1.settype(type);
            }

        }

        private void txtget_Click(object sender, EventArgs e)
        {
            // the following code 
            string ct = CAP2.getsn();
            txtstdname2.Text = ct;

            int cno = CAP2.getcours();
            txtenrolled2.Text = Convert.ToString(cno);

            DateTime dttime = CAP2.getstartdate();
            txtstartdate.Text = Convert.ToString(dttime);

            string type1 = CAP2.gettype();
            txtclasstype.Text = type1;
        }

        private void txtexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtcoursename2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

