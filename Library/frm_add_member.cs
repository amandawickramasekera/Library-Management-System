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
    public partial class frm_add_member : Form
    {
        SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();

        public frm_add_member()
        {
            InitializeComponent();
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

        private void btn_back_Click(object sender, EventArgs e)
        {
            frm_menu obj = new frm_menu();
            obj.Show();
            this.Hide();
        }

        private void btn_cls_Click(object sender, EventArgs e)
        {
            txt_nic.Text = "";
            txt_m_name.Text = "";
            txt_address.Text = "";
            cmb_div.SelectedText = "";
            
            txt_contact.Text = "";

        }

        private void frm_add_member_Load(object sender, EventArgs e)
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

        private void btn_add_mem_Click(object sender, EventArgs e)
        {
            try
            {

                con.Close();

                if (txt_nic.TextLength != 10)
                {
                    error_nic.SetError(txt_nic, "Valid NIC number required");


                    if (txt_m_name.TextLength <= 0 || txt_m_name.Text.Any(c => Char.IsNumber(c)))
                    {
                        error_no_name.SetError(txt_m_name, "Member name required");

                        if (txt_address.TextLength <= 0)
                        {
                            error_no_address.SetError(txt_address, "Member address required");


                            if (cmb_div.SelectedIndex != 0 && cmb_div.SelectedIndex != 1)
                            {
                                error_no_div.SetError(cmb_div, "Devision required");

                                if (txt_contact.TextLength != 10)
                                {
                                    error_no_cno.SetError(txt_contact, "Valid contact number required");
                                }


                                else
                                {
                                    error_no_cno.Clear();
                                }
                            }
                            else
                            {
                                error_no_div.Clear();

                            }
                        }

                        else
                        {
                            error_no_address.Clear();


                        }
                    }
                    else
                    {
                        error_no_name.Clear();

                    }
                }
                else
                {
                    error_nic.Clear();











                    if (txt_m_name.TextLength <= 0 || txt_m_name.Text.Any(c => Char.IsNumber(c)))
                    {
                        error_no_name.SetError(txt_m_name, "Member name required");

                        if (txt_address.TextLength <= 0)
                        {
                            error_no_address.SetError(txt_address, "Member address required");



                            if (cmb_div.SelectedIndex != 0 && cmb_div.SelectedIndex != 1)
                            {
                                error_no_div.SetError(cmb_div, "Devision required");

                                if (txt_contact.TextLength != 10)
                                {
                                    error_no_cno.SetError(txt_contact, "Valid contact number required");
                                }
                                else
                                {
                                    error_no_cno.Clear();
                                }

                            }
                            else
                            {
                                error_no_div.Clear();
                            }
                        }

                        else
                        {
                            error_no_address.Clear();

                        }
                    }




                    else
                    {
                        error_no_name.Clear();

                        if (txt_address.TextLength <= 0)
                        {
                            error_no_address.SetError(txt_address, "Member address required");


                            if (cmb_div.SelectedIndex != 0 && cmb_div.SelectedIndex != 1)
                            {
                                error_no_div.SetError(cmb_div, "Division required");



                                if (txt_contact.TextLength != 10)
                                {
                                    error_no_cno.SetError(txt_contact, "Valid contact number required");

                                }
                                else
                                {
                                    error_no_cno.Clear();
                                }
                            }
                            else
                            {
                                error_no_div.Clear();
                            }

                        }





                        else
                        {
                            error_no_address.Clear();

                            if (cmb_div.SelectedIndex != 0 && cmb_div.SelectedIndex != 1)

                            {
                                error_no_div.SetError(cmb_div, "Division required");

                                if (txt_contact.TextLength != 10)
                                {
                                    error_no_cno.SetError(txt_contact, "Valid contact number required");
                                }
                                else
                                {
                                    error_no_cno.Clear();
                                }
                            }




                            else
                            {
                                error_no_div.Clear();

                                if (txt_contact.TextLength != 10)
                                {
                                    error_no_cno.SetError(txt_contact, "Valid contact number required");
                                }





                                else
                                {
                                    error_no_cno.Clear();






                                    con.Open();
                                    cmd = new SqlCommand("insert into Member(NICNo, Name, Address, Devision, ContactNo) values ('" + txt_nic.Text + "','" + txt_m_name.Text + "', '" + txt_address.Text + "', '" + cmb_div.Text + "' ,'" + txt_contact.Text + "')", con);
                                    cmd.ExecuteNonQuery();
                                    con.Close();

                                    MessageBox.Show("Data inserted successfully", "Succeeded", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }



                            }
                        }

                    }
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

        private void txt_contact_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}

    

