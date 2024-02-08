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
    public partial class Menu : Form
    {
        string connectionstring = "Server=DESKTOP-NMNKSVA;Database=BSC;User Id = sa; Password=thara4411;";
        public Menu()
        {
            InitializeComponent();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Showdetails_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(connectionstring);
                using (con)
                {
                    SqlCommand cmd = new SqlCommand("select * from BScStudent", con);
                    using (cmd)
                    {
                        ConnectionState state = con.State;
                        if (state != ConnectionState.Open)
                        {
                            con.Open();

                        }
                        //   con.Open();
                        DataTable dt = new DataTable();
                        dt.Load(cmd.ExecuteReader());
                        dgv1.DataSource = dt;
                        con.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
                throw;

            }
        }
    }
}
