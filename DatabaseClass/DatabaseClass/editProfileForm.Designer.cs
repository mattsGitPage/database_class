namespace DatabaseClass
{
    partial class editProfileForm
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
            this.intent = new System.Windows.Forms.Label();
            this.city = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.about_me = new System.Windows.Forms.Label();
            this.picture = new System.Windows.Forms.Label();
            this.Citi = new System.Windows.Forms.TextBox();
            this.interests = new System.Windows.Forms.TextBox();
            this.boutme = new System.Windows.Forms.TextBox();
            this.save = new System.Windows.Forms.Button();
            this.tent = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // intent
            // 
            this.intent.AutoSize = true;
            this.intent.Location = new System.Drawing.Point(12, 33);
            this.intent.Name = "intent";
            this.intent.Size = new System.Drawing.Size(43, 17);
            this.intent.TabIndex = 0;
            this.intent.Text = "intent";
            // 
            // city
            // 
            this.city.AutoSize = true;
            this.city.Location = new System.Drawing.Point(12, 80);
            this.city.Name = "city";
            this.city.Size = new System.Drawing.Size(29, 17);
            this.city.TabIndex = 1;
            this.city.Text = "city";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "interests";
            // 
            // about_me
            // 
            this.about_me.AutoSize = true;
            this.about_me.Location = new System.Drawing.Point(12, 213);
            this.about_me.Name = "about_me";
            this.about_me.Size = new System.Drawing.Size(67, 17);
            this.about_me.TabIndex = 3;
            this.about_me.Text = "about me";
            // 
            // picture
            // 
            this.picture.AutoSize = true;
            this.picture.Location = new System.Drawing.Point(12, 297);
            this.picture.Name = "picture";
            this.picture.Size = new System.Drawing.Size(51, 17);
            this.picture.TabIndex = 4;
            this.picture.Text = "picture";
            // 
            // Citi
            // 
            this.Citi.Location = new System.Drawing.Point(173, 74);
            this.Citi.Name = "Citi";
            this.Citi.Size = new System.Drawing.Size(189, 22);
            this.Citi.TabIndex = 5;
            // 
            // interests
            // 
            this.interests.Location = new System.Drawing.Point(173, 124);
            this.interests.Multiline = true;
            this.interests.Name = "interests";
            this.interests.Size = new System.Drawing.Size(189, 53);
            this.interests.TabIndex = 6;
            // 
            // boutme
            // 
            this.boutme.Location = new System.Drawing.Point(173, 210);
            this.boutme.Multiline = true;
            this.boutme.Name = "boutme";
            this.boutme.Size = new System.Drawing.Size(189, 71);
            this.boutme.TabIndex = 7;
            this.boutme.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(287, 312);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(75, 23);
            this.save.TabIndex = 8;
            this.save.Text = "save";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // tent
            // 
            this.tent.Location = new System.Drawing.Point(173, 28);
            this.tent.Name = "tent";
            this.tent.Size = new System.Drawing.Size(189, 22);
            this.tent.TabIndex = 9;
            // 
            // editProfileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 360);
            this.Controls.Add(this.tent);
            this.Controls.Add(this.save);
            this.Controls.Add(this.boutme);
            this.Controls.Add(this.interests);
            this.Controls.Add(this.Citi);
            this.Controls.Add(this.picture);
            this.Controls.Add(this.about_me);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.city);
            this.Controls.Add(this.intent);
            this.Name = "editProfileForm";
            this.Text = "editProfileForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label intent;
        private System.Windows.Forms.Label city;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label about_me;
        private System.Windows.Forms.Label picture;
        private System.Windows.Forms.TextBox Citi;
        private System.Windows.Forms.TextBox interests;
        private System.Windows.Forms.TextBox boutme;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.TextBox tent;
    }
}