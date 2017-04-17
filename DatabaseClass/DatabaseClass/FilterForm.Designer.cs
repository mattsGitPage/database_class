namespace DatabaseClass
{
    partial class FilterForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.minage = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.maxage = new System.Windows.Forms.TextBox();
            this.location = new System.Windows.Forms.TextBox();
            this.maleb = new System.Windows.Forms.RadioButton();
            this.femaleb = new System.Windows.Forms.RadioButton();
            this.intenttt = new System.Windows.Forms.TextBox();
            this.submit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "age between";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "location";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "gender";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "intent";
            // 
            // minage
            // 
            this.minage.Location = new System.Drawing.Point(122, 44);
            this.minage.Name = "minage";
            this.minage.Size = new System.Drawing.Size(100, 22);
            this.minage.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(243, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "to";
            // 
            // maxage
            // 
            this.maxage.Location = new System.Drawing.Point(281, 44);
            this.maxage.Name = "maxage";
            this.maxage.Size = new System.Drawing.Size(100, 22);
            this.maxage.TabIndex = 6;
            // 
            // location
            // 
            this.location.Location = new System.Drawing.Point(122, 88);
            this.location.Name = "location";
            this.location.Size = new System.Drawing.Size(100, 22);
            this.location.TabIndex = 7;
            // 
            // maleb
            // 
            this.maleb.AutoSize = true;
            this.maleb.Location = new System.Drawing.Point(112, 147);
            this.maleb.Name = "maleb";
            this.maleb.Size = new System.Drawing.Size(59, 21);
            this.maleb.TabIndex = 8;
            this.maleb.TabStop = true;
            this.maleb.Text = "male";
            this.maleb.UseVisualStyleBackColor = true;
            // 
            // femaleb
            // 
            this.femaleb.AutoSize = true;
            this.femaleb.Location = new System.Drawing.Point(190, 147);
            this.femaleb.Name = "femaleb";
            this.femaleb.Size = new System.Drawing.Size(71, 21);
            this.femaleb.TabIndex = 9;
            this.femaleb.TabStop = true;
            this.femaleb.Text = "female";
            this.femaleb.UseVisualStyleBackColor = true;
            // 
            // intenttt
            // 
            this.intenttt.Location = new System.Drawing.Point(112, 193);
            this.intenttt.Name = "intenttt";
            this.intenttt.Size = new System.Drawing.Size(100, 22);
            this.intenttt.TabIndex = 10;
            // 
            // submit
            // 
            this.submit.Location = new System.Drawing.Point(436, 282);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(75, 23);
            this.submit.TabIndex = 11;
            this.submit.Text = "submit";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // FilterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 331);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.intenttt);
            this.Controls.Add(this.femaleb);
            this.Controls.Add(this.maleb);
            this.Controls.Add(this.location);
            this.Controls.Add(this.maxage);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.minage);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FilterForm";
            this.Text = "FilterForm";
            this.Load += new System.EventHandler(this.FilterForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox minage;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox maxage;
        private System.Windows.Forms.TextBox location;
        private System.Windows.Forms.RadioButton maleb;
        private System.Windows.Forms.RadioButton femaleb;
        private System.Windows.Forms.TextBox intenttt;
        private System.Windows.Forms.Button submit;
    }
}