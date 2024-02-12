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

namespace BScSciencePlanet
{
    public partial class Home : Form
    {
        string connectionstring = "";
        
        public Home()
        {
            InitializeComponent();
        }

        

        private void btnhome_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connectionstring);
            try
            {
                ConnectionState state = con.State;
                if (state != ConnectionState.Open)
                {
                    con.Open();
                    MessageBox.Show("Welcome to BSC Science Planet Connection");
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
            Menu homepage = new Menu();
            homepage.Show();
            this.Hide();
        }
    }
}
