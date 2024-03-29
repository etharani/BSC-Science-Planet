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
    public partial class BioDetails : Form
    {
        string connectionstring = "Server=DESKTOP-NMNKSVA;Database=BSC;User Id = sa; Password=thara4411;";
        DAL.Student biostu;
        String id = null;
        public BioDetails()
        {
            InitializeComponent();
            biostu = new DAL.Student();
        }

        private void BioDetails_Load(object sender, EventArgs e)
        {
            biostu.BioView(biodgv);
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you want to exit application?", "Exit Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btngomenu_Click(object sender, EventArgs e)
        {
            Menu menu1 = new Menu();
            menu1.Show();
            this.Close();
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            DataTable dt = biostu.SearchStudent(txtsearch.Text);
            biodgv.DataSource = dt;
        }
    }
}
