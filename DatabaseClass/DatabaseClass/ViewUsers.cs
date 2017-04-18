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
    public partial class ViewUsers : Form
    {
        public ViewUsers()
        {
            InitializeComponent();
        }


        Global g = Global.getInstance();
        private void button1_Click_1(object sender, EventArgs e)
        {
         /*

            using (MySqlConnection con = new MySqlConnection("server=localhost; database=datapptho; user=group1; password=Password1"))
            {

                 string min_age = Convert.ToString(g.getMinAge());
                string max_age = Convert.ToString(g.getMaxAge());
                string intent = g.getIntent();
                string gen = g.getGender();

                string query = "select P.first_name, P.age, P.about_me, P.city , O.intent , I.interest from profile P, objective O, interests I where global_id= @global_id and I.global_interest_id = @global_id and O.g_id = @global_id and age >" + min_age+  " and age < " +max_age; //just add all the stuff to this query

                //TODO: qeury the users interests and find the ones the guy wants

                using (MySqlCommand cmd = new MySqlCommand(query, con))
                {
                    con.Open();
                    cmd.Parameters.AddWithValue("@global_id", 2); // this should change
                    MySqlDataReader read = cmd.ExecuteReader();


                    //asign values
                    if (read.Read())
                    {
                        first_name = (String)read.GetValue(0);
                        agee = (Int32)read.GetValue(1);
                        aboutMe = (String)read.GetValue(2);
                        city = (String)read.GetValue(3);
                        intent = (String)read.GetValue(4);
                        interest = (String)read.GetValue(5);
                    }

                    con.Close();
                }
            }
            //change the values on the profile for user to view
            name.Text = first_name;
            this.age.Text = agee.ToString();
            this.city.Text = city;
            boutme.Text = aboutMe;
            this.interest.Text = interest;
            this.intent.Text = intent;
            //TODO: add picture... box already on profile

            this.Hide();
            profile p = new profile();
            p.Show();
            this.Close(); */
        }

      

     
    
    
    
    }
}
