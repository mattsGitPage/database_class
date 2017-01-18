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
using System.Data.SqlClient;

namespace DatabaseClass
{
    //creates users profile
    public partial class UserInfo : Form
    {
        public UserInfo()
        {
            InitializeComponent();
        }

        //image upload 
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

                            using (SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-MKRJETA;Initial Catalog=date_app;Integrated Security=True"))
                            {
                                string query = "insert into user_create_profile (user_profile_pic) values (@user_profile_pic)";
                                using (SqlCommand cmd = new SqlCommand(query, con))
                                {
                                    con.Open();
                                    cmd.Parameters.AddWithValue("@user_profile_pic", image);
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
            string name = userName.Text.ToString();
            string pass = Password.Text.ToString();
            string confirmPass = ConfirmPassword.Text.ToString();
            string age = userAge.Text.ToString();
            string intent = userIntent.Text.ToString();
            string aboutMe = about.Text.ToString();
            string interest = interests.Text.ToString();

            //check if passwords are the same
            if(String.Compare(pass, confirmPass) != 0)
            {
                MessageBox.Show("passwords do not match");
            }
            else
            {
                //hash password
                HashAlgorithm passHash = new SHA1CryptoServiceProvider();
                byte[] bytePass = Encoding.ASCII.GetBytes(pass);
                byte[] passHashed = passHash.ComputeHash(bytePass);

                //open sql connection
                using (SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-MKRJETA;Initial Catalog=date_app;Integrated Security=True"))
                {
                    //TODO: generate new icon for browse section of user
                    //add created profile
                    string query = "insert into user_create_profile (user_name , user_password , user_age, user_intent , user_about_me, user_interests , user_upgraded) values (@user_name , @user_password, @user_age, @user_intent,  @user_about_me, @user_interests , @user_upgraded)";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        con.Open();
                        cmd.Parameters.AddWithValue("@user_name", name);
                        cmd.Parameters.AddWithValue("@user_password", passHashed);
                        cmd.Parameters.AddWithValue("@user_age", age);
                        cmd.Parameters.AddWithValue("@user_intent", intent);
                        cmd.Parameters.AddWithValue("@user_about_me", aboutMe);
                        cmd.Parameters.AddWithValue("@user_interests", interest);
                        cmd.Parameters.AddWithValue("@user_upgraded", 0);
                        cmd.ExecuteNonQuery();
                        con.Close();
                    }
                }

                //open next page
                  this.Hide();
                  HomePage page = new HomePage();
                  page.Show();
            }
        }
    }
}
