using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IOOPassignment
{
    public partial class Setting : Form
    {
        public Setting(string id)
        {
            InitializeComponent();
            label1.Text = id;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MainForm f3 = new MainForm(label1.Text);
            f3.Show();
            f3.ForeColor = this.ForeColor;
            f3.BackColor = this.BackColor;
            this.Hide();
        }

        private void Setting_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.Turquoise;
            this.ForeColor = Color.Black;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                this.BackColor = Color.Turquoise;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                this.BackColor = Color.SpringGreen;
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                this.BackColor = Color.Red;
            }
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton6.Checked)
            {
                this.ForeColor = Color.Black;
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked)
            {
                this.ForeColor = Color.DarkBlue;
            }
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton5.Checked)
            {
                this.ForeColor = Color.LimeGreen;
            }
        }
    }
}
