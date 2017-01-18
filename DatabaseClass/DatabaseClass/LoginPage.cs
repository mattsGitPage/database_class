using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace DatabaseClass
{
    public partial class LoginPage : Form
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //get hash of password
            HashAlgorithm sha = new SHA1CryptoServiceProvider();
            string pass1 = pass.Text.ToString();
            byte[] password = Encoding.ASCII.GetBytes(pass1);
            byte[] hashPass = sha.ComputeHash(password);

            //compare with hash in database
            //byte [] getDatabaseHash = 

            //if equal get profile information and send them to profile

            //else reject


        }
    }
}
