using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace DatabaseClass
{
    public partial class editProfileForm : Form
    {
        //global user access
        Global global_reference = Global.getInstance();
        public editProfileForm()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        //save all the updates to the users profile
        private void save_Click(object sender, EventArgs e)
        {
          
            //get data from edit text field
            string aboutMe = boutme.Text.ToString();
            string city = Citi.Text.ToString();
            string interests = this.interests.Text.ToString();
            string intent = this.tent.Text.ToString();

            //connect to mysql and update the information
			using (MySqlConnection con = new MySqlConnection(global_reference.get_sql_auth()))
            {

                //queries to update the profile
                // string test_begin = "BEGIN TRANSACTION;update profile set about_me = @about_me, city = @city, where global_id =@global_id ; update interests set interests = @interests, where global_interest_id = @global_id; update objective set intent = @intent, where g_id =@global_id;  COMMIT;";
                string profile_query = "update profile set about_me = @about_me, city = @city, where global_id =@global_id ";
                string interests_query = "update interests set interest = @interests, where global_interest_id = @global_id";
                string objective_query = "update objective set intent = @intent, where g_id =@global_id";

                //update all tables
                //TODO: add support for picture
                using (MySqlCommand cmd = new MySqlCommand(profile_query, con))
                {
                    con.Open();
                    cmd.Parameters.AddWithValue("@global_id", global_reference.get_user_id());
                    cmd.Parameters.AddWithValue("@about_me", aboutMe);
                    cmd.Parameters.AddWithValue("@city", city);
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
                using (MySqlCommand cmd = new MySqlCommand(interests_query, con))
                {
                    con.Open();
                    cmd.Parameters.AddWithValue("@global_id", global_reference.get_user_id());
                    cmd.Parameters.AddWithValue("@interests", interests);
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
                using (MySqlCommand cmd = new MySqlCommand(objective_query, con))
                {
                    con.Open();
                    cmd.Parameters.AddWithValue("@global_id", global_reference.get_user_id());
                    cmd.Parameters.AddWithValue("@intent", intent);
                    cmd.ExecuteNonQuery();
                    con.Close();
                }

            }



        }
    }
}
