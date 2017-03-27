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
using MySql.Data.MySqlClient;

namespace DatabaseClass
{
    public partial class LoginPage : Form
    {
        //local user information
        Global global_reference = Global.getInstance();
        public LoginPage()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //get password
            string pass1 = pass.Text.ToString();
            string email = user_name.Text.ToString();
            string stored_pass = String.Empty;
            int user_id;
            

            //compare with pass in database
            string query = "select password , global_credentials_id from credentials where email = @email";
            using (MySqlConnection con = new MySqlConnection("server=localhost; database=datapptho; user=group1; password=Password1"))
            {
                using (MySqlCommand cmd = new MySqlCommand(query, con))
                {
                    con.Open();
                    //get the user name to compare password
                    cmd.Parameters.AddWithValue("@email", email);
                    MySqlDataReader read = cmd.ExecuteReader();

                    //check values in row
                    
                        read.Read();
                        stored_pass = (String)read.GetValue(0);
                        user_id = (int)read.GetValue(1);
                       
                   
                    //compare passwords
                    if(stored_pass == pass1)
                    {
                        //TODO redirect to user profile page
                        global_reference.set_user_id(user_id);
                        MessageBox.Show("successfully logged in");
                        this.Hide();
                        profile p = new profile();
                        p.Show();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("invalid password or email");
                    }
                }
            }
               

            }
    }
}
