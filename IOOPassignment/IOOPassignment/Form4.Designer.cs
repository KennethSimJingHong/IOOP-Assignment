namespace IOOPassignment
{
    partial class Form4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.balancelabel = new System.Windows.Forms.Label();
            this.searchbutton = new System.Windows.Forms.Button();
            this.nametextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.confirmbutton1 = new System.Windows.Forms.Button();
            this.reloadtextBox = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.deducttextBox = new System.Windows.Forms.TextBox();
            this.confirmbutton2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(283, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student Balance";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.balancelabel);
            this.groupBox1.Controls.Add(this.searchbutton);
            this.groupBox1.Controls.Add(this.nametextBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(83, 114);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(332, 249);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Student Detail :";
            // 
            // balancelabel
            // 
            this.balancelabel.AutoSize = true;
            this.balancelabel.Location = new System.Drawing.Point(141, 135);
            this.balancelabel.Name = "balancelabel";
            this.balancelabel.Size = new System.Drawing.Size(0, 17);
            this.balancelabel.TabIndex = 3;
            // 
            // searchbutton
            // 
            this.searchbutton.Location = new System.Drawing.Point(125, 182);
            this.searchbutton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.searchbutton.Name = "searchbutton";
            this.searchbutton.Size = new System.Drawing.Size(75, 23);
            this.searchbutton.TabIndex = 4;
            this.searchbutton.Text = "Search";
            this.searchbutton.UseVisualStyleBackColor = true;
            this.searchbutton.Click += new System.EventHandler(this.button1_Click);
            // 
            // nametextBox
            // 
            this.nametextBox.Location = new System.Drawing.Point(141, 76);
            this.nametextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nametextBox.Name = "nametextBox";
            this.nametextBox.Size = new System.Drawing.Size(169, 22);
            this.nametextBox.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Total Balance :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Student Name :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.confirmbutton1);
            this.groupBox2.Controls.Add(this.reloadtextBox);
            this.groupBox2.Location = new System.Drawing.Point(457, 114);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(235, 121);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Reload";
            // 
            // confirmbutton1
            // 
            this.confirmbutton1.Location = new System.Drawing.Point(83, 76);
            this.confirmbutton1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.confirmbutton1.Name = "confirmbutton1";
            this.confirmbutton1.Size = new System.Drawing.Size(75, 23);
            this.confirmbutton1.TabIndex = 1;
            this.confirmbutton1.Text = "Confirm";
            this.confirmbutton1.UseVisualStyleBackColor = true;
            this.confirmbutton1.Click += new System.EventHandler(this.button2_Click);
            // 
            // reloadtextBox
            // 
            this.reloadtextBox.Location = new System.Drawing.Point(9, 33);
            this.reloadtextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.reloadtextBox.Name = "reloadtextBox";
            this.reloadtextBox.Size = new System.Drawing.Size(217, 22);
            this.reloadtextBox.TabIndex = 0;
            this.reloadtextBox.TextChanged += new System.EventHandler(this.reloadtextBox_TextChanged);
            this.reloadtextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.reloadtextBox_KeyPress);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.deducttextBox);
            this.groupBox3.Controls.Add(this.confirmbutton2);
            this.groupBox3.Location = new System.Drawing.Point(457, 242);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Size = new System.Drawing.Size(235, 121);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Deduct";
            // 
            // deducttextBox
            // 
            this.deducttextBox.Location = new System.Drawing.Point(9, 34);
            this.deducttextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.deducttextBox.Name = "deducttextBox";
            this.deducttextBox.Size = new System.Drawing.Size(217, 22);
            this.deducttextBox.TabIndex = 0;
            this.deducttextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.deducttextBox_KeyPress);
            // 
            // confirmbutton2
            // 
            this.confirmbutton2.Location = new System.Drawing.Point(83, 76);
            this.confirmbutton2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.confirmbutton2.Name = "confirmbutton2";
            this.confirmbutton2.Size = new System.Drawing.Size(75, 23);
            this.confirmbutton2.TabIndex = 1;
            this.confirmbutton2.Text = "Confirm";
            this.confirmbutton2.UseVisualStyleBackColor = true;
            this.confirmbutton2.Click += new System.EventHandler(this.confirmbutton2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1, 1);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(49, 44);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button searchbutton;
        private System.Windows.Forms.TextBox nametextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button confirmbutton1;
        private System.Windows.Forms.TextBox reloadtextBox;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox deducttextBox;
        private System.Windows.Forms.Button confirmbutton2;
        private System.Windows.Forms.Label balancelabel;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}