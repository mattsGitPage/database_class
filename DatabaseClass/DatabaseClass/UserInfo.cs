using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

using MySql.Data.MySqlClient;

namespace DatabaseClass
{
    //creates users profile
    public partial class UserInfo : Form
    {
        public UserInfo()
        {
            InitializeComponent();
        }

        


        /*
         *ATTENTION: integrate this with the other button this fucks up the auto_increment insert of global id
         */
        private void button2_Click(object sender, EventArgs e)
        {
            //open file explorer and accept users image
            Stream myStream = null;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "JPEG Files (*.jpeg)|*.jpeg|PNG Files (*.png)|*.png|JPG Files (*.jpg)|*.jpg";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((myStream = openFileDialog1.OpenFile()) != null)
                    {
                        using (myStream)
                        {
                            //TODO save to database
                            var image = Bitmap.FromStream(myStream);

                            Global global_reference = Global.getInstance();

                            using (MySqlConnection con = new MySqlConnection(global_reference.get_sql_auth()))
                            {
                                string query = "insert into profile (picture) values (@picture)";
                                using (MySqlCommand cmd = new MySqlCommand(query, con))
                                {
                                    con.Open();
                                    cmd.Parameters.AddWithValue("@picture", image);
                                    cmd.ExecuteNonQuery();
                                    con.Close();
                                    MessageBox.Show("successfully uploaded image.");
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }
        }
        //save user information
        private void button1_Click(object sender, EventArgs e)
        {
            string firstName = first_name.Text.ToString();
            string lastName = last_name.Text.ToString();
            string age = userAge.Text.ToString();
            string gender = this.gender.Text.ToString();
            string city = this.city.Text.ToString();
            string aboutMe = about.Text.ToString();
            string pass = password.Text.ToString();
            string email = this.email.Text.ToString();
            string interest = this.interests.Text.ToString();
            string intent = this.intent.Text.ToString();
            string phone = this.phone.Text.ToString();


            /*
             * since we have a dependency on global id we need to insert a corresponding dating_users entity into the date_user table
             */

            Global global_reference = Global.getInstance();
            using (MySqlConnection con = new MySqlConnection(global_reference.get_sql_auth()))
            {
                //TODO: generate new icon for browse section of user
                //add created profile
               
                    string query0 = "insert into dating_users (user_name) values (@user_name)";
                using (MySqlCommand cmd = new MySqlCommand(query0, con))
                {
                    con.Open();
                    cmd.Parameters.AddWithValue("@user_name", firstName);
                    cmd.ExecuteNonQuery();
                    con.Close();
                }   
            }

            //open sql connection
            using (MySqlConnection con = new MySqlConnection(global_reference.get_sql_auth()))
                {
                  //TODO: generate new icon for browse section of user
                    //add created profile
                    string query = "insert into profile ( first_name, last_name, gender, about_me, dob, age, city) values (@first_name , @last_name, @gender, @about_me,  @dob, @age , @city)";
                    using (MySqlCommand cmd = new MySqlCommand(query, con))
                    {
                        con.Open();
                        cmd.Parameters.AddWithValue("@first_name", firstName);
                        cmd.Parameters.AddWithValue("@last_name", lastName);
                        cmd.Parameters.AddWithValue("@gender", gender);
                        cmd.Parameters.AddWithValue("@about_me", aboutMe);
                        cmd.Parameters.AddWithValue("@dob", "1990-03-07");
                        cmd.Parameters.AddWithValue("@age", age);
                        cmd.Parameters.AddWithValue("@city", city);
                        cmd.ExecuteNonQuery();
                        con.Close();
                    }


    //adds password and email to the credential table
              string query1 = "insert into credentials ( email, username,  password ,hint) values (@email, @username, @password , @hint)";
                using (MySqlCommand cmd = new MySqlCommand(query1, con))
                {
                    con.Open();
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@username", firstName);
                    cmd.Parameters.AddWithValue("@password", pass);
                    cmd.Parameters.AddWithValue("@hint", "contact an admin");
                    cmd.ExecuteNonQuery();
                    con.Close();
                }

                string query2 = "insert into objective ( intent) values (@intent)";
                using (MySqlCommand cmd = new MySqlCommand(query2, con))
                {
                    con.Open();
                    cmd.Parameters.AddWithValue("@intent", intent);
                    cmd.ExecuteNonQuery();
                    con.Close();
                }

                string query3 = "insert into interests ( interest) values (@interest)";
                using (MySqlCommand cmd = new MySqlCommand(query3, con))
                {
                    con.Open();
                    cmd.Parameters.AddWithValue("@interest", interest);
                    cmd.ExecuteNonQuery();
                    con.Close();
                }

                string query4 = "insert into contact_info (phone_number, first_name, last_name) values (@phone, @first, @last)";
                using (MySqlCommand cmd = new MySqlCommand(query4, con))
                {
                    con.Open();
                    cmd.Parameters.AddWithValue("@phone", phone);
                    cmd.Parameters.AddWithValue("@first", firstName);
                    cmd.Parameters.AddWithValue("@last", lastName);
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
            }


            MessageBox.Show("successfully created your profile. Please log in to access your account.");
            //open next page
                  this.Hide();
                  LoginPage page = new LoginPage();
                  page.Show();
                  this.Close();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void UserInfo_Load(object sender, EventArgs e)
        {

        }
    }
}
