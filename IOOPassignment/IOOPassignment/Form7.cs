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
    public partial class Form7 : Form
    {
        OleDbConnection cnnOLEDB = new OleDbConnection();
        OleDbCommand cmdUpdate = new OleDbCommand();
        OleDbCommand cmdRead = new OleDbCommand();

        public Form7(string id)
        {
            InitializeComponent();
            label1.Text = id;
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            cnnOLEDB.ConnectionString = "Provider = Microsoft.ACE.OLEDB.12.0;Data Source = C:\\Users\\user\\Desktop\\SemTwoSE\\IOOP\\IOOPassignment00\\tuitionDB.accdb;";
            cnnOLEDB.Open();
            /*display data into datagridview*/
            cmdRead.CommandText = "Select tutormngment.* from tutormngment inner join login on tutormngment.Login_ID = login.Login_ID where Login_Username ='" +label1.Text + "';";
            cmdRead.Connection = cnnOLEDB;
            OleDbDataAdapter da = new OleDbDataAdapter(cmdRead);
            DataTable dt = new DataTable();
            da.Fill(dt);
            tutormngmentdataGridView.DataSource = dt;

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
           
        }

        private void addbutton_Click_1(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MainForm f3 = new MainForm(label1.Text);
            f3.Show();
            f3.ForeColor = this.ForeColor ;
            f3.BackColor = this.BackColor;
            this.Hide();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {

        }

        private void addbutton_Click(object sender, EventArgs e)
        {
            double c;
            string d;
            c = double.Parse(chargestextBox.Text);
            d = dateTimePicker.Text;

            /*insert data into 'tutormngment' table*/
            if (dateTimePicker.Text != "" && chargestextBox.Text != "")
            {
                cmdUpdate.CommandText = "Update tutormngment Inner Join login on tutormngment.Login_ID = login.Login_ID Set tutormngment.Total_Charges = " + c + " , tutormngment.Class_Schedule= \'" + d + "\' where login.Login_Username = '" + label1.Text + "';";
                cmdUpdate.CommandType = CommandType.Text;
                cmdUpdate.Connection = cnnOLEDB;
                cmdUpdate.ExecuteNonQuery();
                MessageBox.Show("Successfully Update.");

                /*display data into datagridview*/
                cmdRead.CommandText = "Select tutormngment.* from tutormngment inner join login on tutormngment.Login_ID = login.Login_ID where Login_Username ='" + label1.Text + "';";
                cmdRead.Connection = cnnOLEDB;
                OleDbDataAdapter da = new OleDbDataAdapter(cmdRead);
                DataTable dt = new DataTable();
                da.Fill(dt);
                tutormngmentdataGridView.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Please fill in the blank.", "Alert Message");
            }
        }

        private void chargestextBox_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void chargestextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }
    }
}

