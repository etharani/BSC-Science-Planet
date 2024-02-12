using System;
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
    
    public partial class PhysicsDetails : Form
    {
        string connectionstring = "Server=DESKTOP-NMNKSVA;Database=BSC;User Id = sa; Password=thara4411;";
        DAL.Student fullstu;
        String id = null;
        public PhysicsDetails()
        {
            InitializeComponent();
            fullstu = new DAL.Student();
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btngomenu_Click(object sender, EventArgs e)
        {
            Menu menu1 = new Menu();
            menu1.Show();
            this.Close();
        }

        private void PhysicsDetails_Load(object sender, EventArgs e)
        {
            fullstu.PhysicsView(physicsdgv);
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            DataTable dt = fullstu.SearchStudent(txtsearch.Text);
            physicsdgv.DataSource = dt;
        }
    }
}
