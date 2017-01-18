using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatabaseClass
{
    public partial class upgrade : Form
    {
        public upgrade()
        {
            InitializeComponent();
        }

        //user upgraded account 
        //TODO add new features with this
        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-MKRJETA;Initial Catalog=date_app;Integrated Security=True"))
            {
                string query = "insert into user_create_profile (user_upgraded) values (@user_upgraded)";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    con.Open();
                    cmd.Parameters.AddWithValue("@user_upgraded", 1);
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
            }
        }
    }
}
