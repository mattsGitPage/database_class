using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using DatabaseClass;

namespace DatabaseClass
{
    public partial class matches : Form
    {
        //users info
        Global global_reference = Global.getInstance();
        public matches()
        {
            InitializeComponent();
            int user_id = global_reference.get_user_id();
            int interested_user = 0;
            int interested_in = 0;
            //Stores all the users information for contact
            string[] contactInfo = null;
            string phone_number = String.Empty;


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
            string query = "select * from datapptho.match_list where glob_id = @glob_id and interested_in_id in (select M.glob_id from datapptho.match_list M where glob_id = M.glob_id and interested_in_id = @glob_id) ";
            using (MySqlConnection con = new MySqlConnection("server=localhost; database=datapptho; user=group1; password=Password1"))
            {
                using (MySqlCommand cmd = new MySqlCommand(query, con))
                {
                    con.Open();
                    cmd.Parameters.AddWithValue("@glob_id", global_reference.get_user_id());
                    MySqlDataReader read = cmd.ExecuteReader();

                    while (read.Read())
                    {
                        read.Read();
                        interested_user = (int)read.GetValue(1);
                        interested_in = (int)read.GetValue(1);
                        //add the other user that shares interest the unique tag
                        contactInfo[0] = interested_in.ToString();


                    }


                }
                string query1 = " select phone_number from contact_info where globe_id = @gid ";
                using (MySqlCommand cmd = new MySqlCommand(query1, con))
                {
                    con.Open();
                    cmd.Parameters.AddWithValue("@gid", interested_in.ToString());
                    MySqlDataReader read = cmd.ExecuteReader();

                    while (read.Read())
                    {
                        read.Read();
                        phone_number = (string)read.GetValue(0);
                        contactInfo[1] = phone_number;
                    }

                }
            }


        }

        //list of the users matches as well as their contact info
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
        
        }
    }
}
