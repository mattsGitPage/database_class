using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Diagnostics;
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

            //apply the filter and do a query. 

            Global global_reference = Global.getInstance();
            global_reference.ClearList();
            //Debug.WriteLine("DebugFrom ViewUsers: " +global_reference.getIntent());
            using (MySqlConnection con = new MySqlConnection(global_reference.get_sql_auth()))
            {
                string query = "select global_id from profile P, objective O  where global_id = O.g_id and city like \"%" + global_reference.getlocation() + "%\"" + " and age >= " +
                    global_reference.getMinAge() + " and age <= " + global_reference.getMaxAge() + " and intent  like \"%" + global_reference.getIntent() + "%\"" + " and gender = \"" + global_reference.getGender().ToUpper()[0]+"\"";
                using (MySqlCommand cmd = new MySqlCommand(query, con))
                {
                    con.Open();
                    cmd.Parameters.AddWithValue("@global_id", global_reference.get_user_id());
                    MySqlDataReader read = cmd.ExecuteReader();


                    //asign values
                    while (read.Read())
                    {
                        global_reference.AddToList((Int32)read.GetValue(0));

                        //DEBUG
                      //  Debug.WriteLine((Int32)read.GetValue(0));
                       
                    }

                    con.Close();
                }
            }

            int ii = 0;
            List<int> temp = global_reference.getList();

            try
            {
                this.button1.Text = temp[0].ToString();
                this.button2.Text = temp[1].ToString();
                this.button3.Text = temp[2].ToString();
                this.button4.Text = temp[3].ToString();
                this.button5.Text = temp[4].ToString();
                this.button6.Text = temp[5].ToString();
                this.button7.Text = temp[6].ToString();
                this.button8.Text = temp[7].ToString();
                this.button9.Text = temp[8].ToString();
                this.button10.Text = temp[9].ToString();
                this.button11.Text = temp[10].ToString();
                this.button12.Text = temp[11].ToString();
              
            }
            catch ( System.Exception e)
            {
                Debug.WriteLine(e.ToString());
            }

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
            
            //spawn the profile window for browsing 
            global_reference.setFlag(true);
            
            global_reference.set_browse_id(int.Parse(button1.Text));

            profile p = new profile();
            p.Show(); 
            
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
           
            //spawn the profile window for browsing 
            global_reference.setFlag(true);

            global_reference.set_browse_id(int.Parse(button2.Text));

            profile p = new profile();
            p.Show();
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

            //spawn the profile window for browsing 
            global_reference.setFlag(true);

            global_reference.set_browse_id(int.Parse(button5.Text));

            profile p = new profile();
            p.Show();
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

            //spawn the profile window for browsing 
            global_reference.setFlag(true);

            global_reference.set_browse_id(int.Parse(button7.Text));

            profile p = new profile();
            p.Show();
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

            //spawn the profile window for browsing 
            global_reference.setFlag(true);

            global_reference.set_browse_id(int.Parse(button4.Text));

            profile p = new profile();
            p.Show();
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

            //spawn the profile window for browsing 
            global_reference.setFlag(true);

            global_reference.set_browse_id(int.Parse(button6.Text));

            profile p = new profile();
            p.Show();
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

            //spawn the profile window for browsing 
            global_reference.setFlag(true);

            global_reference.set_browse_id(int.Parse(button8.Text));

            profile p = new profile();
            p.Show();
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

            //spawn the profile window for browsing 
            global_reference.setFlag(true);

            global_reference.set_browse_id(int.Parse(button10.Text));

            profile p = new profile();
            p.Show();
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

            //spawn the profile window for browsing 
            global_reference.setFlag(true);

            global_reference.set_browse_id(int.Parse(button3.Text));

            profile p = new profile();
            p.Show();
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
            //spawn the profile window for browsing 
            global_reference.setFlag(true);

            global_reference.set_browse_id(int.Parse(button9.Text));

            profile p = new profile();
            p.Show();
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
            //spawn the profile window for browsing 
            global_reference.setFlag(true);

            global_reference.set_browse_id(int.Parse(button11.Text));

            profile p = new profile();
            p.Show();
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
            //spawn the profile window for browsing 
            global_reference.setFlag(true);

            global_reference.set_browse_id(int.Parse(button12.Text));

            profile p = new profile();
            p.Show();
        }

        private void ViewUsers_Load(object sender, EventArgs e)
        {

        }
    }
}
