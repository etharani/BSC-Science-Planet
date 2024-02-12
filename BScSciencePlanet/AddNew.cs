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
    public partial class AddNew : Form
    {
        
        DAL.Student student;
        String id = null;
        String subject = null;
        public AddNew()
        {
            InitializeComponent();
            student = new DAL.Student();
        }

        private void StudentFirstName_Click(object sender, EventArgs e)
        {

        }

        private Boolean Validation()
        {
            if (string.IsNullOrEmpty(txtfirstname.Text))
            {
                MessageBox.Show("Enter First Name");
                txtfirstname.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtlastname.Text))
            {
                MessageBox.Show("Enter Last Name");
                txtlastname.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtbirth.Text))
            {
                MessageBox.Show("Enter Date of birth");
                txtbirth.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtgrade.Text))
            {
                MessageBox.Show("Enter Grade");
                txtgrade.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtfathername.Text))
            {
                MessageBox.Show("Enter Father name");
                txtfathername.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtfatherwork.Text))
            {
                MessageBox.Show("Enter Father work");
                txtfatherwork.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtfatherphone.Text))
            {
                MessageBox.Show("Enter Father phone number");
                txtfatherphone.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtmothername.Text))
            {
                MessageBox.Show("Enter Mother name");
                txtmothername.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtmotherwork.Text))
            {
                MessageBox.Show("Enter Mother work");
                txtmotherwork.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtmotherphone.Text))
            {
                MessageBox.Show("Enter Mother phone number");
                txtmotherphone.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtschoolname.Text))
            {
                MessageBox.Show("Enter School name");
                txtschoolname.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtresult.Text))
            {
                MessageBox.Show("Enter Scholarship result");
                txtresult.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtaddress.Text))
            {
                MessageBox.Show("Enter Address");
                txtaddress.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtclass.Text))
            {
                MessageBox.Show("Enter Class go pattern");
                txtclass.Focus();
                return false;
            }
            return true;
        }

        private void Reset()
        {
            txtfirstname.Text = "";
            txtlastname.Text = "";
            txtbirth.Text = "";
            txtgrade.Text = "";
            txtfathername.Text = "";
            txtfatherwork.Text = "";
            txtfatherphone.Text = "";
            txtmothername.Text = "";
            txtmotherphone.Text = "";
            txtmotherwork.Text = "";
            txtschoolname.Text = "";
            txtresult.Text = "";
            txtaddress.Text = "";
            txtclass.Text = "";
            this.id = null;
        }
        private void btnsave_Click(object sender, EventArgs e)
        {
            if (Validation())
            {
                if (rdbPhysice.Checked)
                {
                    this.subject = "Physical Science";
                }
                if (rdbbio.Checked)
                {
                    this.subject = "Biological Science";
                }
                if (rdbtech.Checked)
                {
                    this.subject = "Technology";
                }
                if (student.Create(txtfirstname.Text, txtlastname.Text, txtbirth.Text,txtgrade.Text, txtfathername.Text, txtfatherwork.Text, txtfatherphone.Text,txtmothername.Text, txtmotherwork.Text, txtmotherphone.Text, txtschoolname.Text, txtresult.Text, txtaddress.Text, txtclass.Text,this.subject))
                {
                  
                    Reset();
                    DialogResult dialogR = MessageBox.Show("Add other student details?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                    Reset();
                    if (dialogR == DialogResult.No)
                    {
                        this.Close();
                    }

                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btngomenu_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Close();
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
