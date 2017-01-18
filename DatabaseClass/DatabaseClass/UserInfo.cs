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

        public static byte[] ReadToEnd(Stream stream)
        {
            long originalPosition = 0;

            if (stream.CanSeek)
            {
                originalPosition = stream.Position;
                stream.Position = 0;
            }

            try
            {
                byte[] readBuffer = new byte[4096];

                int totalBytesRead = 0;
                int bytesRead;

                while ((bytesRead = stream.Read(readBuffer, totalBytesRead, readBuffer.Length - totalBytesRead)) > 0)
                {
                    totalBytesRead += bytesRead;

                    if (totalBytesRead == readBuffer.Length)
                    {
                        int nextByte = stream.ReadByte();
                        if (nextByte != -1)
                        {
                            byte[] temp = new byte[readBuffer.Length];
                            Buffer.BlockCopy(readBuffer, 0, temp, 0, readBuffer.Length);
                            Buffer.SetByte(temp, totalBytesRead, (byte)nextByte);
                            readBuffer = temp;
                            totalBytesRead++;
                        }
                    }
                }

                byte[] buffer = readBuffer;
                if (readBuffer.Length != totalBytesRead)
                {
                    buffer = new byte[totalBytesRead];
                    Buffer.BlockCopy(readBuffer, 0, buffer, 0, totalBytesRead);
                }
                return buffer;
            }
            finally
            {
                if (stream.CanSeek)
                {
                    stream.Position = originalPosition;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
          
            Stream myStream = null;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "PEG Files (*.jpeg)|*.jpeg|PNG Files (*.png)|*.png|JPG Files (*.jpg)|*.jpg";
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

                            using (SqlConnection con = new SqlConnection(@"Data Source=(localdb)\ProjectsV13;Initial Catalog=tempdb;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"))
                            {
                                string query = "insert into date_users (user_profile_pic) values (@user_profile_pic)";
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
                HashAlgorithm passHash = new SHA1CryptoServiceProvider();
                byte[] bytePass = Encoding.ASCII.GetBytes(pass);
                byte[] passHashed = passHash.ComputeHash(bytePass);

                //TODO save hash password to database and other crap
                //open sql connection and increment the yes count in database
                using (SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-MKRJETA;Initial Catalog=date_app;Integrated Security=True"))
                {

                    //added rate
                    string query = "insert into user_create_profile (user_name , user_password , user_age, user_intent , user_about_me, user_interests) values (@user_name , @user_password, @user_age, @user_intent,  @user_about_me, @user_interests)";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        con.Open();
                        cmd.Parameters.AddWithValue("@user_name", name);
                        cmd.Parameters.AddWithValue("@user_password", passHashed);
                        cmd.Parameters.AddWithValue("@user_age", age);
                        cmd.Parameters.AddWithValue("@user_intent", intent);
                        cmd.Parameters.AddWithValue("@user_about_me", aboutMe);
                        cmd.Parameters.AddWithValue("@user_interests", interest);
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
