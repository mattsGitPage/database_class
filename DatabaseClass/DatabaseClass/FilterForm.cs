﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatabaseClass
{
    public partial class FilterForm : Form
    {
        Global G = Global.getInstance();
        public FilterForm()
        {
            InitializeComponent();
        }

        private void FilterForm_Load(object sender, EventArgs e)
        {

        }

        private void submit_Click(object sender, EventArgs e)
        {
           int id =  G.get_user_id();
           
              G.setMinAge(Convert.ToInt32((minage.Text.ToString())));
              G.setMaxAge(Convert.ToInt32(maxage.Text.ToString()));
            G.setLocation(location.Text.ToString());
            G.setIntent(intenttt.Text.ToString());
            if (maleb.Checked)
                G.setGender("male");
            else if (femaleb.Checked)
                G.setGender("female");
                

        }
    }
}
