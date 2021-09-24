namespace IOOPassignment
{
    partial class Form3
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.confirmbutton = new System.Windows.Forms.Button();
            this.clearbutton = new System.Windows.Forms.Button();
            this.passwordtextBox = new System.Windows.Forms.TextBox();
            this.idtextBox = new System.Windows.Forms.TextBox();
            this.contacttextBox = new System.Windows.Forms.TextBox();
            this.nametextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.studentinfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tuitionDBDataSet1 = new IOOPassignment.tuitionDBDataSet1();
            this.studentinfoTableAdapter = new IOOPassignment.tuitionDBDataSet1TableAdapters.studentinfoTableAdapter();
            this.stuinfodataGridView = new System.Windows.Forms.DataGridView();
            this.studentIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentContactDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentCourseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalBalanceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentinfoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tuitionDBDataSet2 = new IOOPassignment.tuitionDBDataSet2();
            this.studentinfoTableAdapter1 = new IOOPassignment.tuitionDBDataSet2TableAdapters.studentinfoTableAdapter();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentinfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tuitionDBDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stuinfodataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentinfoBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tuitionDBDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(261, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Student Registration";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.dateTimePicker);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.confirmbutton);
            this.groupBox1.Controls.Add(this.clearbutton);
            this.groupBox1.Controls.Add(this.passwordtextBox);
            this.groupBox1.Controls.Add(this.idtextBox);
            this.groupBox1.Controls.Add(this.contacttextBox);
            this.groupBox1.Controls.Add(this.nametextBox);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(47, 222);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(699, 224);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Student Detail :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F);
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(173, 174);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(154, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "# 8 -15 characters, number only";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F);
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(181, 136);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "# alphabet only";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker.Location = new System.Drawing.Point(169, 190);
            this.dateTimePicker.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(152, 22);
            this.dateTimePicker.TabIndex = 11;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.checkBox6);
            this.groupBox4.Controls.Add(this.checkBox5);
            this.groupBox4.Controls.Add(this.checkBox4);
            this.groupBox4.Controls.Add(this.checkBox3);
            this.groupBox4.Controls.Add(this.checkBox2);
            this.groupBox4.Controls.Add(this.checkBox1);
            this.groupBox4.Location = new System.Drawing.Point(364, 34);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Size = new System.Drawing.Size(223, 172);
            this.groupBox4.TabIndex = 12;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Pick up to 4 courses :";
            this.groupBox4.Enter += new System.EventHandler(this.groupBox4_Enter);
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Location = new System.Drawing.Point(109, 128);
            this.checkBox6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(100, 21);
            this.checkBox6.TabIndex = 5;
            this.checkBox6.Text = "Accounting";
            this.checkBox6.UseVisualStyleBackColor = true;
            this.checkBox6.CheckedChanged += new System.EventHandler(this.checkBox6_CheckedChanged);
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Location = new System.Drawing.Point(109, 81);
            this.checkBox5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(109, 21);
            this.checkBox5.TabIndex = 3;
            this.checkBox5.Text = "Mathematics";
            this.checkBox5.UseVisualStyleBackColor = true;
            this.checkBox5.CheckedChanged += new System.EventHandler(this.checkBox5_CheckedChanged);
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(109, 34);
            this.checkBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(80, 21);
            this.checkBox4.TabIndex = 1;
            this.checkBox4.Text = "Science";
            this.checkBox4.UseVisualStyleBackColor = true;
            this.checkBox4.CheckedChanged += new System.EventHandler(this.checkBox4_CheckedChanged);
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(11, 128);
            this.checkBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(76, 21);
            this.checkBox3.TabIndex = 4;
            this.checkBox3.Text = "English";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(11, 80);
            this.checkBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(81, 21);
            this.checkBox2.TabIndex = 2;
            this.checkBox2.Text = "Chinese";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(11, 34);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(75, 21);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "Melayu";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // confirmbutton
            // 
            this.confirmbutton.Location = new System.Drawing.Point(604, 65);
            this.confirmbutton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.confirmbutton.Name = "confirmbutton";
            this.confirmbutton.Size = new System.Drawing.Size(75, 32);
            this.confirmbutton.TabIndex = 13;
            this.confirmbutton.Text = "Confirm";
            this.confirmbutton.UseVisualStyleBackColor = true;
            this.confirmbutton.Click += new System.EventHandler(this.confirmbutton_Click);
            // 
            // clearbutton
            // 
            this.clearbutton.Location = new System.Drawing.Point(604, 110);
            this.clearbutton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.clearbutton.Name = "clearbutton";
            this.clearbutton.Size = new System.Drawing.Size(75, 32);
            this.clearbutton.TabIndex = 14;
            this.clearbutton.Text = "Clear";
            this.clearbutton.UseVisualStyleBackColor = true;
            this.clearbutton.Click += new System.EventHandler(this.clearbutton_Click);
            // 
            // passwordtextBox
            // 
            this.passwordtextBox.Location = new System.Drawing.Point(169, 73);
            this.passwordtextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.passwordtextBox.Name = "passwordtextBox";
            this.passwordtextBox.PasswordChar = '•';
            this.passwordtextBox.Size = new System.Drawing.Size(152, 22);
            this.passwordtextBox.TabIndex = 6;
            this.passwordtextBox.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // idtextBox
            // 
            this.idtextBox.Location = new System.Drawing.Point(169, 36);
            this.idtextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.idtextBox.Name = "idtextBox";
            this.idtextBox.Size = new System.Drawing.Size(152, 22);
            this.idtextBox.TabIndex = 5;
            // 
            // contacttextBox
            // 
            this.contacttextBox.Location = new System.Drawing.Point(169, 149);
            this.contacttextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.contacttextBox.Name = "contacttextBox";
            this.contacttextBox.Size = new System.Drawing.Size(152, 22);
            this.contacttextBox.TabIndex = 9;
            this.contacttextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.contacttextBox_KeyPress);
            // 
            // nametextBox
            // 
            this.nametextBox.Location = new System.Drawing.Point(169, 112);
            this.nametextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nametextBox.Name = "nametextBox";
            this.nametextBox.Size = new System.Drawing.Size(152, 22);
            this.nametextBox.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(43, 190);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 17);
            this.label6.TabIndex = 4;
            this.label6.Text = "Current Date :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(43, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 17);
            this.label5.TabIndex = 3;
            this.label5.Text = "Contact No :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Name :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Password :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Username :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // studentinfoBindingSource
            // 
            this.studentinfoBindingSource.DataMember = "studentinfo";
            this.studentinfoBindingSource.DataSource = this.tuitionDBDataSet1;
            // 
            // tuitionDBDataSet1
            // 
            this.tuitionDBDataSet1.DataSetName = "tuitionDBDataSet1";
            this.tuitionDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentinfoTableAdapter
            // 
            this.studentinfoTableAdapter.ClearBeforeFill = true;
            // 
            // stuinfodataGridView
            // 
            this.stuinfodataGridView.AutoGenerateColumns = false;
            this.stuinfodataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.stuinfodataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.studentIDDataGridViewTextBoxColumn,
            this.studentNameDataGridViewTextBoxColumn,
            this.studentContactDataGridViewTextBoxColumn,
            this.studentCourseDataGridViewTextBoxColumn,
            this.totalBalanceDataGridViewTextBoxColumn});
            this.stuinfodataGridView.DataSource = this.studentinfoBindingSource1;
            this.stuinfodataGridView.Location = new System.Drawing.Point(9, 46);
            this.stuinfodataGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.stuinfodataGridView.Name = "stuinfodataGridView";
            this.stuinfodataGridView.RowTemplate.Height = 24;
            this.stuinfodataGridView.Size = new System.Drawing.Size(779, 171);
            this.stuinfodataGridView.TabIndex = 2;
            this.stuinfodataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.stuinfodataGridView_CellContentClick_1);
            // 
            // studentIDDataGridViewTextBoxColumn
            // 
            this.studentIDDataGridViewTextBoxColumn.DataPropertyName = "Student_ID";
            this.studentIDDataGridViewTextBoxColumn.HeaderText = "Student No";
            this.studentIDDataGridViewTextBoxColumn.Name = "studentIDDataGridViewTextBoxColumn";
            this.studentIDDataGridViewTextBoxColumn.Width = 150;
            // 
            // studentNameDataGridViewTextBoxColumn
            // 
            this.studentNameDataGridViewTextBoxColumn.DataPropertyName = "Student_Name";
            this.studentNameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.studentNameDataGridViewTextBoxColumn.Name = "studentNameDataGridViewTextBoxColumn";
            this.studentNameDataGridViewTextBoxColumn.Width = 150;
            // 
            // studentContactDataGridViewTextBoxColumn
            // 
            this.studentContactDataGridViewTextBoxColumn.DataPropertyName = "Student_Contact";
            this.studentContactDataGridViewTextBoxColumn.HeaderText = "Contact No";
            this.studentContactDataGridViewTextBoxColumn.Name = "studentContactDataGridViewTextBoxColumn";
            this.studentContactDataGridViewTextBoxColumn.Width = 150;
            // 
            // studentCourseDataGridViewTextBoxColumn
            // 
            this.studentCourseDataGridViewTextBoxColumn.DataPropertyName = "Student_Course";
            this.studentCourseDataGridViewTextBoxColumn.HeaderText = "Student Course";
            this.studentCourseDataGridViewTextBoxColumn.Name = "studentCourseDataGridViewTextBoxColumn";
            this.studentCourseDataGridViewTextBoxColumn.Width = 200;
            // 
            // totalBalanceDataGridViewTextBoxColumn
            // 
            this.totalBalanceDataGridViewTextBoxColumn.DataPropertyName = "Total_Balance";
            this.totalBalanceDataGridViewTextBoxColumn.HeaderText = "Total Balance";
            this.totalBalanceDataGridViewTextBoxColumn.Name = "totalBalanceDataGridViewTextBoxColumn";
            this.totalBalanceDataGridViewTextBoxColumn.Width = 150;
            // 
            // studentinfoBindingSource1
            // 
            this.studentinfoBindingSource1.DataMember = "studentinfo";
            this.studentinfoBindingSource1.DataSource = this.tuitionDBDataSet2;
            // 
            // tuitionDBDataSet2
            // 
            this.tuitionDBDataSet2.DataSetName = "tuitionDBDataSet2";
            this.tuitionDBDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentinfoTableAdapter1
            // 
            this.studentinfoTableAdapter1.ClearBeforeFill = true;
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
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.stuinfodataGridView);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentinfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tuitionDBDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stuinfodataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentinfoBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tuitionDBDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox passwordtextBox;
        private System.Windows.Forms.TextBox idtextBox;
        private System.Windows.Forms.TextBox contacttextBox;
        private System.Windows.Forms.TextBox nametextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button confirmbutton;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Button clearbutton;
        private tuitionDBDataSet1 tuitionDBDataSet1;
        private System.Windows.Forms.BindingSource studentinfoBindingSource;
        private tuitionDBDataSet1TableAdapters.studentinfoTableAdapter studentinfoTableAdapter;
        private System.Windows.Forms.DataGridView stuinfodataGridView;
        private tuitionDBDataSet2 tuitionDBDataSet2;
        private System.Windows.Forms.BindingSource studentinfoBindingSource1;
        private tuitionDBDataSet2TableAdapters.studentinfoTableAdapter studentinfoTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentContactDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentCourseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalBalanceDataGridViewTextBoxColumn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
    }
}