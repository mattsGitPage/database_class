using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatabaseClass
{
    public partial class Welcome : Form
    {
        public Welcome()
        {
            InitializeComponent();

            //ADD HAVING
            Global global_reference = Global.getInstance();
            using (MySqlConnection con = new MySqlConnection(global_reference.get_sql_auth()))
            {
                string query = "SELECT B.reason from datapptho.blacklist B group by B.reason having count(*) > 1";
                using (MySqlCommand cmd = new MySqlCommand(query, con))
                {
                    con.Open();
                    cmd.Parameters.AddWithValue("@global_id", global_reference.get_user_id());
                    MySqlDataReader read = cmd.ExecuteReader();


                    //asign values
                    read.Read();




                    try
                    {
                        this.lbl_ban.Text += read.GetValue(0).ToString();
                    }
                    catch (System.Exception eee)
                    {
                        Debug.WriteLine(eee.ToString());
                    }

                        //DEBUG
                    //  Debug.WriteLine((Int32)read.GetValue(0));



                    con.Close();
                }
            }
        }

        //login
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginPage lp = new LoginPage();
            lp.Show();

        }

        //create account
        private void button2_Click(object sender, EventArgs e)
        {
            UserInfo form = new UserInfo();
            this.Hide();
            form.Show();

        }
    }
}
