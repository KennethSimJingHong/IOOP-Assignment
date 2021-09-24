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
    public partial class Form1 : Form
    {
        OleDbConnection cnnOLEDB = new OleDbConnection();
        OleDbCommand cmdSearch = new OleDbCommand();
        public Form1()
        {
            InitializeComponent();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            cnnOLEDB.ConnectionString = "Provider = Microsoft.ACE.OLEDB.12.0;Data Source = C:\\Users\\user\\Desktop\\SemTwoSE\\IOOP\\IOOPassignment00\\tuitionDB.accdb;";
            cnnOLEDB.Open();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string id, p;
            id = idtextBox.Text;
            p = passwordtextBox.Text;
            student s1 = new student(id, p);
            if (id != "" && p != "")
            {
                cmdSearch.CommandText = "Select * from login where Login_Username = '" + idtextBox.Text + "' and Login_Password = '" + passwordtextBox.Text + "';";
                cmdSearch.Connection = cnnOLEDB;
                OleDbDataReader reader = cmdSearch.ExecuteReader();
                if (reader.Read() == true)
                {
                        if (reader[3].ToString() == "Staff")
                        {
                            Form2 f2 = new Form2();
                            f2.Show();
                            this.Hide();
                        }
                        else if (reader[3].ToString() == "Student")
                        {
                            MainForm f3 = new MainForm(idtextBox.Text);
                            f3.Show();
                            this.Hide();
                        }
                        else if (reader[3].ToString() == "Tutor")
                        {
                            MainForm f3 = new MainForm(idtextBox.Text);
                            f3.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Invalid Input. Please try again.");
                        }
                }
                    else
                    {
                        MessageBox.Show("Invalid Input. Please try again.");
                    }
                reader.Close();
            }
            else
            {
                MessageBox.Show("Please fill in the blank.");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
