namespace IOOPassignment
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.label1 = new System.Windows.Forms.Label();
            this.breloadbutton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.sturegistrybutton = new System.Windows.Forms.Button();
            this.tutorregistrationbutton = new System.Windows.Forms.Button();
            this.logoutbutton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(253, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Staff Site";
            // 
            // breloadbutton
            // 
            this.breloadbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.breloadbutton.Location = new System.Drawing.Point(244, 89);
            this.breloadbutton.Margin = new System.Windows.Forms.Padding(2);
            this.breloadbutton.Name = "breloadbutton";
            this.breloadbutton.Size = new System.Drawing.Size(118, 81);
            this.breloadbutton.TabIndex = 2;
            this.breloadbutton.Text = "Student Balance";
            this.breloadbutton.UseVisualStyleBackColor = true;
            this.breloadbutton.Click += new System.EventHandler(this.breloadbutton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(31, 89);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(179, 177);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // sturegistrybutton
            // 
            this.sturegistrybutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.sturegistrybutton.Location = new System.Drawing.Point(244, 185);
            this.sturegistrybutton.Margin = new System.Windows.Forms.Padding(2);
            this.sturegistrybutton.Name = "sturegistrybutton";
            this.sturegistrybutton.Size = new System.Drawing.Size(118, 81);
            this.sturegistrybutton.TabIndex = 1;
            this.sturegistrybutton.Text = "Student Registration";
            this.sturegistrybutton.UseVisualStyleBackColor = true;
            this.sturegistrybutton.Click += new System.EventHandler(this.button1_Click);
            // 
            // tutorregistrationbutton
            // 
            this.tutorregistrationbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tutorregistrationbutton.Location = new System.Drawing.Point(380, 89);
            this.tutorregistrationbutton.Margin = new System.Windows.Forms.Padding(2);
            this.tutorregistrationbutton.Name = "tutorregistrationbutton";
            this.tutorregistrationbutton.Size = new System.Drawing.Size(118, 81);
            this.tutorregistrationbutton.TabIndex = 3;
            this.tutorregistrationbutton.Text = "Tutor Registration";
            this.tutorregistrationbutton.UseVisualStyleBackColor = true;
            this.tutorregistrationbutton.Click += new System.EventHandler(this.tutorregistrationbutton_Click);
            // 
            // logoutbutton
            // 
            this.logoutbutton.Location = new System.Drawing.Point(532, 331);
            this.logoutbutton.Margin = new System.Windows.Forms.Padding(2);
            this.logoutbutton.Name = "logoutbutton";
            this.logoutbutton.Size = new System.Drawing.Size(56, 25);
            this.logoutbutton.TabIndex = 4;
            this.logoutbutton.Text = "Log Out";
            this.logoutbutton.UseVisualStyleBackColor = true;
            this.logoutbutton.Click += new System.EventHandler(this.logoutbutton_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button1.Location = new System.Drawing.Point(380, 185);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 81);
            this.button1.TabIndex = 6;
            this.button1.Text = "Add/ Remove";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.logoutbutton);
            this.Controls.Add(this.tutorregistrationbutton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.breloadbutton);
            this.Controls.Add(this.sturegistrybutton);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form2";
            this.Text = " StaffSite";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button breloadbutton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button sturegistrybutton;
        private System.Windows.Forms.Button tutorregistrationbutton;
        private System.Windows.Forms.Button logoutbutton;
        private System.Windows.Forms.Button button1;
    }
}