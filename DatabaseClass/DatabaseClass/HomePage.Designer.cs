namespace DatabaseClass
{
    partial class HomePage
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
            this.messages = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.profile = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.browse = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.matches = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.logout = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.upgrade = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // messages
            // 
            this.messages.Location = new System.Drawing.Point(49, 27);
            this.messages.Name = "messages";
            this.messages.Size = new System.Drawing.Size(75, 51);
            this.messages.TabIndex = 0;
            this.messages.UseVisualStyleBackColor = true;
            this.messages.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Messages";
            // 
            // profile
            // 
            this.profile.Location = new System.Drawing.Point(180, 27);
            this.profile.Name = "profile";
            this.profile.Size = new System.Drawing.Size(75, 51);
            this.profile.TabIndex = 2;
            this.profile.UseVisualStyleBackColor = true;
            this.profile.Click += new System.EventHandler(this.profile_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(192, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Profile";
            // 
            // browse
            // 
            this.browse.Location = new System.Drawing.Point(310, 27);
            this.browse.Name = "browse";
            this.browse.Size = new System.Drawing.Size(75, 51);
            this.browse.TabIndex = 4;
            this.browse.UseVisualStyleBackColor = true;
            this.browse.Click += new System.EventHandler(this.browse_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(322, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Browse";
            // 
            // matches
            // 
            this.matches.Location = new System.Drawing.Point(49, 119);
            this.matches.Name = "matches";
            this.matches.Size = new System.Drawing.Size(75, 51);
            this.matches.TabIndex = 6;
            this.matches.UseVisualStyleBackColor = true;
            this.matches.Click += new System.EventHandler(this.matches_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(52, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Matches";
            // 
            // logout
            // 
            this.logout.Location = new System.Drawing.Point(310, 119);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(75, 51);
            this.logout.TabIndex = 8;
            this.logout.UseVisualStyleBackColor = true;
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(322, 173);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Logout";
            // 
            // upgrade
            // 
            this.upgrade.Location = new System.Drawing.Point(180, 119);
            this.upgrade.Name = "upgrade";
            this.upgrade.Size = new System.Drawing.Size(75, 51);
            this.upgrade.TabIndex = 10;
            this.upgrade.UseVisualStyleBackColor = true;
            this.upgrade.Click += new System.EventHandler(this.upgrade_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(192, 173);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Upgrade";
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 294);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.upgrade);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.logout);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.matches);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.browse);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.profile);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.messages);
            this.Name = "HomePage";
            this.Text = "HomePage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button messages;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button profile;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button browse;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button matches;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button logout;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button upgrade;
        private System.Windows.Forms.Label label6;
    }
}