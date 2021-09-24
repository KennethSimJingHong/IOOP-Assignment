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
    public partial class Form8 : Form
    {
        OleDbConnection cnnOLEDB = new OleDbConnection();
        OleDbCommand cmdRead = new OleDbCommand();

        public Form8(string id)
        {
            InitializeComponent();
            label1.Text = id;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form8_Load(object sender, EventArgs e)
        {
            cnnOLEDB.ConnectionString = "Provider = Microsoft.ACE.OLEDB.12.0;Data Source = C:\\Users\\user\\Desktop\\SemTwoSE\\IOOP\\IOOPassignment00\\tuitionDB.accdb;";
            cnnOLEDB.Open();
            cmdRead.CommandText = "Select tutormngment.Student_Course from tutormngment inner join login on login.Login_ID = tutormngment.Login_ID where Login_Username =\'" + label1.Text + "\' ;";
            cmdRead.Connection = cnnOLEDB;
            cmdRead.CommandType = CommandType.Text;
            OleDbDataReader dr = cmdRead.ExecuteReader();
            while (dr.Read())
            {
                label2.Text = (dr["Student_Course"]).ToString();
            }
            dr.Close();
            cmdRead.CommandText = "Select studentinfo.* from studentinfo inner join " + label2.Text + " on studentinfo.Student_ID =" + label2.Text + ".Student_ID ;";
            cmdRead.Connection = cnnOLEDB;
            OleDbDataAdapter da = new OleDbDataAdapter(cmdRead);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MainForm f3 = new MainForm(label1.Text);
            f3.Show();
            f3.ForeColor = this.ForeColor  ;
            f3.BackColor = this.BackColor ;
            this.Hide();
        }
    }
}
