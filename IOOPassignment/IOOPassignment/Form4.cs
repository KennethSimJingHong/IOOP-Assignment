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
    public partial class Form4 : Form
    {
        OleDbConnection cnnOLEDB = new OleDbConnection();
        OleDbCommand cmdSearch = new OleDbCommand();
        OleDbCommand cmdUpdate = new OleDbCommand();
        double ttlbln, blnrld, blnddt;
        public Form4()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (nametextBox.Text != "")
            {
                cmdSearch.CommandText = "Select * from studentinfo where Student_Name = '" + nametextBox.Text + "';";
                cmdSearch.CommandType = CommandType.Text;
                cmdSearch.Connection = cnnOLEDB;
                OleDbDataReader dr = cmdSearch.ExecuteReader();
                if (dr.Read() == true)
                {
                    balancelabel.Text = dr[7].ToString(); 
                }
                else
                {
                    MessageBox.Show("Record not Found");
                }
                dr.Close();
            }
            else
            {
                MessageBox.Show("Please fill in the blank.");
            }
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (nametextBox.Text != "")
            {
                if (reloadtextBox.Text == "")
                {
                    MessageBox.Show("Please fill in the blank.");
                }
                else
                {
                    blnrld = double.Parse(reloadtextBox.Text);
                    ttlbln = double.Parse(balancelabel.Text);
                    double sum;
                    balance b1 = new balance(ttlbln);

                    sum = b1.BalanceReload(ttlbln, blnrld);
                    MessageBox.Show("Total Balance is " + sum.ToString() + ".");
                    cmdUpdate.CommandText = "Update studentinfo Set Total_Balance = " + sum + " where Student_Name = '" + nametextBox.Text + "';";
                    cmdUpdate.CommandType = CommandType.Text;
                    cmdUpdate.Connection = cnnOLEDB;
                    cmdUpdate.ExecuteNonQuery();
                    balancelabel.Text = sum.ToString();
                }
            }
            else
            {
                MessageBox.Show("Please input a name.");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            this.Hide();
        }

        private void reloadtextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            this.Hide();
        }

        private void reloadtextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void deducttextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            cnnOLEDB.ConnectionString = "Provider = Microsoft.ACE.OLEDB.12.0;Data Source = C:\\Users\\user\\Desktop\\SemTwoSE\\IOOP\\IOOPassignment00\\tuitionDB.accdb;";
            cnnOLEDB.Open();
        }

        private void confirmbutton2_Click(object sender, EventArgs e)
        {
            if(deducttextBox.Text == "")
            {
                MessageBox.Show("Please fill in the blank.");
            }
            else
            {
                blnddt = double.Parse(deducttextBox.Text);
                ttlbln = double.Parse(balancelabel.Text);
                double sum;
                balance b2 = new balance(ttlbln);

                sum = b2.BalanceDeduct(ttlbln, blnddt);
                MessageBox.Show("Total Balance is " + sum.ToString() + ".");
                cmdUpdate.CommandText = "Update studentinfo Set Total_Balance = " + sum + " where Student_Name = '" + nametextBox.Text + "';";
                cmdUpdate.CommandType = CommandType.Text;
                cmdUpdate.Connection = cnnOLEDB;
                cmdUpdate.ExecuteNonQuery();
                balancelabel.Text = sum.ToString();
                Receipt R1 = new Receipt(nametextBox.Text, balancelabel.Text,deducttextBox.Text, ttlbln.ToString());
                R1.Show();
                this.Hide();
            }
        }
    }
}
