using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using DatabaseClass;

namespace DatabaseClass
{

    /**
     * matches just returns everyone in db
     * 
     */
    public partial class matches : Form
    {
        //users info
        Global global_reference = Global.getInstance();
        public matches()
        {
            InitializeComponent();

            int user_id = global_reference.get_user_id();

            string[] s = new string[1000];
            MySqlDataReader read = null;
            string query = "SELECT P.first_name from datapptho.profile P where exists(select O.intent from datapptho.objective O where O.intent like \"%romance%\" and P.global_id = O.g_id) ";

            
            using (MySqlConnection con = new MySqlConnection(global_reference.get_sql_auth()))
            {
                using (MySqlCommand cmd = new MySqlCommand(query, con))
                {
                    con.Open();
                  
                     read = cmd.ExecuteReader();

                    int j = 0;
                    while (read.Read())
                    {
                        
                        //read.Read();
                        s[j] = read.GetValue(0).ToString();
                        System.Diagnostics.Debug.Write(read.GetValue(0).ToString());
                        j++;
                    }
                    
                    read.Close();

                }
          
            }//end of sql connection
               
                label2.Text = string.Join("\n", s);

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void matches_Load(object sender, EventArgs e)
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
