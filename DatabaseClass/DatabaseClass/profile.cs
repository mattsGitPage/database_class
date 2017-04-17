using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using DatabaseClass;

namespace DatabaseClass
{
    public partial class profile : Form
    {
        //local user data for quick reference
        Global global_reference = Global.getInstance();

        /*
         * on page load set up all the users information as he was to view his own profile
         * TODO figure out how to set up a browse function for all users
         */
        public profile()
        {
            InitializeComponent();

            //variables to be assigned
            string first_name = String.Empty;
            int agee = 0;
            string aboutMe = String.Empty;
            string city = String.Empty;
            string interest = String.Empty;
            string intent = String.Empty;

			using (MySqlConnection con = new MySqlConnection(global_reference.get_sql_auth()))
            {
                string query = "select P.first_name, P.age, P.about_me, P.city , O.intent , I.interest from profile P, objective O, interests I where global_id= @global_id and I.global_interest_id = @global_id and O.g_id = @global_id";
                using (MySqlCommand cmd = new MySqlCommand(query, con))
                {
                    con.Open();
                    cmd.Parameters.AddWithValue("@global_id", global_reference.get_user_id());
                    MySqlDataReader read =  cmd.ExecuteReader();

                   
                    //asign values
                    if (read.Read())
                    {
                        first_name = (String)read.GetValue(0);
                        agee = (Int32)read.GetValue(1);
                        aboutMe = (String)read.GetValue(2);
                        city = (String)read.GetValue(3);
                        intent = (String)read.GetValue(4);
                        interest = (String)read.GetValue(5);
                    }

                    con.Close();
                }
            }
            //change the values on the profile for user to view
            name.Text = first_name;
            this.age.Text = agee.ToString();
            this.city.Text = city;
            boutme.Text = aboutMe;
            this.interest.Text = interest;
            this.intent.Text = intent;
            //TODO: add picture... box already on profile
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void edit_Click(object sender, EventArgs e)
        {
            this.Hide();
            editProfileForm p = new editProfileForm();
            p.Show();
            this.Close();
        }

        private void home_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomePage h = new HomePage();
            h.Show();
            this.Close();

        }
    }
}
