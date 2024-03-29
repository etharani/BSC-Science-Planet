﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BScSciencePlanet.DAL
{
    public class Student
    {
        string connectionstring = "Server=DESKTOP-BCT8GR0;Database=BSC;User Id = sa; Password=thara4411;";
        public Boolean Create(String firstname, String lastname, String dateofbirth, String grade, String fathername, String fatherwork, String fatherphone, String mothername, String motherwork, String motherphone, String schoolname,String result, String address, String pattern,String subject)
        {
            try
            {
                SqlConnection con = new SqlConnection(connectionstring);
                ConnectionState state = con.State;
                if (state != ConnectionState.Open)
                {
                    con.Open();

                }
                SqlCommand cmd = new SqlCommand("insert into BScStudent(StudentFirstName,StudentLastName,DateOfBirth,Grade,FatherName,FatherWork,FatherPhoneNumber,MotherName,MotherWork,MotherPhoneNumber,SchoolName,ScholarshipResult,Address,ClassGoPattern,Subject) values('" + firstname + "','" + lastname + "','" + dateofbirth + "','" + grade + "','" + fathername + "','" + fatherwork + "','" + fatherphone + "','" + mothername + "','" + motherwork + "','" + motherphone + "','" + schoolname + "','"+ result + "','"+ address + "','"+ pattern + "','"+ subject + "')", con);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                con.Close();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
                return false;
                throw;

            }
        }

        public Boolean Update(String firstname, String lastname, String dateofbirth, String grade, String fathername, String fatherwork, String fatherphone, String mothername, String motherwork, String motherphone, String schoolname, String result, String address, String pattern,String subject ,String id)
        {
            try
            {
                SqlConnection con = new SqlConnection(connectionstring);
                ConnectionState state = con.State;
                if (state != ConnectionState.Open)
                {
                    con.Open();

                }
                SqlCommand cmd = new SqlCommand("update BScStudent set StudentFirstName ='" + firstname + "',StudentLastName ='" + lastname + "',DateOfBirth ='" + dateofbirth + "',Grade ='" + grade + "',FatherName ='" + fathername + "',FatherWork ='" + fatherwork + "',FatherPhoneNumber ='" + fatherphone + "',MotherName ='" + mothername + "',MotherWork ='" + motherwork + "',MotherPhoneNumber ='" + motherphone + "',SchoolName ='" + schoolname + "',ScholarshipResult ='" + result + "',Address = '" + address + "',ClassGoPattern ='" + pattern + "',Subject='"+subject+"' where ID='" + id + "' ", con);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                con.Close();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
                return false;
                throw;

            }
        }

        public Boolean Delete(String id)
        {
            try
            {
                SqlConnection con = new SqlConnection(connectionstring);
                ConnectionState state = con.State;
                if (state != ConnectionState.Open)
                {
                    con.Open();
                }
                SqlCommand cmd = new SqlCommand("delete from BScStudent where ID='" + id + " '", con);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                con.Close();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
                return false;
                throw;

            }
        }
        public void PhysicsView(DataGridView dgv)
        {
            try
            {
                SqlConnection con = new SqlConnection(connectionstring);
                using (con)
                {
                    SqlCommand cmd = new SqlCommand("select * from BScStudent where Subject='Physical Science'", con);
                    using (cmd)
                    {
                        ConnectionState state = con.State;
                        if (state != ConnectionState.Open)
                        {
                            con.Open();

                        }

                        DataTable dt = new DataTable();
                        dt.Load(cmd.ExecuteReader());
                        dgv.DataSource = dt;
                        con.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
                throw;

            }
            dgv.Columns["ID"].Visible = false;
        }

        public void BioView(DataGridView dgv)
        {
            try
            {
                SqlConnection con = new SqlConnection(connectionstring);
                using (con)
                {
                    SqlCommand cmd = new SqlCommand("select * from BScStudent where Subject='Biological Science'", con);
                    using (cmd)
                    {
                        ConnectionState state = con.State;
                        if (state != ConnectionState.Open)
                        {
                            con.Open();

                        }

                        DataTable dt = new DataTable();
                        dt.Load(cmd.ExecuteReader());
                        dgv.DataSource = dt;
                        con.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
                throw;

            }
            dgv.Columns["ID"].Visible = false;
        }

        public void TechView(DataGridView dgv)
        {
            try
            {
                SqlConnection con = new SqlConnection(connectionstring);
                using (con)
                {
                    SqlCommand cmd = new SqlCommand("select * from BScStudent where Subject='Technology'", con);
                    using (cmd)
                    {
                        ConnectionState state = con.State;
                        if (state != ConnectionState.Open)
                        {
                            con.Open();

                        }

                        DataTable dt = new DataTable();
                        dt.Load(cmd.ExecuteReader());
                        dgv.DataSource = dt;
                        con.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
                throw;

            }
            dgv.Columns["ID"].Visible = false;
        }

        public void View(DataGridView dgv)
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

                        DataTable dt = new DataTable();
                        dt.Load(cmd.ExecuteReader());
                        dgv.DataSource = dt;
                        con.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
                throw;

            }
            dgv.Columns["ID"].Visible = false;
        }

        public DataTable oneViewtablemethod(String id)
        {
            DataTable d = new DataTable();
            try
            {
                SqlConnection con = new SqlConnection(connectionstring);
                using (con)
                {

                    SqlCommand cmd = new SqlCommand("select * from BScStudent where ID ='" + id + "'", con);
                    using (cmd)
                    {
                        ConnectionState state = con.State;
                        if (state != ConnectionState.Open)
                        {
                            con.Open();

                        }


                        d.Load(cmd.ExecuteReader());
                        con.Close();
                        return d;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
                return null;
                throw;

            }

        }

        public DataTable AllViewtablemethod()
        {
            DataTable dt = new DataTable();
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


                        dt.Load(cmd.ExecuteReader());
                        con.Close();
                        return dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
                return null;
                throw;

            }

        }

        public DataTable SearchStudent(String searchname)
        {
            DataTable d = new DataTable();
            try
            {
                SqlConnection con = new SqlConnection(connectionstring);
                using (con)
                {
                    SqlCommand cmd = new SqlCommand("select * from BScStudent  where concat (StudentFirstName,StudentLastName,DateOfBirth,Grade,FatherName,FatherWork,FatherPhoneNumber,MotherName,MotherWork,MotherPhoneNumber,SchoolName,ScholarshipResult,Address,ClassGoPattern,Subject) like'%" + searchname + "%' ", con);
                    using (cmd)
                    {
                        ConnectionState state = con.State;
                        if (state != ConnectionState.Open)
                        {
                            con.Open();

                        }


                        d.Load(cmd.ExecuteReader());
                        con.Close();
                        return d;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
                return null;
                throw;

            }

        }

        public void ShortView(DataGridView dgv)
        {
            try
            {
                SqlConnection con = new SqlConnection(connectionstring);
                using (con)
                {
                    SqlCommand cmd = new SqlCommand("select ID,StudentFirstName,StudentLastName,Grade,Subject from BScStudent", con);
                    using (cmd)
                    {
                        ConnectionState state = con.State;
                        if (state != ConnectionState.Open)
                        {
                            con.Open();

                        }

                        DataTable dt = new DataTable();
                        dt.Load(cmd.ExecuteReader());
                        dgv.DataSource = dt;
                        con.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
                throw;

            }
            dgv.Columns["ID"].Visible = false;
        }
    }
}
