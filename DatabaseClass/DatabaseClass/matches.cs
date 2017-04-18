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
            string query = "select first_name from datapptho.profile  ";
            using (MySqlConnection con = new MySqlConnection("server=localhost; database=datapptho; user=group1; password=Password1"))
            {
                using (MySqlCommand cmd = new MySqlCommand(query, con))
                {
                    con.Open();
                  
                     read = cmd.ExecuteReader();

                    int j = 0;
                    while (read.Read())
                    {
                        
                        read.Read();
                        s[j] = (string)read.GetValue(0);
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
