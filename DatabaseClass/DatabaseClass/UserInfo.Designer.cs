﻿namespace DatabaseClass
{
    partial class UserInfo
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.first_name = new System.Windows.Forms.TextBox();
            this.userAge = new System.Windows.Forms.TextBox();
            this.city = new System.Windows.Forms.TextBox();
            this.browse = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.gender = new System.Windows.Forms.TextBox();
            this.last_name = new System.Windows.Forms.TextBox();
            this.aboutMe = new System.Windows.Forms.Label();
            this.about = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(485, 451);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Create";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "first name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 199);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Age";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 237);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "city";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 271);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Picture";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(201, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(163, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "Please Enter Information";
            // 
            // first_name
            // 
            this.first_name.Location = new System.Drawing.Point(204, 78);
            this.first_name.Name = "first_name";
            this.first_name.Size = new System.Drawing.Size(160, 22);
            this.first_name.TabIndex = 6;
            // 
            // userAge
            // 
            this.userAge.Location = new System.Drawing.Point(204, 194);
            this.userAge.Name = "userAge";
            this.userAge.Size = new System.Drawing.Size(160, 22);
            this.userAge.TabIndex = 7;
            // 
            // city
            // 
            this.city.Location = new System.Drawing.Point(204, 232);
            this.city.Name = "city";
            this.city.Size = new System.Drawing.Size(160, 22);
            this.city.TabIndex = 8;
            // 
            // browse
            // 
            this.browse.Location = new System.Drawing.Point(204, 268);
            this.browse.Name = "browse";
            this.browse.Size = new System.Drawing.Size(75, 23);
            this.browse.TabIndex = 9;
            this.browse.Text = "browse...";
            this.browse.UseVisualStyleBackColor = true;
            this.browse.Click += new System.EventHandler(this.button2_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(43, 115);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "last name";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(43, 154);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 17);
            this.label7.TabIndex = 11;
            this.label7.Text = "gender";
            // 
            // gender
            // 
            this.gender.Location = new System.Drawing.Point(204, 151);
            this.gender.Name = "gender";
            this.gender.Size = new System.Drawing.Size(160, 22);
            this.gender.TabIndex = 12;
            // 
            // last_name
            // 
            this.last_name.Location = new System.Drawing.Point(204, 115);
            this.last_name.Name = "last_name";
            this.last_name.Size = new System.Drawing.Size(160, 22);
            this.last_name.TabIndex = 13;
            // 
            // aboutMe
            // 
            this.aboutMe.AutoSize = true;
            this.aboutMe.Location = new System.Drawing.Point(46, 319);
            this.aboutMe.Name = "aboutMe";
            this.aboutMe.Size = new System.Drawing.Size(68, 17);
            this.aboutMe.TabIndex = 14;
            this.aboutMe.Text = "About Me";
            // 
            // about
            // 
            this.about.Location = new System.Drawing.Point(204, 319);
            this.about.Multiline = true;
            this.about.Name = "about";
            this.about.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.about.Size = new System.Drawing.Size(261, 98);
            this.about.TabIndex = 15;
            this.about.Text = "enter information about you...";
            // 
            // UserInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 553);
            this.Controls.Add(this.about);
            this.Controls.Add(this.aboutMe);
            this.Controls.Add(this.last_name);
            this.Controls.Add(this.gender);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.browse);
            this.Controls.Add(this.city);
            this.Controls.Add(this.userAge);
            this.Controls.Add(this.first_name);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "UserInfo";
            this.Text = "Create Profile";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox first_name;
        private System.Windows.Forms.TextBox userAge;
        private System.Windows.Forms.TextBox city;
        private System.Windows.Forms.Button browse;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox gender;
        private System.Windows.Forms.TextBox last_name;
        private System.Windows.Forms.Label aboutMe;
        private System.Windows.Forms.TextBox about;
    }
}