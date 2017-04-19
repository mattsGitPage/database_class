﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using DatabaseClass;

namespace DatabaseClass
{
    public partial class profile : Form
    {
        //local user data for quick reference
        Global global_reference = Global.getInstance();

        /*
         * on page load set up all the users information as he was to view his own profile
         * TODO figure out how to set up a browse function for all users
         */
        public profile()
        {
            InitializeComponent();

            //variables to be assigned
            string first_name = String.Empty;
            int agee = 0;
            string aboutMe = String.Empty;
            string city = String.Empty;
            string interest = String.Empty;
            string intent = String.Empty;

            Global global_reference = Global.getInstance();
            using (MySqlConnection con = new MySqlConnection(global_reference.get_sql_auth()))
            {
                string query = "select P.first_name, P.age, P.about_me, P.city , O.intent , I.interest from profile P, objective O, interests I where global_id= @global_id and I.global_interest_id = @global_id and O.g_id = @global_id";
                using (MySqlCommand cmd = new MySqlCommand(query, con))
                {
                    con.Open();
                    if (global_reference.getFlag())
                    {
                        //the user is browsing someone elses profile not their own
                        cmd.Parameters.AddWithValue("@global_id", global_reference.get_browse_id());
                        global_reference.setFlag(false);
                        // this.edit.Visible = false;
                        this.btn_like.Visible = true; 
                    }
                    else
                    {
                        //the user is viewing their own profile
                        cmd.Parameters.AddWithValue("@global_id", global_reference.get_user_id());
                        // this.edit.Visible = true;
                        this.btn_like.Visible = false; 
                    }
                    MySqlDataReader read =  cmd.ExecuteReader();

                   
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
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }


        private void home_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomePage h = new HomePage();
            h.Show();
            this.Close();

        }

        private void btn_like_Click(object sender, EventArgs e)
        {
            //add the person who's page this is to the matchlist of the current user.

            int currentUserId = global_reference.get_user_id();
            int currentBrowseID = global_reference.get_browse_id();

            using (MySqlConnection con = new MySqlConnection(global_reference.get_sql_auth()))
            {
                string query = "INSERT INTO match_list (glob_id, interested_in_id) VALUES (" + currentUserId + "," + currentBrowseID +");";
                using (MySqlCommand cmd = new MySqlCommand(query, con))
                {
                    con.Open();
                    try
                    {
                        cmd.ExecuteNonQuery();
                        con.Close();
                    }catch (System.Exception ee )
                    {
                        System.Diagnostics.Debug.Write(ee.ToString());
                    }
                }
            }
        }
    }
}
