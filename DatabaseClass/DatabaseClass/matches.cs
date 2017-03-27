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
            int[] intersted_in = new int[1000] ;
            int i = 0;
            int j = 0;

            string query = "select interested_in_id from match_list where glob_id = @glob_id";
            using (MySqlConnection con = new MySqlConnection("server=localhost; database=datapptho; user=group1; password=Password1"))
            {
                using (MySqlCommand cmd = new MySqlCommand(query, con))
                {
                    con.Open();
                    cmd.Parameters.AddWithValue("@glob_id", global_reference.get_user_id());
                    MySqlDataReader read = cmd.ExecuteReader();

                    //add all the signed in users likes
                    while(read.Read())
                    {
                        read.Read();
                        intersted_in[i] = (int)read.GetValue(1);
                        i++;
                    }

                }
            }


            //iterate through all the users likes and see if they like user as well
            
            using (MySqlConnection con = new MySqlConnection("server=localhost; database=datapptho; user=group1; password=Password1"))
            {
                while (j <= i)
                {
                    string query2 = "select interested_in_id from match_list where glob_id = @glob_id";
                    using (MySqlCommand cmd = new MySqlCommand(query, con))
                    {
                        con.Open();
                        cmd.Parameters.AddWithValue("@glob_id", global_reference.get_user_id());
                        MySqlDataReader read = cmd.ExecuteReader();

                        //add all the signed in users likes
                        while (read.Read())
                        {
                            read.Read();
                            intersted_in[i] = (int)read.GetValue(1);
                            i++;
                        }
                        j++;

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
