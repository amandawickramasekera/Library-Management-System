using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Library
{
    public partial class frm_login : Form
    {
        SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        public frm_login()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=DESKTOP-GECQNKL;Initial Catalog=Attendance;Integrated Security=True";
            
            InitializeComponent();
        }

        private void txt_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            try
            {

                con.Open();


                if (cmb_acctype.SelectedIndex == 0)
                {
                    error_notype.Clear();
                    if (txt_uid.TextLength <= 0)
                    {
                        error_noid.SetError(txt_uid, "User ID required");

                        if (txt_pwd.TextLength <= 0)
                        {
                            error_nopwd.SetError(txt_pwd, "Password required");
                        }
                        else
                        {
                            error_nopwd.Clear();
                        }

                    }
                    else
                    {
                        error_noid.Clear();

                        if (txt_pwd.TextLength <= 0)
                        {
                            error_nopwd.SetError(txt_pwd, "Password required");
                        }
                        else

                        {
                            error_nopwd.Clear();

                            string admin_id = txt_uid.Text;
                            string admin_pwd = txt_pwd.Text;
                            cmd = new SqlCommand("select admin_id, admin_pwd from admin where admin_id = '" + txt_uid.Text + "' and admin_pwd= '" + txt_pwd.Text + "'", con);
                            SqlDataAdapter da = new SqlDataAdapter(cmd);
                            DataTable dt = new DataTable();
                            da.Fill(dt);
                            if (dt.Rows.Count > 0)
                            {
                                frm_admins_menu obj = new frm_admins_menu();
                                obj.Show();
                                this.Hide();

                            }



                            else
                            {

                                MessageBox.Show("Invalid user ID or password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }




                        }
                    }
                }


                else if (cmb_acctype.SelectedIndex == 1)
                {
                    error_notype.Clear();
                    if (txt_uid.TextLength <= 0)
                    {
                        error_noid.SetError(txt_uid, "User ID required");

                        if (txt_pwd.TextLength <= 0)
                        {
                            error_nopwd.SetError(txt_pwd, "Password required");
                        }
                        else
                        {
                            error_nopwd.Clear();
                        }

                    }
                    else
                    {
                        error_noid.Clear();

                        if (txt_pwd.TextLength <= 0)
                        {
                            error_nopwd.SetError(txt_pwd, "Password required");
                        }
                        else

                        {
                            error_nopwd.Clear();

                            string emp_id = txt_uid.Text;
                            string emp_pwd = txt_pwd.Text;
                            SqlCommand cmd = new SqlCommand("select emp_id, emp_pwd from employee where emp_id='" + txt_uid.Text + "' and emp_pwd ='" + txt_pwd + "'", con);
                            SqlDataAdapter da = new SqlDataAdapter(cmd);
                            DataTable dt = new DataTable();
                            da.Fill(dt);

                            if (dt.Rows.Count > 0)
                            {
                                frm_emps_menu obj = new frm_emps_menu();
                                obj.Show();
                                this.Hide();
                            }
                            else
                            {

                                MessageBox.Show("Invalid user ID or password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }


                else
                {
                    error_notype.SetError(cmb_acctype, "Account type required");
                }
                con.Close();


            }
            catch (SqlException)
            {
                MessageBox.Show("Please try again", "Database error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            {
                MessageBox.Show("Please check again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }




        private void frm_login_Load(object sender, EventArgs e)
        {
            try
            {
                con = new SqlConnection("Data Source=DESKTOP-GECQNKL;Initial Catalog=Attendance;Integrated Security=True");


            }
            catch (SqlException)
            {
                MessageBox.Show("Please try again", "Database error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            {
                MessageBox.Show("Please check again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
    }
}
