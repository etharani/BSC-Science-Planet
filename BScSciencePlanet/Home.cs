using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BScSciencePlanet
{
    public partial class Home : Form
    {
         string connectionstring = "Server=DESKTOP-BCT8GR0;Database=BSC;User Id = sa; Password=thara4411;";
       // string connectionstring = ConfigurationManager.ConnectionStrings["connectionStrings"].ConnectionString;
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
