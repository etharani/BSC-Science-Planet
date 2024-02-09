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
        DAL.Student s;
        String id = null;
        public Menu()
        {
            InitializeComponent();
            s = new DAL.Student();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Showdetails_Click(object sender, EventArgs e)
        {
            Form1 addnew=new Form1();
            addnew.Show();
            this.Close();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            s.View(dgv1);
         
        }

        private void update_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.id))
            {
                MessageBox.Show("Please Double Click Data Grid Row!");
                return;
            }
            Update up = new Update(this.id, this.dgv1);
            up.ShowDialog();
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {

        }

        private void dgv1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                this.id = dgv1.SelectedRows[0].Cells["id"].Value.ToString();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());

            }

        }
    }
}
