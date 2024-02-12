﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BScSciencePlanet
{
    public partial class TechnologyDetails : Form
    {
        string connectionstring = "";
        DAL.Student techstu;
        String id = null;
        public TechnologyDetails()
        {
            InitializeComponent();
            techstu = new DAL.Student();
        }

        private void btngomenu_Click(object sender, EventArgs e)
        {
            Menu menu1 = new Menu();
            menu1.Show();
            this.Close();
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            DataTable dt = techstu.SearchStudent(txtsearch.Text);
            techdgv.DataSource = dt;
        }

        private void TechnologyDetails_Load(object sender, EventArgs e)
        {
            techstu.TechView(techdgv);
        }
    }
}