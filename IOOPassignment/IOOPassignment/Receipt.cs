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
    public partial class Receipt : Form
    {
        OleDbConnection cnnOLEDB = new OleDbConnection();
        OleDbCommand cmdRead = new OleDbCommand();
        public Receipt(string name, string balance, string price, string totalbalance)
        {
            InitializeComponent();
            nametextBox.Text = name;
            BLtextBox.Text= balance;
            pricetextBox.Text = price;
            balancetextBox.Text = totalbalance;
        }

        private void Receipt_Load(object sender, EventArgs e)
        {
            string sum;
            cnnOLEDB.ConnectionString = "Provider = Microsoft.ACE.OLEDB.12.0;Data Source = C:\\Users\\user\\Desktop\\SemTwoSE\\IOOP\\IOOPassignment00\\tuitionDB.accdb;";
            cnnOLEDB.Open();
            cmdRead.CommandText = "Select * from studentinfo where Student_Name = \'" + nametextBox.Text + "\';";
            cmdRead.Connection = cnnOLEDB;
            cmdRead.CommandType = CommandType.Text;
            OleDbDataReader dr = cmdRead.ExecuteReader();
            while (dr.Read())
            {
                idtextBox.Text = dr[1].ToString();
            }
            sum = BLtextBox.Text.ToString() + pricetextBox.Text.ToString();
            sum = balancetextBox.Text;
        }

        private void mainmenubutton1_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            this.Hide();
        }
    }
}
