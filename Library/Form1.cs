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
            
            
            
            InitializeComponent();
        }



        private void btn_login_Click(object sender, EventArgs e)
        {


            try {



                if (txt_id.TextLength <= 0)
                {
                    error_no_id.SetError(txt_id, "User ID required");

                    if (txt_pwd.TextLength <= 0)
                    {
                        error_no_pwd.SetError(txt_pwd, "Password required");
                    }
                    else
                    {
                        error_no_pwd.Clear();
                    }

                }
                else
                {
                    error_no_id.Clear();

                    if (txt_pwd.TextLength <= 0)
                    {
                        error_no_pwd.SetError(txt_pwd, "Password required");
                    }
                    else

                    {
                        error_no_pwd.Clear();

                        con = new SqlConnection("Data Source=DESKTOP-GECQNKL;Initial Catalog=librarydb;Integrated Security=True");

                        con.Open();

                        string al_id = txt_id.Text;
                        string al_pwd = txt_pwd.Text;
                        cmd = new SqlCommand("select ALID, Password from AssistantLibrarian where ALID = '" + txt_id.Text + "' and Password= '" + txt_pwd.Text + "'", con);
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        if (dt.Rows.Count > 0)
                        {
                            frm_menu obj = new frm_menu();
                            obj.Show();
                            this.Hide();

                        }



                        else
                        {

                            MessageBox.Show("Invalid ID or password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }




                    }
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

                con = new SqlConnection("Data Source=laptop-kkhpluo9;Initial Catalog=librarydb;Integrated Security=True");

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

        private void btn_cls_Click(object sender, EventArgs e)
        {
            txt_id.Clear();
            txt_pwd.Clear();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            DialogResult result;

            result = MessageBox.Show("Are you sure you want to exit?", "Exit confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void frm_login_Load_1(object sender, EventArgs e)
        {

        }
    }
    }


