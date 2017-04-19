using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatabaseClass
{
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }

        //open list of liked users?? not sure what else to incorperate into the app
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Likes mu = new Likes();
            mu.Show();
            this.Close();
        }

        //view logged in users profile
        private void profile_Click(object sender, EventArgs e)
        {
            this.Hide();
            profile p = new profile();
            p.Show();
            this.Close();
        }

        //shows a list of users to like
        private void browse_Click(object sender, EventArgs e)
        {
            //this.Hide();
            ViewUsers vu = new ViewUsers();
            vu.Show();
            //this.Close();
        }

        //this will show matches with their contact info
        private void matches_Click(object sender, EventArgs e)
        {
            this.Hide();
            matches m = new matches();
            m.Show();
            this.Close();
        }

        //TODO: think of a different button 
        private void upgrade_Click(object sender, EventArgs e)
        {
            this.Hide();
            FilterForm f = new FilterForm();
           f.Show();
            this.Hide();
        }

        private void logout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("exiting from the dating application");
            Application.Exit();
        }
    }
}
