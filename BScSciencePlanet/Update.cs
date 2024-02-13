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
        DAL.Student stu;
        String id = null;
        DataGridView mdatagv;
        String subject;
        public Update(String id, DataGridView datagv)
        {
            InitializeComponent();
            this.id = id;
            this.mdatagv = datagv; 
            stu = new DAL.Student();
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

        private void btngomenu_Click(object sender, EventArgs e)
        {
            Menu menu1 = new Menu();
            menu1.Show();
            this.Close();
        }

        private void btnupdate_Click(object sender, EventArgs e)
        { 
            if (string.IsNullOrEmpty(this.id))
            {
                MessageBox.Show("Please Double Click Data Grid Row!");
                return;
            }
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
                if (stu.Update(txtfirstname.Text, txtlastname.Text, txtbirth.Text, txtgrade.Text, txtfathername.Text, txtfatherwork.Text, txtfatherphone.Text, txtmothername.Text, txtmotherwork.Text, txtmotherphone.Text, txtschoolname.Text, txtresult.Text, txtaddress.Text, txtclass.Text,this.subject, this.id))
                {
                    DataTable t = stu.AllViewtablemethod();
                    this.mdatagv.DataSource = t;

                    DialogResult dialogR = MessageBox.Show("Is the edit task completed ?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                    if (dialogR == DialogResult.Yes)
                    {   
                        Reset();
                        this.Close();
                    }

                }
            }
        }

        private void Update_Load(object sender, EventArgs e)
        {

            DataTable dtstudent = stu.oneViewtablemethod(this.id);
            txtfirstname.Text = dtstudent.Rows[0]["StudentFirstName"].ToString();
            txtlastname.Text = dtstudent.Rows[0]["StudentLastName"].ToString();
            txtbirth.Text = dtstudent.Rows[0]["DateOfBirth"].ToString();
            txtgrade.Text = dtstudent.Rows[0]["Grade"].ToString();
            txtfathername.Text = dtstudent.Rows[0]["FatherName"].ToString();
            txtfatherwork.Text = dtstudent.Rows[0]["FatherWork"].ToString();
            txtfatherphone.Text = dtstudent.Rows[0]["FatherPhoneNumber"].ToString();
            txtmothername.Text = dtstudent.Rows[0]["MotherName"].ToString();
            txtmotherwork.Text = dtstudent.Rows[0]["MotherWork"].ToString();
            txtmotherphone.Text = dtstudent.Rows[0]["MotherPhoneNumber"].ToString();
            txtschoolname.Text = dtstudent.Rows[0]["SchoolName"].ToString();
            txtresult.Text = dtstudent.Rows[0]["ScholarshipResult"].ToString();
            txtaddress.Text = dtstudent.Rows[0]["Address"].ToString();
            txtclass.Text = dtstudent.Rows[0]["ClassGoPattern"].ToString();
            this.subject = dtstudent.Rows[0]["Subject"].ToString();
            if (subject == "Physical Science")
            {
                rdbPhysice.Checked = true;
            }
            if (subject == "Biological Science")
            {
                rdbbio.Checked = true;
            }
            if (subject == "Technology")
            {
                rdbtech.Checked = true;
            }

        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you want to exit application?", "Exit Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
