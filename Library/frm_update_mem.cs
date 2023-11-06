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
    public partial class frm_update_mem : Form
    {
        public frm_update_mem()
        {
            InitializeComponent();
        }
        SqlConnection con;
        SqlCommand cmd;


        

        private void btn_exit_Click(object sender, EventArgs e)
        {
            DialogResult result;

            result = MessageBox.Show("Are you sure you want to exit?", "Exit confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            frm_menu obj = new frm_menu();
            obj.Show();
            this.Hide();
        }

        private void btn_cls_Click(object sender, EventArgs e)
        {
            txt_m_name.Text = "";
            txt_address.Text = "";
            cmb_div.Text = "";
            txt_contact.Text = "";
            

        }

        private void btn_update_mem_Click(object sender, EventArgs e)
        {

            try
            {

                if (txt_search.TextLength != 10)
                {
                    error_no_nic.SetError(txt_search, "Valid NIC number required");
                }

                else
                {
                    error_no_nic.Clear();

                    if (String.IsNullOrEmpty(txt_m_name.Text) || txt_m_name.Text.Any(c => Char.IsNumber(c)))
                    {
                        error_no_name.SetError(txt_m_name, "Member name required");


                        if (txt_address.TextLength <= 0)
                        {
                            error_no_add.SetError(txt_address, "Member address required");

                            if (cmb_div.SelectedIndex != 0 && cmb_div.SelectedIndex != 1)
                            {
                                error_no_gsd.SetError(cmb_div, "Division required");

                                if (txt_contact.TextLength != 10)
                                {
                                    error_no_cno.SetError(txt_contact, "Valid contact number required");
                                }

                            }


                            else
                            {
                                error_no_gsd.Clear();


                            }
                        }
                        else
                        {
                            error_no_add.Clear();

                        }
                    }





                    else
                    {
                        error_no_name.Clear();



                        if (txt_address.TextLength <= 0)
                        {
                            error_no_add.SetError(txt_address, "Member address required");

                            if (cmb_div.SelectedIndex != 0 && cmb_div.SelectedIndex != 1)
                            {
                                error_no_gsd.SetError(cmb_div, "Division required");
                            }




                            else
                            {
                                error_no_gsd.Clear();

                            }
                        }
                        else
                        {
                            error_no_add.Clear();



                            if (cmb_div.SelectedIndex != 0 && cmb_div.SelectedIndex != 1)
                            {
                                error_no_gsd.SetError(cmb_div, "Division required");



                            }
                            else
                            {
                                error_no_gsd.Clear();

                                if (txt_contact.TextLength != 10)
                                {
                                    error_no_cno.SetError(txt_contact, "Valid contact number required");
                                }
                                else
                                {

                                    error_no_cno.Clear();



                                    con.Open();
                                    cmd = new SqlCommand("Update member set Name = '" + txt_m_name.Text + "', Address = '" + txt_address.Text + "', Devision = '" + cmb_div.Text + "', ContactNo = '" + txt_contact.Text + "' where NICNo ='"+txt_search.Text+"'", con);

                                    cmd.ExecuteNonQuery();
                                    con.Close();

                                    MessageBox.Show("Details updated successfully", "Succeeded", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }



                            }
                        }
                    }
                    con.Close();

                }
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
        

        private void frm_update_mem_Load(object sender, EventArgs e)
        {
            try
            {
                con = new SqlConnection("Data Source=DESKTOP-GECQNKL;Initial Catalog=librarydb;Integrated Security=True");
                


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

        private void btn_search_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();

                if (txt_search.TextLength != 10)
                {
                    error_no_nic.SetError(txt_search, "NIC number required");
                }
                else
                {
                    error_no_nic.Clear();



                    cmd = new SqlCommand("select *from Member where NICNo = '" + txt_search.Text + "' ", con);
                    SqlDataReader dr = cmd.ExecuteReader();
                    dr.Read();

                    txt_m_name.Text = dr.GetValue(1).ToString();
                    txt_address.Text = dr.GetValue(2).ToString();
                    cmb_div.Text = dr.GetValue(3).ToString();
                    txt_contact.Text = dr.GetValue(4).ToString();
                    
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

        private void btn_clear_search_Click(object sender, EventArgs e)
        {
            txt_search.Text = "";
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
