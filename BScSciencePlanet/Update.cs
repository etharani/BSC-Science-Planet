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
    public partial class Update : Form
    {
        public Update()
        {
            InitializeComponent();
        }

        private void btngomenu_Click(object sender, EventArgs e)
        {
            Menu menu1 = new Menu();
            menu1.Show();
            this.Close();
        }
    }
}
