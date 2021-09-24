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
    public partial class MainForm : Form
    {
        OleDbConnection cnnOLEDB = new OleDbConnection();
        OleDbCommand cmdSearch = new OleDbCommand();
        public MainForm(string id)
        {
            InitializeComponent();
            label3.Text = id;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (panel1.Width > 36)
            {
                while (panel1.Width > 36)
                {
                    panel1.Width--;
                    profilebutton.Width--;
                    button2.Width--;
                    button3.Width--;
                    settingbutton.Width--;
                }
            }
            else
            {
                while (panel1.Width <212)
                {
                    panel1.Width++;
                    profilebutton.Width++;
                    button2.Width++;
                    button3.Width++;
                    settingbutton.Width++;
                }
                
            }
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            cnnOLEDB.ConnectionString = "Provider = Microsoft.ACE.OLEDB.12.0;Data Source = C:\\Users\\user\\Desktop\\SemTwoSE\\IOOP\\IOOPassignment00\\tuitionDB.accdb;";
            cnnOLEDB.Open();
            label2.Text = label3.Text;
            pictureBox4.Show();
            cmdSearch.CommandText = "Select * from login where Login_Username = \'" + label3.Text + "\';";
            cmdSearch.Connection = cnnOLEDB;
            OleDbDataReader reader = cmdSearch.ExecuteReader();
            if (reader.Read() == true)
            {
                if (reader[3].ToString() == "Tutor")
                {
                    button3.Visible = true;
                    pictureBox10.Visible = true;
                }
                if (reader[3].ToString() == "Student")
                {
                    button3.Visible = false;
                    pictureBox10.Visible = false;
                }
            }
            reader.Close();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                pictureBox4.Show();
                pictureBox8.Hide();
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                pictureBox4.Hide();
                pictureBox8.Show();
            }
        }

        private void profilebutton_Click(object sender, EventArgs e)
        {
            Form5 f5 = new Form5(label3.Text);
            f5.Show();
            f5.ForeColor = this.ForeColor;
            f5.BackColor = this.BackColor;
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cmdSearch.CommandText = "Select * from login where Login_Username = \'" + label3.Text + "\';";
            cmdSearch.Connection = cnnOLEDB;
            OleDbDataReader reader = cmdSearch.ExecuteReader();
            if (reader.Read() == true)
            {
                if (reader[3].ToString() == "Student")
                {
                    Schedule f6 = new Schedule(label3.Text);
                    f6.Show();
                    f6.ForeColor = this.ForeColor ;
                    f6.BackColor=this.BackColor ;
                    this.Hide();
                }
                else
                {
                    Form7 f7 = new Form7(label3.Text);
                    f7.Show();
                    f7.ForeColor=this.ForeColor ;
                    f7.BackColor = this.BackColor ;
                    this.Hide();
                }
            }
            reader.Close();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Form5 f5 = new Form5(label3.Text);
            f5.Show();
            f5.ForeColor = this.ForeColor  ;
            f5.BackColor = this.BackColor ;
            this.Hide();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            cmdSearch.CommandText = "Select * from login where Login_Username = \'" + label3.Text + "\';";
            cmdSearch.Connection = cnnOLEDB;
            OleDbDataReader reader = cmdSearch.ExecuteReader();
            if (reader.Read() == true)
            {
                if (reader[3].ToString() == "Student")
                {
                    Schedule f6 = new Schedule(label3.Text);
                    f6.Show();
                    f6.ForeColor = this.ForeColor ;
                    f6.BackColor = this.BackColor ;
                    this.Hide();
                }
                else
                {
                    Form7 f7 = new Form7(label3.Text);
                    f7.Show();
                    f7.ForeColor = this.ForeColor ;
                    f7.BackColor = this.BackColor ;
                    this.Hide();
                }
            }
            reader.Close();
        }

        private void TDbutton3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form8 f8 = new Form8(label3.Text);
            f8.Show();
            f8.ForeColor = this.ForeColor ;
            f8.BackColor = this.BackColor ;
            this.Hide();
        }

        private void settingbutton_Click(object sender, EventArgs e)
        {
            Setting f11 = new Setting(label3.Text);
            f11.Show();
            f11.ForeColor = this.ForeColor ;
            f11.BackColor = this.BackColor  ;
            this.Hide();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            Form8 f8 = new Form8(label3.Text);
            f8.Show();
            f8.ForeColor = this.ForeColor;
            f8.BackColor = this.BackColor ;
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Setting f11 = new Setting(label3.Text);
            f11.Show();
            f11.ForeColor = this.ForeColor  ;
            f11.BackColor = this.BackColor;
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to log out?", "Log Out", MessageBoxButtons.YesNo,
MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Form1 f1 = new Form1();
                f1.Show();
                this.Hide();
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

       
    }
}
