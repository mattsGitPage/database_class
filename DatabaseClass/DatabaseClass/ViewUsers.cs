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

namespace DatabaseClass
{
    public partial class ViewUsers : Form
    {
        public ViewUsers()
        {
            InitializeComponent();
        }
  
     

        private void button1_Click_1(object sender, EventArgs e)
        {
            //variables to be assigned
            string first_name = String.Empty;
            int agee = 0;
            string aboutMe = String.Empty;
            string city = String.Empty;
            string interest = String.Empty;
            string intent = String.Empty;

            Global global_reference = Global.getInstance();
            using (MySqlConnection con = new MySqlConnection(global_reference.get_sql_auth()))
            {
                string query = "select P.first_name, P.age, P.about_me, P.city , O.intent , I.interest from profile P, objective O, interests I where global_id= @global_id and I.global_interest_id = @global_id and O.g_id = @global_id";
                using (MySqlCommand cmd = new MySqlCommand(query, con))
                {
                    con.Open();
                    cmd.Parameters.AddWithValue("@global_id", global_reference.get_user_id());
                    MySqlDataReader read = cmd.ExecuteReader();


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
            //name.Text = first_name;
            //this.age.Text = agee.ToString();
            //this.city.Text = city;
            //boutme.Text = aboutMe;
            //this.interest.Text = interest;
            //this.intent.Text = intent;
            //TODO: add picture... box already on profile
            global_reference.setFirstName(first_name);
            global_reference.setAge(agee.ToString());
            global_reference.setCity(city);
            global_reference.setAboutMe(aboutMe);
            global_reference.setInterest(interest);
            global_reference.setIntentBrowse(intent);

            new profile().Show(); 

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //variables to be assigned
            string first_name = String.Empty;
            int agee = 0;
            string aboutMe = String.Empty;
            string city = String.Empty;
            string interest = String.Empty;
            string intent = String.Empty;

            Global global_reference = Global.getInstance();
            using (MySqlConnection con = new MySqlConnection(global_reference.get_sql_auth()))
            {
                string query = "select P.first_name, P.age, P.about_me, P.city , O.intent , I.interest from profile P, objective O, interests I where global_id= @global_id and I.global_interest_id = @global_id and O.g_id = @global_id";
                using (MySqlCommand cmd = new MySqlCommand(query, con))
                {
                    con.Open();
                    cmd.Parameters.AddWithValue("@global_id", global_reference.get_user_id());
                    MySqlDataReader read = cmd.ExecuteReader();


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
            //name.Text = first_name;
            //this.age.Text = agee.ToString();
            //this.city.Text = city;
            //boutme.Text = aboutMe;
            //this.interest.Text = interest;
            //this.intent.Text = intent;
            //TODO: add picture... box already on profile
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //variables to be assigned
            string first_name = String.Empty;
            int agee = 0;
            string aboutMe = String.Empty;
            string city = String.Empty;
            string interest = String.Empty;
            string intent = String.Empty;

            Global global_reference = Global.getInstance();
            using (MySqlConnection con = new MySqlConnection(global_reference.get_sql_auth()))
            {
                string query = "select P.first_name, P.age, P.about_me, P.city , O.intent , I.interest from profile P, objective O, interests I where global_id= @global_id and I.global_interest_id = @global_id and O.g_id = @global_id";
                using (MySqlCommand cmd = new MySqlCommand(query, con))
                {
                    con.Open();
                    cmd.Parameters.AddWithValue("@global_id", global_reference.get_user_id());
                    MySqlDataReader read = cmd.ExecuteReader();


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
            //name.Text = first_name;
            //this.age.Text = agee.ToString();
            //this.city.Text = city;
            //boutme.Text = aboutMe;
            //this.interest.Text = interest;
            //this.intent.Text = intent;
            //TODO: add picture... box already on profile
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //variables to be assigned
            string first_name = String.Empty;
            int agee = 0;
            string aboutMe = String.Empty;
            string city = String.Empty;
            string interest = String.Empty;
            string intent = String.Empty;

            Global global_reference = Global.getInstance();
            using (MySqlConnection con = new MySqlConnection(global_reference.get_sql_auth()))
            {
                string query = "select P.first_name, P.age, P.about_me, P.city , O.intent , I.interest from profile P, objective O, interests I where global_id= @global_id and I.global_interest_id = @global_id and O.g_id = @global_id";
                using (MySqlCommand cmd = new MySqlCommand(query, con))
                {
                    con.Open();
                    cmd.Parameters.AddWithValue("@global_id", global_reference.get_user_id());
                    MySqlDataReader read = cmd.ExecuteReader();


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
            //name.Text = first_name;
            //this.age.Text = agee.ToString();
            //this.city.Text = city;
            //boutme.Text = aboutMe;
            //this.interest.Text = interest;
            //this.intent.Text = intent;
            //TODO: add picture... box already on profile
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //variables to be assigned
            string first_name = String.Empty;
            int agee = 0;
            string aboutMe = String.Empty;
            string city = String.Empty;
            string interest = String.Empty;
            string intent = String.Empty;

            Global global_reference = Global.getInstance();
            using (MySqlConnection con = new MySqlConnection(global_reference.get_sql_auth()))
            {
                string query = "select P.first_name, P.age, P.about_me, P.city , O.intent , I.interest from profile P, objective O, interests I where global_id= @global_id and I.global_interest_id = @global_id and O.g_id = @global_id";
                using (MySqlCommand cmd = new MySqlCommand(query, con))
                {
                    con.Open();

                    cmd.Parameters.AddWithValue("@global_id", global_reference.get_user_id());
                    MySqlDataReader read = cmd.ExecuteReader();


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
            //name.Text = first_name;
            //this.age.Text = agee.ToString();
            //this.city.Text = city;
            //boutme.Text = aboutMe;
            //this.interest.Text = interest;
            //this.intent.Text = intent;
            //TODO: add picture... box already on profile
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //variables to be assigned
            string first_name = String.Empty;
            int agee = 0;
            string aboutMe = String.Empty;
            string city = String.Empty;
            string interest = String.Empty;
            string intent = String.Empty;
            //this is a comment
            Global global_reference = Global.getInstance();
            using (MySqlConnection con = new MySqlConnection(global_reference.get_sql_auth()))
            {
                string query = "select P.first_name, P.age, P.about_me, P.city , O.intent , I.interest from profile P, objective O, interests I where global_id= @global_id and I.global_interest_id = @global_id and O.g_id = @global_id";
                using (MySqlCommand cmd = new MySqlCommand(query, con))
                {
                    con.Open();
                    cmd.Parameters.AddWithValue("@global_id", global_reference.get_user_id());
                    MySqlDataReader read = cmd.ExecuteReader();


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
            //name.Text = first_name;
            //this.age.Text = agee.ToString();
            //this.city.Text = city;
            //boutme.Text = aboutMe;
            //this.interest.Text = interest;
            //this.intent.Text = intent;
            //TODO: add picture... box already on profile
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //variables to be assigned
            string first_name = String.Empty;
            int agee = 0;
            string aboutMe = String.Empty;
            string city = String.Empty;
            string interest = String.Empty;
            string intent = String.Empty;

            Global global_reference = Global.getInstance();
            using (MySqlConnection con = new MySqlConnection(global_reference.get_sql_auth()))
            {
                string query = "select P.first_name, P.age, P.about_me, P.city , O.intent , I.interest from profile P, objective O, interests I where global_id= @global_id and I.global_interest_id = @global_id and O.g_id = @global_id";
                using (MySqlCommand cmd = new MySqlCommand(query, con))
                {
                    con.Open();
                    cmd.Parameters.AddWithValue("@global_id", global_reference.get_user_id());
                    MySqlDataReader read = cmd.ExecuteReader();


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
            //name.Text = first_name;
            //this.age.Text = agee.ToString();
            //this.city.Text = city;
            //boutme.Text = aboutMe;
            //this.interest.Text = interest;
            //this.intent.Text = intent;
            //TODO: add picture... box already on profile
        }

        private void button10_Click(object sender, EventArgs e)
        {
            //variables to be assigned
            string first_name = String.Empty;
            int agee = 0;
            string aboutMe = String.Empty;
            string city = String.Empty;
            string interest = String.Empty;
            string intent = String.Empty;

            Global global_reference = Global.getInstance();
            using (MySqlConnection con = new MySqlConnection(global_reference.get_sql_auth()))
            {
                string query = "select P.first_name, P.age, P.about_me, P.city , O.intent , I.interest from profile P, objective O, interests I where global_id= @global_id and I.global_interest_id = @global_id and O.g_id = @global_id";
                using (MySqlCommand cmd = new MySqlCommand(query, con))
                {
                    con.Open();
                    cmd.Parameters.AddWithValue("@global_id", global_reference.get_user_id());
                    MySqlDataReader read = cmd.ExecuteReader();


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
            //name.Text = first_name;
            //this.age.Text = agee.ToString();
            //this.city.Text = city;
            //boutme.Text = aboutMe;
            //this.interest.Text = interest;
            //this.intent.Text = intent;
            //TODO: add picture... box already on profile
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //variables to be assigned
            string first_name = String.Empty;
            int agee = 0;
            string aboutMe = String.Empty;
            string city = String.Empty;
            string interest = String.Empty;
            string intent = String.Empty;

            Global global_reference = Global.getInstance();
            using (MySqlConnection con = new MySqlConnection(global_reference.get_sql_auth()))
            {
                string query = "select P.first_name, P.age, P.about_me, P.city , O.intent , I.interest from profile P, objective O, interests I where global_id= @global_id and I.global_interest_id = @global_id and O.g_id = @global_id";
                using (MySqlCommand cmd = new MySqlCommand(query, con))
                {
                    con.Open();
                    cmd.Parameters.AddWithValue("@global_id", global_reference.get_user_id());
                    MySqlDataReader read = cmd.ExecuteReader();


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
            //name.Text = first_name;
            //this.age.Text = agee.ToString();
            //this.city.Text = city;
            //boutme.Text = aboutMe;
            //this.interest.Text = interest;
            //this.intent.Text = intent;
            //TODO: add picture... box already on profile
        }

        private void button9_Click(object sender, EventArgs e)
        {
            //variables to be assigned
            string first_name = String.Empty;
            int agee = 0;
            string aboutMe = String.Empty;
            string city = String.Empty;
            string interest = String.Empty;
            string intent = String.Empty;

            Global global_reference = Global.getInstance();
            using (MySqlConnection con = new MySqlConnection(global_reference.get_sql_auth()))
            {
                string query = "select P.first_name, P.age, P.about_me, P.city , O.intent , I.interest from profile P, objective O, interests I where global_id= @global_id and I.global_interest_id = @global_id and O.g_id = @global_id";
                using (MySqlCommand cmd = new MySqlCommand(query, con))
                {
                    con.Open();
                    cmd.Parameters.AddWithValue("@global_id", global_reference.get_user_id());
                    MySqlDataReader read = cmd.ExecuteReader();


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
            //name.Text = first_name;
            //this.age.Text = agee.ToString();
            //this.city.Text = city;
            //boutme.Text = aboutMe;
            //this.interest.Text = interest;
            //this.intent.Text = intent;
            //TODO: add picture... box already on profile
        }

        private void button11_Click(object sender, EventArgs e)
        {
            //variables to be assigned
            string first_name = String.Empty;
            int agee = 0;
            string aboutMe = String.Empty;
            string city = String.Empty;
            string interest = String.Empty;
            string intent = String.Empty;

            Global global_reference = Global.getInstance();
            using (MySqlConnection con = new MySqlConnection(global_reference.get_sql_auth()))
            {
                string query = "select P.first_name, P.age, P.about_me, P.city , O.intent , I.interest from profile P, objective O, interests I where global_id= @global_id and I.global_interest_id = @global_id and O.g_id = @global_id";
                using (MySqlCommand cmd = new MySqlCommand(query, con))
                {
                    con.Open();
                    cmd.Parameters.AddWithValue("@global_id", global_reference.get_user_id());
                    MySqlDataReader read = cmd.ExecuteReader();


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
            //name.Text = first_name;
            //this.age.Text = agee.ToString();
            //this.city.Text = city;
            //boutme.Text = aboutMe;
            //this.interest.Text = interest;
            //this.intent.Text = intent;
            //TODO: add picture... box already on profile
        }

        private void button12_Click(object sender, EventArgs e)
        {
            //variables to be assigned
            string first_name = String.Empty;
            int agee = 0;
            string aboutMe = String.Empty;
            string city = String.Empty;
            string interest = String.Empty;
            string intent = String.Empty;

            Global global_reference = Global.getInstance();
            using (MySqlConnection con = new MySqlConnection(global_reference.get_sql_auth()))
            {
                string query = "select P.first_name, P.age, P.about_me, P.city , O.intent , I.interest from profile P, objective O, interests I where global_id= @global_id and I.global_interest_id = @global_id and O.g_id = @global_id";
                using (MySqlCommand cmd = new MySqlCommand(query, con))
                {
                    con.Open();
                    cmd.Parameters.AddWithValue("@global_id", global_reference.get_user_id());
                    MySqlDataReader read = cmd.ExecuteReader();


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
            //name.Text = first_name;
            //this.age.Text = agee.ToString();
            //this.city.Text = city;
            //boutme.Text = aboutMe;
            //this.interest.Text = interest;
            //this.intent.Text = intent;
            //TODO: add picture... box already on profile
        }
    }
}
