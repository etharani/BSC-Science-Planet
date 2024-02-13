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
        String fname = null;
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
            AddNew addnew=new AddNew();
            addnew.Show();
            this.Close();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            s.ShortView(dgv1);
         
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
            DataTable dt = s.SearchStudent(txtsearch.Text);
            dgv1.DataSource = dt;
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

        private void Reset()
        {

            this.id = null;
        }
        private void delete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.id))
            {
                MessageBox.Show("Please Double Click Data Grid Row!");
                return;
            }
            DialogResult dialogR = MessageBox.Show("Are you sure delete " + this.fname + " Details ?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (dialogR == DialogResult.Yes)
            {
                if (s.Delete(this.id))
                {
                    s.View(dgv1);
                    Reset();

                }
            }
        }

        private void btnPhysics_Click(object sender, EventArgs e)
        {
            PhysicsDetails physics = new PhysicsDetails();
            physics.Show();
            this.Hide();
        }

        private void engineer_Click(object sender, EventArgs e)
        {

        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you want to exit application?", "Exit Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)== DialogResult.Yes)
            {
                Application.Exit();
            }

        }

        private void btnbio_Click(object sender, EventArgs e)
        {
            BioDetails bio = new BioDetails();
            bio.Show();
            this.Hide();
        }

        private void btntech_Click(object sender, EventArgs e)
        {
            TechnologyDetails technology = new TechnologyDetails();
            technology.Show();
            this.Hide();
        }
    }
}
