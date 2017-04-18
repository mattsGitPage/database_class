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
    public partial class Likes : Form
    {
        Global global_reference = Global.getInstance();
        public Likes()
        {
            InitializeComponent();


            int user_id = global_reference.get_user_id();
            int interested_in = 0;
            string[] phone_number = new string[1000];
            string[] name = new string[1000];
            //Stores all the users information for contact



            /**
             * 
             *     THIS IS THE CORRECT QUERY TO GET RESULTS FOR THIS SECTION NEED TO IMPLEMENT IT THOUGH
             *     
                    select * from datapptho.match_list where glob_id = @glob_id
                            and interested_in_id in (select M.glob_id
                                                       from datapptho.match_list M
                                                        where glob_id = M.glob_id
                                                           and interested_in_id = @glob_id) // THIS NEEDS TO BE THE VALUE PASSED BY GLOBAL
             
             */

            ListViewItem items1 = null;
            MySqlDataReader read = null;
            string query = "select * from datapptho.match_list where glob_id = @glob_id and interested_in_id in (select M.glob_id from datapptho.match_list M where glob_id = M.glob_id and interested_in_id = @glob_id) ";
            using (MySqlConnection con = new MySqlConnection(global_reference.get_sql_auth()))
            {
                using (MySqlCommand cmd = new MySqlCommand(query, con))
                {
                    con.Open();
                    cmd.Parameters.AddWithValue("@glob_id", global_reference.get_user_id());
                    read = cmd.ExecuteReader();

                    int j = 0;
                    while (read.Read())
                    {

                        read.Read();
                        int interested = (int)read.GetValue(0);
                        interested_in = (int)read.GetValue(1);

                    }

                    read.Close();

                }
                string query1 = " select phone_number , first_name from contact_info where globe_id = @gid ";
                using (MySqlCommand cmd = new MySqlCommand(query1, con))
                {

                    cmd.Parameters.AddWithValue("@gid", interested_in.ToString());
                    read = cmd.ExecuteReader();

                    int i = 0;
                    while (read.Read())
                    {
                        read.Read();
                        phone_number[i] = (string)read.GetValue(0);
                        name[i] = (string)read.GetValue(1);
                        i++;

                    }
                    read.Close();
                    con.Close();

                }
            }//end of sql connection

            this.name.Text = string.Join("\n", name);
            this.num.Text = string.Join("\n", phone_number);

        }
            


        private void Likes_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomePage h = new HomePage();
            h.Show();
            this.Close();
        }
    }
}   
       


