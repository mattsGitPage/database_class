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

        private void button1_Click(object sender, EventArgs e)
        {
            //open message page
            this.Hide();
            MessageUser mu = new MessageUser();
            mu.Show();

        }

        private void profile_Click(object sender, EventArgs e)
        {
            this.Hide();
            profile p = new profile();
            p.Show();


        }

        private void browse_Click(object sender, EventArgs e)
        {
            this.Hide();
            ViewUsers vu = new ViewUsers();
            vu.Show();
        }

        private void matches_Click(object sender, EventArgs e)
        {
            this.Hide();
            matches m = new matches();
            m.Show();
        }

        private void upgrade_Click(object sender, EventArgs e)
        {
            this.Hide();
            upgrade up = new upgrade();
            up.Show();
        }

        private void logout_Click(object sender, EventArgs e)
        {



            //exit
            this.Close();
        }
    }
}
