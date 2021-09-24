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

namespace IOOPassignment
{
    public partial class Form5 : Form
    {
        OleDbConnection cnnOLEDB = new OleDbConnection();
        OleDbCommand cmdRead = new OleDbCommand();
        OleDbCommand cmdUpdate = new OleDbCommand();
        OleDbCommand cmdSearch = new OleDbCommand();
        string p, n, ea, ha, cn;
        
        public Form5(string id)
        {
            InitializeComponent();
            welcomelabel1.Text = id;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Form5_Load(object sender, EventArgs e)
        {
            cnnOLEDB.ConnectionString = "Provider = Microsoft.ACE.OLEDB.12.0;Data Source = C:\\Users\\user\\Desktop\\SemTwoSE\\IOOP\\IOOPassignment00\\tuitionDB.accdb;";
            cnnOLEDB.Open();
            cmdSearch.CommandText = "Select * from login where Login_Username = \'" + welcomelabel1.Text + "\';";
            cmdSearch.Connection = cnnOLEDB;
            OleDbDataReader reader = cmdSearch.ExecuteReader();
            if (reader.Read() == true)
            {
                if (reader[3].ToString() == "Student")
                {
                    cmdRead.CommandText = "Select studentinfo.*, login.Login_Password from studentinfo left join login on " +
                        "login.Login_ID=studentinfo.Login_ID where Login_Username = \'" + welcomelabel1.Text + "\';";
                    cmdRead.Connection = cnnOLEDB;
                    cmdRead.CommandType = CommandType.Text;
                    OleDbDataReader dr = cmdRead.ExecuteReader();
                    while (dr.Read())
                    {
                        passwordtextBox1.Text = (dr["Login_Password"]).ToString();
                        homeaddtextBox2.Text = (dr["Home_Address"]).ToString();
                        emailtextBox3.Text = (dr["Email_Address"]).ToString();
                        nametextBox5.Text = (dr["Student_Name"]).ToString();
                        contactnotextBox6.Text = (dr["Student_Contact"]).ToString();
                        balancetextBox4.Text = dr["Total_Balance"].ToString();
                    }
                    balancelabel7.Text = "Balance :";
                    homeaddlabel5.Text = "Home Address :";
                    dr.Close();

                }
                else if (reader[3].ToString() == "Tutor")
                {
                    cmdRead.CommandText = "Select tutormngment.*, login.Login_Password from tutormngment left join login on " +
                        "login.Login_ID=tutormngment.Login_ID where Login_Username = '" + welcomelabel1.Text + "';";
                    cmdRead.Connection = cnnOLEDB;
                    cmdRead.CommandType = CommandType.Text;
                    OleDbDataReader dr = cmdRead.ExecuteReader();
                    while (dr.Read())
                    {
                        passwordtextBox1.Text = (dr["Login_Password"]).ToString();
                        emailtextBox3.Text = (dr["Email_Address"]).ToString();
                        nametextBox5.Text = (dr["Tutor_Name"]).ToString();
                        contactnotextBox6.Text = (dr["Tutor_Contact"]).ToString();
                        balancetextBox4.Text = dr["Total_Charges"].ToString();
                        homeaddtextBox2.Text = dr["Student_Course"].ToString();
                    }
                    balancelabel7.Text = "Total Charges :";
                    homeaddlabel5.Text = "Subject :";
                    dr.Close();

                }
            }
            reader.Close();


        }  

               

        private void updatebutton2_Click(object sender, EventArgs e)
        {
            cmdSearch.CommandText = "Select * from login where Login_Username = \'" + welcomelabel1.Text + "\';";
            cmdSearch.Connection = cnnOLEDB;
            OleDbDataReader reader = cmdSearch.ExecuteReader();
            if (reader.Read() == true)
            {
                if (reader[3].ToString() == "Student")
                {
                    p = passwordtextBox1.Text;
                    n = nametextBox5.Text;
                    ea = emailtextBox3.Text;
                    ha = homeaddtextBox2.Text;
                    cn = contactnotextBox6.Text;
                    student s3 = new student(p, n, ea, cn, ha);

                    cmdRead.CommandText = "Select studentinfo.*, login.Login_Password from studentinfo left join login on " +
                        "login.Login_ID=studentinfo.Login_ID where Login_Username = \'" + welcomelabel1.Text + "\';";
                    cmdRead.Connection = cnnOLEDB;
                    cmdRead.CommandType = CommandType.Text;
                    OleDbDataReader dr = cmdRead.ExecuteReader();

                    if (s3.stups != "" && s3.stuname != "" && s3.stucnt != "" && s3.ha != "" && s3.ea != "")
                    {
                       cmdUpdate.CommandText = "UPDATE login as l INNER JOIN studentinfo as s ON l.Login_ID = s.Login_ID SET l.Login_Password = '" + s3.stups + "', " +
                            "s.Student_Contact = '" + s3.stucnt + "', s.Student_Name = '" + s3.stuname +"',s.Home_Address = '" + s3.ha + "',s.Email_Address = '" + s3.ea + "' where Login_Username = \'" + welcomelabel1.Text + "\';";
                        cmdUpdate.CommandType = CommandType.Text;
                        cmdUpdate.Connection = cnnOLEDB;
                        cmdUpdate.ExecuteNonQuery();
                        MessageBox.Show("Successfully Updated");
                    }
                    else
                    {
                        MessageBox.Show("Please fill in all the information!!!");
                    }
                    dr.Close();

                }
                else if (reader[3].ToString() == "Tutor")
                {
                    cmdRead.CommandText = "Select tutormngment.*, login.Login_Password from tutormngment left join login on " +
                        "login.Login_ID = tutormngment.Login_ID where Login_Username = \'" + welcomelabel1.Text + "\';";
                    cmdRead.Connection = cnnOLEDB;
                    cmdRead.CommandType = CommandType.Text;
                    OleDbDataReader dr = cmdRead.ExecuteReader();

                    if (passwordtextBox1.Text != "" && nametextBox5.Text != "" && contactnotextBox6.Text != "" &&  emailtextBox3.Text != "" && homeaddtextBox2.Text != "")
                    {
                        cmdUpdate.CommandText = "UPDATE login as l INNER JOIN tutormngment as t ON l.Login_ID = t.Login_ID SET l.Login_Password = '" + passwordtextBox1.Text + "', t.Tutor_Name = '" + nametextBox5.Text + "',t.Tutor_Contact = '" + contactnotextBox6.Text + "', t.Email_Address ='" + emailtextBox3.Text + "', t.Student_Course ='" + homeaddtextBox2.Text + "' where Login_Username = '" + welcomelabel1.Text + "';";
                        cmdUpdate.CommandType = CommandType.Text;
                        cmdUpdate.Connection = cnnOLEDB;
                        cmdUpdate.ExecuteNonQuery();
                        MessageBox.Show("Successfully Updated");
                    }
                    else
                    {
                        MessageBox.Show("Please fill in all the information.");
                    }
                    dr.Close();
                }

            }
            reader.Close();

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void balancelabel7_Click(object sender, EventArgs e)
        {

        }

        private void homeaddlabel5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MainForm f3 = new MainForm(welcomelabel1.Text);
            f3.Show();
            f3.ForeColor = this.ForeColor  ;
            f3.BackColor = this.BackColor  ;
            this.Hide();
        }

       
    }
}
