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

            // Set the view to show details.
            listView1.View = View.Details;
            // Display grid lines.
            listView1.GridLines = true;
            // Sort the items in the list in ascending order.
            listView1.Sorting = SortOrder.Ascending;

            // Create columns for users personal information
            listView1.Columns.Add("name", -2, HorizontalAlignment.Left);
            listView1.Columns.Add("phone number", -2, HorizontalAlignment.Left);
            

           




            int user_id = global_reference.get_user_id();
            int interested_in = 0;
            string phone_number = String.Empty;
            //Stores all the users information for contact





            ListViewItem[] temp = new ListViewItem[1000];

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
        MySqlDataReader read = null;
            string query = "select * from datapptho.match_list where glob_id = @glob_id and interested_in_id in (select M.glob_id from datapptho.match_list M where glob_id = M.glob_id and interested_in_id = @glob_id) ";
            using (MySqlConnection con = new MySqlConnection("server=localhost; database=datapptho; user=group1; password=Password1"))
            {
                using (MySqlCommand cmd = new MySqlCommand(query, con))
                {
                    con.Open();
                    cmd.Parameters.AddWithValue("@glob_id", global_reference.get_user_id());
                     read = cmd.ExecuteReader();

                    int i = 0;
                    while (read.Read())
                    {

                        read.Read();
                        interested_in = (int)read.GetValue(1);

                        //this is the user that expresses interest in the currently logged in user
                        ListViewItem items = new ListViewItem(interested_in.ToString(), 1);
                       
                    }

                    read.Close();

                }
                string query1 = " select phone_number from contact_info where globe_id = @gid ";
                using (MySqlCommand cmd = new MySqlCommand(query1, con))
                {
                    
                    cmd.Parameters.AddWithValue("@gid", interested_in.ToString());
                     read = cmd.ExecuteReader();

                    int i = 0;
                    while (read.Read())
                    {
                        read.Read();
                        phone_number = (string)read.GetValue(0);
                       
                        // this should be the phone number from the db
                        //.SubItems.Add(phone_number);
                        i++;
                    }
                    read.Close();
                    con.Close();

                }
            }//end of sql connection
       
             //Add the items to the ListView.
           // listView1.Items.AddRange(new ListViewItem[] { item2, item3 });

        }

       
      

       
    }
}
