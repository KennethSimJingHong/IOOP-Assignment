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
    public partial class add_or_remove : Form
    {
        OleDbConnection cnnOLEDB = new OleDbConnection();
        OleDbCommand cmdSearch = new OleDbCommand();
        OleDbCommand cmdUpdate = new OleDbCommand();
        OleDbCommand cmdRead = new OleDbCommand();
        int checkcounter;
        List<string> courses = new List<string>();
        int a1, b1, c1, d1, e1, f1;

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            cmdSearch.CommandText = "Select Student_ID from studentinfo inner join login on login.Login_ID = studentinfo.Login_ID where Login_Username = \'" + textBox1.Text + "\';";
            cmdSearch.Connection = cnnOLEDB;
            OleDbDataReader dr = cmdSearch.ExecuteReader();
            if (dr.Read())
            {
                
                label3.Text = dr["Student_ID"].ToString();
                dr.Close();
                cmdSearch.CommandText = "Select * from melayu where Student_ID =" + label3.Text + ";";
                cmdSearch.Connection = cnnOLEDB;
                OleDbDataReader DR = cmdSearch.ExecuteReader();
                if (DR.Read())
                {
                    checkBox1.Checked = true;
                }
                DR.Close();

                cmdSearch.CommandText = "Select * from english where Student_ID =" + label3.Text + ";";
                cmdSearch.Connection = cnnOLEDB;
                OleDbDataReader Dr = cmdSearch.ExecuteReader();
                if (Dr.Read())
                {
                    checkBox2.Checked = true;
                }
                Dr.Close();

                cmdSearch.CommandText = "Select * from chinese where Student_ID =" + label3.Text + ";";
                cmdSearch.Connection = cnnOLEDB;
                OleDbDataReader dR = cmdSearch.ExecuteReader();
                if (dR.Read())
                {
                    checkBox3.Checked = true;
                }
                dR.Close();

                cmdSearch.CommandText = "Select * from mathematics where Student_ID =" + label3.Text + ";";
                cmdSearch.Connection = cnnOLEDB;
                OleDbDataReader rd = cmdSearch.ExecuteReader();
                if (rd.Read())
                {
                    checkBox5.Checked = true;
                }
                rd.Close();

                cmdSearch.CommandText = "Select * from science where Student_ID =" + label3.Text + ";";
                cmdSearch.Connection = cnnOLEDB;
                OleDbDataReader Rd = cmdSearch.ExecuteReader();
                if (Rd.Read())
                {
                    checkBox4.Checked = true;
                }
                Rd.Close();

                cmdSearch.CommandText = "Select * from accounting where Student_ID =" + label3.Text + ";";
                cmdSearch.Connection = cnnOLEDB;
                OleDbDataReader rD = cmdSearch.ExecuteReader();
                if (rD.Read())
                {
                    checkBox6.Checked = true;
                }
                rD.Close();
            }
            else
            {
                MessageBox.Show("No such username is found");
            }
            dr.Close();
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
                if (b1 > 25)
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
                if (e1 > 25)
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
                if (c1 > 25)
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
                if (f1 > 25)
                {
                    MessageBox.Show("Course is fully occupied.");
                    checkBox6.Checked = false;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to change to these courses?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
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

                cmdSearch.CommandText = "Select * from melayu where Student_ID =" + label3.Text + ";";
                cmdSearch.Connection = cnnOLEDB;
                OleDbDataReader DR = cmdSearch.ExecuteReader();
                if (DR.Read())
                {
                    a1--;
                    cmdUpdate.CommandText = "Delete from melayu where Student_ID=" + label3.Text + ";";
                    cmdUpdate.CommandType = CommandType.Text;
                    cmdUpdate.Connection = cnnOLEDB;
                    cmdUpdate.ExecuteNonQuery();
                }
                DR.Close();

                cmdSearch.CommandText = "Select * from english where Student_ID =" + label3.Text + ";";
                cmdSearch.Connection = cnnOLEDB;
                OleDbDataReader Dr = cmdSearch.ExecuteReader();
                if (Dr.Read())
                {
                    c1--;
                    cmdUpdate.CommandText = "Delete from english where Student_ID=" + label3.Text + ";";
                    cmdUpdate.CommandType = CommandType.Text;
                    cmdUpdate.Connection = cnnOLEDB;
                    cmdUpdate.ExecuteNonQuery();
                }
                Dr.Close();

                cmdSearch.CommandText = "Select * from chinese where Student_ID =" + label3.Text + ";";
                cmdSearch.Connection = cnnOLEDB;
                OleDbDataReader dR = cmdSearch.ExecuteReader();
                if (dR.Read())
                {
                    b1--;
                    cmdUpdate.CommandText = "Delete from chinese where Student_ID=" + label3.Text + ";";
                    cmdUpdate.CommandType = CommandType.Text;
                    cmdUpdate.Connection = cnnOLEDB;
                    cmdUpdate.ExecuteNonQuery();
                }
                dR.Close();

                cmdSearch.CommandText = "Select * from mathematics where Student_ID =" + label3.Text + ";";
                cmdSearch.Connection = cnnOLEDB;
                OleDbDataReader dd = cmdSearch.ExecuteReader();
                if (dd.Read())
                {
                    e1--;
                    cmdUpdate.CommandText = "Delete from mathematics where Student_ID=" + label3.Text + ";";
                    cmdUpdate.CommandType = CommandType.Text;
                    cmdUpdate.Connection = cnnOLEDB;
                    cmdUpdate.ExecuteNonQuery();
                }
                dd.Close();

                cmdSearch.CommandText = "Select * from science where Student_ID =" + label3.Text + ";";
                cmdSearch.Connection = cnnOLEDB;
                OleDbDataReader Rd = cmdSearch.ExecuteReader();
                if (Rd.Read())
                {
                    d1--;
                    cmdUpdate.CommandText = "Delete from science where Student_ID=" + label3.Text + ";";
                    cmdUpdate.CommandType = CommandType.Text;
                    cmdUpdate.Connection = cnnOLEDB;
                    cmdUpdate.ExecuteNonQuery();
                }
                Rd.Close();

                cmdSearch.CommandText = "Select * from accounting where Student_ID =" + label3.Text + ";";
                cmdSearch.Connection = cnnOLEDB;
                OleDbDataReader rD = cmdSearch.ExecuteReader();
                if (rD.Read())
                {
                    f1--;
                    cmdUpdate.CommandText = "Delete from accounting where Student_ID=" + label3.Text + ";";
                    cmdUpdate.CommandType = CommandType.Text;
                    cmdUpdate.Connection = cnnOLEDB;
                    cmdUpdate.ExecuteNonQuery();
                }
                rD.Close();

                string c = string.Join(",", courses);
                cmdUpdate.CommandText = "Update studentinfo Set Student_Course ='" + c + "' where Student_ID =" + label3.Text + ";";
                cmdUpdate.CommandType = CommandType.Text;
                cmdUpdate.Connection = cnnOLEDB;
                cmdUpdate.ExecuteNonQuery();

               

                if (checkBox1.Checked)
                {
                    cmdUpdate.CommandText = "Insert into melayu (ID,Student_ID) values (" + label3.Text + "," + label3.Text + ");";
                    cmdUpdate.CommandType = CommandType.Text;
                    cmdUpdate.Connection = cnnOLEDB;
                    cmdUpdate.ExecuteNonQuery();

                }
                if (checkBox2.Checked)
                {

                    b1++;
                    cmdUpdate.CommandText = "Insert into chinese (ID,Student_ID) values (" + label3.Text + "," + label3.Text + ");";
                    cmdUpdate.CommandType = CommandType.Text;
                    cmdUpdate.Connection = cnnOLEDB;
                    cmdUpdate.ExecuteNonQuery();


                }
                if (checkBox3.Checked)
                {

                    c1++;
                    cmdUpdate.CommandText = "Insert into chinese (ID,Student_ID) values (" + label3.Text + "," + label3.Text + ");";
                    cmdUpdate.CommandType = CommandType.Text;
                    cmdUpdate.Connection = cnnOLEDB;
                    cmdUpdate.ExecuteNonQuery();

                }
                if (checkBox4.Checked)
                {

                    d1++;
                    cmdUpdate.CommandText = "Insert into science (ID,Student_ID) values (" + label3.Text + "," + label3.Text + ");";
                    cmdUpdate.CommandType = CommandType.Text;
                    cmdUpdate.Connection = cnnOLEDB;
                    cmdUpdate.ExecuteNonQuery();

                }
                if (checkBox5.Checked)
                {

                    e1++;
                    cmdUpdate.CommandText = "Insert into mathematics (ID,Student_ID) values (" + label3.Text + "," + label3.Text + ");";
                    cmdUpdate.CommandType = CommandType.Text;
                    cmdUpdate.Connection = cnnOLEDB;
                    cmdUpdate.ExecuteNonQuery();

                }
                if (checkBox6.Checked)
                {

                    f1++;
                    cmdUpdate.CommandText = "Insert into accounting (ID,Student_ID) values (" + label3.Text + "," + label3.Text + ");";
                    cmdUpdate.CommandType = CommandType.Text;
                    cmdUpdate.Connection = cnnOLEDB;
                    cmdUpdate.ExecuteNonQuery();

                }
            }

            cmdUpdate.CommandText = "UPDATE coursecounter SET melayucounter = '" + a1.ToString() + "', chinesecounter = '" + b1.ToString() + "', englishcounter = '" + c1.ToString() + "', sciencecounter = '" + d1.ToString() + "', mathcounter = '" + e1.ToString() + "', accountingcounter = '" + f1.ToString() + "' Where Counter_ID = 1;";
            cmdUpdate.CommandType = CommandType.Text;
            cmdUpdate.Connection = cnnOLEDB;
            cmdUpdate.ExecuteNonQuery();
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
                if (d1 > 25)
                {
                    MessageBox.Show("Course is fully occupied.");
                    checkBox4.Checked = false;
                }
            }
        }

        public add_or_remove()
        {
            InitializeComponent();
        }

        private void add_or_remove_Load(object sender, EventArgs e)
        {
            cnnOLEDB.ConnectionString = "Provider = Microsoft.ACE.OLEDB.12.0;Data Source = C:\\Users\\user\\Desktop\\SemTwoSE\\IOOP\\IOOPassignment00\\tuitionDB.accdb;";
            cnnOLEDB.Open();

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


        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox box = (CheckBox)sender;
            int melayucounter = 0;
            if (box.Checked)
            {
                checkcounter++;
                melayucounter++;
                courses.Add("Melayu");
                if (checkcounter == 5)
                {
                    box.Checked = false;
                    MessageBox.Show("Please choose up to 4 courses only.", "Alert Message");
                }

            }
            else
            {
                melayucounter--;
                checkcounter--;
                courses.Remove("Melayu");
            }
            if (box.Checked)
            {
                if (a1 > 25)
                {
                    MessageBox.Show("Course is fully occupied.");
                    checkBox1.Checked = false;
                }
            }
        }
    }
}
