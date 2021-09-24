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
    public partial class Form3 : Form
    {
        OleDbConnection cnnOLEDB = new OleDbConnection();
        OleDbCommand cmdInsert = new OleDbCommand();
        OleDbCommand cmdDisplay = new OleDbCommand();
        OleDbCommand cmdUpdate = new OleDbCommand();
        OleDbCommand cmdCount = new OleDbCommand();
        OleDbCommand cmdSearch = new OleDbCommand();
        OleDbCommand cmdRead = new OleDbCommand();
        int checkcounter;
        int a1, b1, c1, d1, e1, f1;
        int testing;
        List<string> courses = new List<string>();
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            cnnOLEDB.ConnectionString = "Provider = Microsoft.ACE.OLEDB.12.0;Data Source =C:\\Users\\user\\Desktop\\SemTwoSE\\IOOP\\IOOPassignment00\\tuitionDB.accdb;";
            cnnOLEDB.Open();

            /*display data into datagridview*/
            cmdDisplay.CommandText = "Select * from studentinfo;";
            cmdDisplay.Connection = cnnOLEDB;
            OleDbDataAdapter da = new OleDbDataAdapter(cmdDisplay);
            DataTable dt = new DataTable();
            da.Fill(dt);
            stuinfodataGridView.DataSource = dt;

            cmdRead.CommandText = "Select * from coursecounter where Counter_ID = 1;";
            cmdRead.CommandType = CommandType.Text;
            cmdRead.Connection = cnnOLEDB;
            OleDbDataReader rd = cmdRead.ExecuteReader();
            if (rd.Read() == true)
            {
                a1 = int.Parse(rd["melayucounter"].ToString());
                b1 = int.Parse(rd["chinesecounter"].ToString());
                c1 = int.Parse(rd["englishcounter"].ToString());
                d1 = int.Parse(rd["sciencecounter"].ToString());
                e1 = int.Parse(rd["mathcounter"].ToString());
                f1 = int.Parse(rd["accountingcounter"].ToString());
            }
            rd.Close();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {
            
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void confirmbutton_Click(object sender, EventArgs e)
        {
            string id, ps, nm, cnt, dt;
            id = idtextBox.Text;
            ps = passwordtextBox.Text;
            nm = nametextBox.Text;
            cnt = contacttextBox.Text;
            dt = dateTimePicker.Text;
            double bln = 0;
            student s1 = new student(id, ps);
            student s2 = new student(nm, cnt, dt, bln);

            cmdRead.CommandText = "Select * from coursecounter where Counter_ID = 1;";
            cmdRead.CommandType = CommandType.Text;
            cmdRead.Connection = cnnOLEDB;
            OleDbDataReader rd = cmdRead.ExecuteReader();
            if (rd.Read() == true)
            {
                a1 = int.Parse(rd["melayucounter"].ToString());
                b1 = int.Parse(rd["chinesecounter"].ToString());
                c1 = int.Parse(rd["englishcounter"].ToString());
                d1 = int.Parse(rd["sciencecounter"].ToString());
                e1 = int.Parse(rd["mathcounter"].ToString());
                f1 = int.Parse(rd["accountingcounter"].ToString());
            }
            rd.Close();

            /* to join all the courses as string*/
            string c = string.Join(",", courses);

            cmdSearch.CommandText = "Select count(Login_ID) From login;";
            cmdSearch.Connection = cnnOLEDB;
            cmdSearch.CommandType = CommandType.Text;
            cmdSearch.ExecuteNonQuery();
            int LoginNo = (int)cmdSearch.ExecuteScalar();

            /*set the row number for 'login' table & 'studentinfo' table*/
            int Test = 1;//this section helps to calculate the current row of datagridview
            for (int i = 0; i < stuinfodataGridView.Rows.Count - 1; i++)
            {
                if (s2.stuname != "")
                {
                    Test += 1;
                }
            }

            cmdSearch.CommandText = "Select Login_Username from login where Login_Username ='" + s1.stuid + "';";
            cmdSearch.Connection = cnnOLEDB;
            OleDbDataReader dr = cmdSearch.ExecuteReader();
            if (dr.Read() == false)
            {
                if (s1.stuid != "" && s1.stups != "" && s2.stuname != "" && s2.stucnt != "" && s2.studt != "")
                {
                    int min_length = 8;
                    int max_length = 15;
                    bool meetcriteria = min_length <= s2.stucnt.Length && max_length >= s2.stucnt.Length;
                    if (meetcriteria && Regex.Match(s2.stucnt, @"^[0-9]*$").Success && Regex.Match(s2.stuname, @"^[a-zA-Z]+$").Success)
                    {
                        LoginNo += 1;
                        cmdInsert.CommandText = "Insert into login (login_ID, login_Username, login_Password, User_Type) values (" + LoginNo + ",\'" + s1.stuid + "\', \'" + s1.stups + "\', 'Student')";
                        cmdInsert.CommandType = CommandType.Text;
                        cmdInsert.Connection = cnnOLEDB;
                        cmdInsert.ExecuteNonQuery();
                        cmdInsert.CommandText = "Insert into studentinfo (Student_ID, Student_Name, Student_Contact, Student_Date,Student_Course,Total_Balance,Login_ID) values (" + Test + ",\'" + s2.stuname + "\', \'" + s2.stucnt + "\', \'" + s2.studt + "\', \'" + c + "\'," + s2.stdbln + "," + LoginNo + ")";
                        cmdInsert.CommandType = CommandType.Text;
                        cmdInsert.Connection = cnnOLEDB;
                        cmdInsert.ExecuteNonQuery();
                        MessageBox.Show("Successfully Record.");
                        testing = 0;
                    }
                    else
                    {
                        if ((!meetcriteria || !Regex.Match(s2.stucnt, @"^[0-9]*$").Success) && Regex.Match(s2.stuname, @"^[a-zA-Z]+$").Success)
                        {
                            MessageBox.Show("Invalid Phone Number");
                            testing = 1;
                        }
                        else if ((meetcriteria && Regex.Match(s2.stucnt, @"^[0-9]*$").Success) && !Regex.Match(s2.stuname, @"^[a-zA-Z]+$").Success)
                        {
                            MessageBox.Show("Invalid Name");
                            testing = 2;
                        }
                        else
                        {
                            MessageBox.Show("Invalid Input (Phone Number and Name)");
                            testing = 3;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Please fill in the blank.", "Alert Message");
                    testing = 1;
                }



                if (checkBox1.Checked)
                {
                    if (testing == 0)
                    {
                        a1++;
                        cmdInsert.CommandText = "Insert into melayu (ID,Student_ID) values (" + Test + "," + Test + ");";
                        cmdInsert.CommandType = CommandType.Text;
                        cmdInsert.Connection = cnnOLEDB;
                        cmdInsert.ExecuteNonQuery();
                    }
                    if (a1 > 24)
                    {
                        MessageBox.Show("Course is fully occupied.");
                        checkBox1.Checked = false;
                    }

                }
                if (checkBox2.Checked)
                {
                    if (testing == 0)
                    {
                        b1++;
                        cmdInsert.CommandText = "Insert into chinese (ID,Student_ID) values (" + Test + "," + Test + ");";
                        cmdInsert.CommandType = CommandType.Text;
                        cmdInsert.Connection = cnnOLEDB;
                        cmdInsert.ExecuteNonQuery();
                        
                    }
                    if (b1 > 24)
                    {
                        MessageBox.Show("Course is fully occupied.");
                        checkBox1.Checked = false;
                    }
                }
                if (checkBox3.Checked)
                {
                    if (testing == 0)
                    {
                        c1++;
                        cmdInsert.CommandText = "Insert into english (ID,Student_ID) values (" + Test + "," + Test + ");";
                        cmdInsert.CommandType = CommandType.Text;
                        cmdInsert.Connection = cnnOLEDB;
                        cmdInsert.ExecuteNonQuery();
                    }
                    if (c1 > 24)
                    {
                        MessageBox.Show("Course is fully occupied.");
                        checkBox1.Checked = false;
                    }
                }
                if (checkBox4.Checked)
                {
                    if (testing == 0)
                    {
                        d1++;
                        cmdInsert.CommandText = "Insert into science (ID,Student_ID) values (" + Test + "," + Test + ");";
                        cmdInsert.CommandType = CommandType.Text;
                        cmdInsert.Connection = cnnOLEDB;
                        cmdInsert.ExecuteNonQuery();
                    }
                    if (d1 > 24)
                    {
                        MessageBox.Show("Course is fully occupied.");
                        checkBox1.Checked = false;
                    }
                }
                if (checkBox5.Checked)
                {
                    if (testing == 0)
                    {
                        e1++;
                        cmdInsert.CommandText = "Insert into mathematics (ID,Student_ID) values (" + Test + "," + Test + ");";
                        cmdInsert.CommandType = CommandType.Text;
                        cmdInsert.Connection = cnnOLEDB;
                        cmdInsert.ExecuteNonQuery();
                    }
                    if (e1 > 24)
                    {
                        MessageBox.Show("Course is fully occupied.");
                        checkBox1.Checked = false;
                    }
                }
                if (checkBox6.Checked)
                {
                    if (testing == 0)
                    {
                        f1++;
                        cmdInsert.CommandText = "Insert into accounting (ID,Student_ID) values (" + Test + "," + Test + ");";
                        cmdInsert.CommandType = CommandType.Text;
                        cmdInsert.Connection = cnnOLEDB;
                        cmdInsert.ExecuteNonQuery();
                    }
                    if (f1 > 24)
                    {
                        MessageBox.Show("Course is fully occupied.");
                        checkBox1.Checked = false;
                    }
                }

                if (testing == 1)
                {
                    contacttextBox.Clear();
                }
                else if (testing == 2)
                {
                    nametextBox.Clear();
                }
                else if (testing == 3)
                {
                    contacttextBox.Clear();
                    nametextBox.Clear();
                }

                if (testing == 1 || testing == 2)
                {
                    testing = 0;
                }

                cmdUpdate.CommandText = "UPDATE coursecounter SET melayucounter = '" + a1.ToString() + "', chinesecounter = '" + b1.ToString() + "', englishcounter = '" + c1.ToString() + "', sciencecounter = '" + d1.ToString() + "', mathcounter = '" + e1.ToString() + "', accountingcounter = '" + f1.ToString() + "' Where Counter_ID = 1;";
                cmdUpdate.CommandType = CommandType.Text;
                cmdUpdate.Connection = cnnOLEDB;
                cmdUpdate.ExecuteNonQuery();

                /*update data into datagridview*/
                cmdDisplay.CommandText = "Select * from studentinfo;";
                cmdDisplay.Connection = cnnOLEDB;
                OleDbDataAdapter da = new OleDbDataAdapter(cmdDisplay);
                DataTable dtbl = new DataTable();
                da.Fill(dtbl);
                stuinfodataGridView.DataSource = dtbl;


            }
            else
            {
                MessageBox.Show("Username has been used. Please try another.");
                idtextBox.Clear();
            }
            dr.Close();
        }
        
        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }

        private void previousbutton_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            this.Hide();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox box = (CheckBox)sender;
            int melayucounter = 0;
            if (box.Checked)
            {
                checkcounter++;
                melayucounter++;
                courses.Add("Melayu");
                
            }
            else
            {
                melayucounter--;
                checkcounter--;
                courses.Remove("Melayu");
            }
            if (checkcounter == 5)
            {
                box.Checked = false;
                MessageBox.Show("Please choose up to 4 courses only.", "Alert Message");
            }
            if (box.Checked)
            {
                if (a1 > 24)
                {
                    MessageBox.Show("Course is fully occupied.");
                    checkBox1.Checked = false;
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            this.Hide();
        }

        private void contacttextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void stuinfodataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox box = (CheckBox)sender;
            int sciencecounter = 0;
            if (box.Checked)
            {
                checkcounter++;
                sciencecounter++;
                courses.Add("Science");
            }
            else
            {
                checkcounter--;
                sciencecounter--;
                courses.Remove("Science");
            }
            if (checkcounter == 5)
            {
                box.Checked = false;
                MessageBox.Show("Please choose up to 4 courses only.", "Alert Message");
            }
            if (box.Checked)
            {
                if (d1 > 24)
                {
                    MessageBox.Show("Course is fully occupied.");
                    checkBox4.Checked = false;
                }
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox box = (CheckBox)sender;
            int chinesecounter = 0;
            if (box.Checked)
            {
                checkcounter++;
                chinesecounter++;
                courses.Add("Chinese");
            }
            else
            {
                checkcounter--;
                chinesecounter--;
                courses.Remove("Chinese");
            }
            if (checkcounter == 5)
            {
                box.Checked = false;
                MessageBox.Show("Please choose up to 4 courses only.", "Alert Message");
            }
            if (box.Checked)
            {
                if (b1 > 24)
                {
                    MessageBox.Show("Course is fully occupied.");
                    checkBox2.Checked = false;
                }
            }
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox box = (CheckBox)sender;
            int mathcounter = 0;
            if (box.Checked)
            {
                checkcounter++;
                mathcounter++;
                courses.Add("Mathematics");
            }
            else
            {
                checkcounter--;
                mathcounter--;
                courses.Remove("Mathematics");
            }
            if (checkcounter == 5)
            {
                box.Checked = false;
                MessageBox.Show("Please choose up to 4 courses only.", "Alert Message");
            }
            if (box.Checked)
            {
                if (e1 > 24)
                {
                    MessageBox.Show("Course is fully occupied.");
                    checkBox5.Checked = false;
                }
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox box = (CheckBox)sender;
            int englishcounter = 0;
            if (box.Checked)
            {
                checkcounter++;
                englishcounter++;
                courses.Add("English");
            }
            else
            {
                checkcounter--;
                englishcounter--;
                courses.Remove("English");
            }
            if (checkcounter == 5)
            {
                box.Checked = false;
                MessageBox.Show("Please choose up to 4 courses only.", "Alert Message");
            }
            if (box.Checked)
            {
                if (c1 > 24)
                {
                    MessageBox.Show("Course is fully occupied.");
                    checkBox3.Checked = false;
                }
            }
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox box = (CheckBox)sender;
            int accountingcounter = 0;
            if (box.Checked)
            {
                checkcounter++;
                accountingcounter++;
                courses.Add("Accounting");
                
            }
            else
            {
                checkcounter--;
                accountingcounter--;
                courses.Remove("Accounting");
            }
            if (checkcounter == 5)
            {
                box.Checked = false;
                MessageBox.Show("Please choose up to 4 courses only.", "Alert Message");
            }
            if (box.Checked)
            {
                if (f1 > 24)
                {
                    MessageBox.Show("Course is fully occupied.");
                    checkBox6.Checked = false;
                }
            }
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void clearbutton_Click(object sender, EventArgs e)
        {
            idtextBox.Clear();
            passwordtextBox.Clear();
            nametextBox.Clear();
            contacttextBox.Clear();
            dateTimePicker.Value = DateTime.Now;

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void stuinfodataGridView_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
