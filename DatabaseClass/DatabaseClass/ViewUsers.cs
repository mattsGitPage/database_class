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


        Global global_reference = Global.getInstance();
        private void button1_Click_1(object sender, EventArgs e)
        {

            //if user set a filter use this
            if (global_reference.getFilter())
            {
                //global_reference.ClearList();
                using (MySqlConnection con = new MySqlConnection("server=localhost; database=datapptho; user=group1; password=Password1"))
                {
                    string query = "select global_id from profile P, objective O,  where global_id = O.g_id and city like \"% " + global_reference.getlocation() + "%\"" + " and age >= " + global_reference.getMinAge() + " age <= " + global_reference.getMaxAge() + "and intent  like \"% " + global_reference.getIntent() + "%\"" + " and gender = " + global_reference.getGender();
                    using (MySqlCommand cmd = new MySqlCommand(query, con))
                    {
                        con.Open();
                        // a new query needs to be ran to get this id 

                        MySqlDataReader read = cmd.ExecuteReader();
                        //asign values
                        if (read.Read())
                        {

                            global_reference.set_user_id((Int32)read.GetValue(0));
                           
                        }
                        con.Close();
                    }
                }
            }
            else
            {

                using (MySqlConnection con = new MySqlConnection("server=localhost; database=datapptho; user=group1; password=Password1"))
                {
                    

                    string query = "select P.first_name, P.age, P.about_me, P.city , O.intent , I.interest from profile P, objective O, interests I where global_id= @global_id and I.global_interest_id = @global_id and O.g_id = @global_id "; 

                    //TODO: qeury the users interests and find the ones the guy wants

                    using (MySqlCommand cmd = new MySqlCommand(query, con))
                    {
                        con.Open();
                        cmd.Parameters.AddWithValue("@global_id", global_reference.getCounter()); // this should change
                        //then incrememnt the counter for the next profile
                        global_reference.setCounter(global_reference.getCounter() + 1);
                        MySqlDataReader read = cmd.ExecuteReader();


                        //asign values
                        if (read.Read())
                        {
                            global_reference.setOtheruserId((Int32)read.GetValue(0));
                            
                        }

                        con.Close();
                    }
                }
           

                this.Hide();
                profile p = new profile();
                p.Show();
                this.Close();



            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            //if user set a filter use this
            if (global_reference.getFilter())
            {
                //global_reference.ClearList();
                using (MySqlConnection con = new MySqlConnection("server=localhost; database=datapptho; user=group1; password=Password1"))
                {
                    string query = "select global_id from profile P, objective O,  where global_id = O.g_id and city like \"% " + global_reference.getlocation() + "%\"" + " and age >= " + global_reference.getMinAge() + " age <= " + global_reference.getMaxAge() + "and intent  like \"% " + global_reference.getIntent() + "%\"" + " and gender = " + global_reference.getGender();
                    using (MySqlCommand cmd = new MySqlCommand(query, con))
                    {
                        con.Open();
                        // a new query needs to be ran to get this id 

                        MySqlDataReader read = cmd.ExecuteReader();
                        //asign values
                        if (read.Read())
                        {

                            global_reference.set_user_id((Int32)read.GetValue(0));

                        }
                        con.Close();
                    }
                }
            }
            else
            {

                using (MySqlConnection con = new MySqlConnection("server=localhost; database=datapptho; user=group1; password=Password1"))
                {


                    string query = "select P.first_name, P.age, P.about_me, P.city , O.intent , I.interest from profile P, objective O, interests I where global_id= @global_id and I.global_interest_id = @global_id and O.g_id = @global_id ";

                    //TODO: qeury the users interests and find the ones the guy wants

                    using (MySqlCommand cmd = new MySqlCommand(query, con))
                    {
                        con.Open();
                        cmd.Parameters.AddWithValue("@global_id", global_reference.getCounter()); // this should change
                        //then incrememnt the counter for the next profile
                        global_reference.setCounter(global_reference.getCounter() + 1);
                        MySqlDataReader read = cmd.ExecuteReader();


                        //asign values
                        if (read.Read())
                        {
                            global_reference.setOtheruserId((Int32)read.GetValue(0));

                        }

                        con.Close();
                    }
                }


                this.Hide();
                profile p = new profile();
                p.Show();
                this.Close();



            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            //if user set a filter use this
            if (global_reference.getFilter())
            {
                //global_reference.ClearList();
                using (MySqlConnection con = new MySqlConnection("server=localhost; database=datapptho; user=group1; password=Password1"))
                {
                    string query = "select global_id from profile P, objective O,  where global_id = O.g_id and city like \"% " + global_reference.getlocation() + "%\"" + " and age >= " + global_reference.getMinAge() + " age <= " + global_reference.getMaxAge() + "and intent  like \"% " + global_reference.getIntent() + "%\"" + " and gender = " + global_reference.getGender();
                    using (MySqlCommand cmd = new MySqlCommand(query, con))
                    {
                        con.Open();
                        // a new query needs to be ran to get this id 

                        MySqlDataReader read = cmd.ExecuteReader();
                        //asign values
                       
                        while (read.Read()  )
                        {
                            global_reference.set_user_id((Int32)read.GetValue(0));
                            
                        }
                        con.Close();
                    }
                }
            }
            else
            {

                using (MySqlConnection con = new MySqlConnection("server=localhost; database=datapptho; user=group1; password=Password1"))
                {


                    string query = "select P.first_name, P.age, P.about_me, P.city , O.intent , I.interest from profile P, objective O, interests I where global_id= @global_id and I.global_interest_id = @global_id and O.g_id = @global_id ";

                    //TODO: qeury the users interests and find the ones the guy wants

                    using (MySqlCommand cmd = new MySqlCommand(query, con))
                    {
                        con.Open();
                        cmd.Parameters.AddWithValue("@global_id", global_reference.getCounter()); // this should change
                        //then incrememnt the counter for the next profile
                        global_reference.setCounter(global_reference.getCounter() + 1);
                        MySqlDataReader read = cmd.ExecuteReader();


                        //asign values
                        if (read.Read())
                        {
                            global_reference.setOtheruserId((Int32)read.GetValue(0));

                        }

                        con.Close();
                    }
                }


                this.Hide();
                profile p = new profile();
                p.Show();
                this.Close();



            }
        }
    }
}
