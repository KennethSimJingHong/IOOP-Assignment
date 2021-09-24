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
    public partial class Schedule : Form
    {
        OleDbConnection cnnOLEDB = new OleDbConnection();
        OleDbCommand cmdRead = new OleDbCommand();
        public Schedule(string id)
        {
            InitializeComponent();
            label1.Text = id;

        }

        private void Schedule_Load(object sender, EventArgs e)
        {
            cnnOLEDB.ConnectionString = "Provider = Microsoft.ACE.OLEDB.12.0;Data Source = C:\\Users\\user\\Desktop\\SemTwoSE\\IOOP\\IOOPassignment00\\tuitionDB.accdb;";
            cnnOLEDB.Open();
            cmdRead.CommandText = "Select Tutor_Name, Class_Schedule, Student_Course, Total_Charges from tutormngment;";
            cmdRead.Connection = cnnOLEDB;
            OleDbDataAdapter da = new OleDbDataAdapter(cmdRead);
            DataTable dt = new DataTable();
            da.Fill(dt);
            scheduledataGridView1.DataSource = dt;
        }

        private void scheduledataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MainForm f3 = new MainForm(label1.Text);
            f3.Show();
            f3.ForeColor = this.ForeColor;
            f3.BackColor = this.BackColor;
            this.Hide();
        }
    }
}
