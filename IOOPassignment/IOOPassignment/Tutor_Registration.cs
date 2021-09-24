using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Text.RegularExpressions;

namespace IOOPassignment
{
    public partial class TutorRegistration : Form
    {
        OleDbConnection cnnOLEDB = new OleDbConnection();
        OleDbCommand cmdInsert = new OleDbCommand();
        OleDbCommand cmdSearch = new OleDbCommand();
        OleDbCommand cmdUpdate = new OleDbCommand();
        string id, p, ea, cn, n, d, s;
        double c;
        
        public TutorRegistration()
        {
            InitializeComponent();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
 
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        { 
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void confirmbutton_Click_1(object sender, EventArgs e)
        {
            id = idtextBox.Text;
            p = passwordtextBox.Text;
            n = nametextBox.Text;
            cn = contacttextBox.Text;
            ea = eatextBox1.Text;
            d = dateTimePicker1.Text;
            chargestextBox1.Text = "0";
            c = double.Parse(chargestextBox1.Text);
            Tutor t1 = new Tutor(id, p, ea, cn, n, d, c);

            cmdSearch.CommandText = "Select count(Login_ID) From login;";
            cmdSearch.Connection = cnnOLEDB;
            cmdSearch.CommandType = CommandType.Text;
            cmdSearch.ExecuteNonQuery();
            int LoginNo = (int)cmdSearch.ExecuteScalar();

            cmdSearch.CommandText = "Select count(Tutor_ID) From tutormngment;";
            cmdSearch.Connection = cnnOLEDB;
            cmdSearch.CommandType = CommandType.Text;
            cmdSearch.ExecuteNonQuery();
            int test = (int)cmdSearch.ExecuteScalar();


            cmdSearch.CommandText = "Select Student_Course from tutormngment where Student_Course ='" + s + "';";
            cmdSearch.Connection = cnnOLEDB;
            OleDbDataReader dr = cmdSearch.ExecuteReader();
            if (dr.Read() == false)
            {
                /* check if user fill in all blank*/
                if (t1.tutid != "" && t1.tutps != "" && t1.tutname != "" && t1.tutcnt != "" && t1.tutea != "" && t1.tutdate != "" && t1.tutcharges != 0)
                {
                    int min_length = 8;
                    int max_length = 15;
                    bool meetcriteria = min_length <= t1.tutcnt.Length && max_length >= t1.tutcnt.Length;
                    if (meetcriteria && Regex.Match(t1.tutcnt, @"^[0-9]*$").Success && Regex.Match(t1.tutname, @"^[a-zA-Z]+$").Success)
                    {
                        LoginNo += 1;
                        test += 1;
                        cmdInsert.CommandText = "Insert into login (Login_ID, login_Username, login_Password, User_Type) values ("+LoginNo+",'" +t1.tutid + "\',\'" + t1.tutps + "\', 'Tutor')";
                        cmdInsert.CommandType = CommandType.Text;
                        cmdInsert.Connection = cnnOLEDB;
                        cmdInsert.ExecuteNonQuery();

                        cmdInsert.CommandText = "Insert into tutormngment (Tutor_ID,Login_ID, Tutor_Name, Tutor_Contact, Student_Course, Email_Address, Total_Charges, Class_Schedule) values (" + test + "," +LoginNo +",'" + t1.tutname + "','" + t1.tutcnt + "','" + s + "','" + t1.tutea + "','" + chargestextBox1.Text + "','" + dateTimePicker1.Text + "');";
                        cmdInsert.CommandType = CommandType.Text;
                        cmdInsert.Connection = cnnOLEDB;
                        cmdInsert.ExecuteNonQuery();






                        MessageBox.Show("Successfully Record.");
                        dr.Close();
                    }
                    else
                    {
                        if ((!meetcriteria || !Regex.Match(t1.tutcnt, @"^[0-9]*$").Success) && Regex.Match(t1.tutname, @"^[a-zA-Z]+$").Success)
                        {
                            MessageBox.Show("Invalid Phone Number");

                        }
                        else if ((meetcriteria && Regex.Match(t1.tutcnt, @"^[0-9]*$").Success) && !Regex.Match(t1.tutname, @"^[a-zA-Z]+$").Success)
                        {
                            MessageBox.Show("Invalid Name");

                        }
                        else
                        {
                            MessageBox.Show("Invalid Input (Phone Number and Name)");

                        }
                        dr.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Please fill in the blank.", "Alert Message");
                }
                dr.Close();
            }

            else
            {
                MessageBox.Show("Sorry, we already have tutor for that particular subject.");
            }
            dr.Close();

        }


       private void radioButton4_CheckedChanged_1(object sender, EventArgs e)
       {
            s = "Mathematics";
       }

       private void groupBox1_Enter(object sender, EventArgs e)
       {

       }

        private void radioButton3_CheckedChanged_1(object sender, EventArgs e)
        {
            s = "Chinese";
        }

        private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
        {
            s = "Melayu";
        }

        private void radioButton2_CheckedChanged_1(object sender, EventArgs e)
        {
            s = "Science";
        }

        private void radioButton5_CheckedChanged_1(object sender, EventArgs e)
        {
            s = "English";
        }

        private void radioButton6_CheckedChanged_1(object sender, EventArgs e)
        {
            s = "Accounting";
        }

        private void chargestextBox1_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void chargestextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if(!char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
       {
            Form2 f2 = new Form2();
            f2.Show();
            this.Hide();
        }

       private void radioButton6_CheckedChanged(object sender, EventArgs e)
       {
       }

       private void radioButton1_CheckedChanged(object sender, EventArgs e)
       {
       }

       private void Tutor_Registration_Load(object sender, EventArgs e)
       {
           cnnOLEDB.ConnectionString = "Provider = Microsoft.ACE.OLEDB.12.0;Data Source = C:\\Users\\user\\Desktop\\SemTwoSE\\IOOP\\IOOPassignment00\\tuitionDB.accdb;";
            cnnOLEDB.Open();
}

private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void confirmbutton_Click(object sender, EventArgs e)
        {
        }
    }
}
