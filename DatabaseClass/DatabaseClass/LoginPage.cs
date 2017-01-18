using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Data.SqlClient;

namespace DatabaseClass
{
    public partial class LoginPage : Form
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //get hash of password
            HashAlgorithm sha = new SHA1CryptoServiceProvider();
            string pass1 = pass.Text.ToString();
            byte[] password = Encoding.ASCII.GetBytes(pass1);
            byte[] hashPass = sha.ComputeHash(password);
            string password_entered = String.Empty;
            byte[] password_entered_bytes = null;

            //compare with hash in database
            //TODO issues with password hashing
            string query = "select user_password from user_create_profile where user_name = @user_name";
            using (SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-MKRJETA;Initial Catalog=date_app;Integrated Security=True"))
            {
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    con.Open();
                    //get the user name to compare password
                    string user = user_name.Text.ToString();
                    cmd.Parameters.AddWithValue("@user_name", user);
                    SqlDataReader read = cmd.ExecuteReader();

                    //check values in row
                    
                        read.Read();
                        password_entered_bytes = (byte[])read.GetValue(0);
                       
                   
                    var compare_passwords = hashPass.SequenceEqual(password_entered_bytes);
                    if(compare_passwords)
                    {
                        //TODO set up user account page 
                        MessageBox.Show("successfully logged in");
                    }
                    else
                    {
                        MessageBox.Show("invalid password");
                    }
                }
            }
               

            }
    }
}
