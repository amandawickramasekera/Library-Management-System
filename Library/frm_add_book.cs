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
    public partial class frm_add_book : Form
    {
        public frm_add_book()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();

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
            txt_ISBN.Text = "";
            txt_title.Text = "";
            txt_author.Text = "";
            txt_pub.Text = "";
            cmb_status.SelectedText = "";

        }

        private void btn_add_book_Click(object sender, EventArgs e)
        {
            try
            {
                con.Close();



                if (String.IsNullOrEmpty(txt_ISBN.Text))
                {
                    error_no_isbn.SetError(txt_ISBN, "ISBN required");


                    if (txt_title.TextLength <= 0)
                    {
                        error_no_title.SetError(txt_title, "Book title required");

                        if (txt_author.TextLength <= 0)
                        {
                            error_no_author.SetError(txt_author, "Author name required");


                            if (txt_pub.TextLength <= 0)
                            {
                                error_no_pub.SetError(txt_pub, "Publisher required");
                                if (cmb_status.SelectedIndex != 0 && cmb_status.SelectedIndex != 1)
                                {
                                    error_no_status.SetError(cmb_status, "Book status required");
                                }
                                else
                                {
                                    error_no_status.Clear();
                                }
                            }
                            else
                            {
                                error_no_pub.Clear();
                            }
                        }


                        else
                        {
                            error_no_author.Clear();


                        }
                    }
                    else
                    {
                        error_no_title.Clear();

                    }
                }





                else
                {
                    error_no_isbn.Clear();



                    if (txt_title.TextLength <= 0)
                    {
                        error_no_title.SetError(txt_title, "Book title required");

                        if (txt_author.TextLength <= 0)
                        {
                            error_no_author.SetError(txt_author, "Author name required");



                            if (txt_pub.TextLength <= 0)
                            {
                                error_no_pub.SetError(txt_pub, "Publisher required");

                                if (cmb_status.SelectedIndex != 0 && cmb_status.SelectedIndex != 1)
                                {
                                    error_no_status.SetError(cmb_status, "Book status required");
                                }
                                else
                                {
                                    error_no_status.Clear();
                                }

                            }
                            else
                            {
                                error_no_pub.Clear();

                            }
                        }

                        else
                        {
                            error_no_author.Clear();

                        }
                    }
                    else
                    {
                        error_no_title.Clear();



                        if (txt_author.TextLength <= 0)
                        {
                            error_no_author.SetError(txt_author, "Author name required");



                            if (txt_pub.TextLength <= 0)
                            {
                                error_no_pub.SetError(txt_pub, "Publisher required");

                            }
                            else
                            {
                                error_no_pub.Clear();
                                if (cmb_status.SelectedIndex != 0 && cmb_status.SelectedIndex != 1)
                                {
                                    error_no_status.SetError(cmb_status, "Book status required");
                                }
                                else
                                {
                                    error_no_status.Clear();
                                }
                            }
                        }
                        else
                        {
                            error_no_author.Clear();




                            if (txt_pub.TextLength <= 0)
                            {
                                error_no_pub.SetError(txt_pub, "Publisher required");

                                if (cmb_status.SelectedIndex != 0 && cmb_status.SelectedIndex != 1)
                                {
                                    error_no_status.SetError(cmb_status, "Book status required");
                                }
                                else
                                {
                                    error_no_status.Clear();
                                }

                            }
                            else
                            {
                                error_no_pub.Clear();

                                if (cmb_status.SelectedIndex != 0 && cmb_status.SelectedIndex != 1)
                                {
                                    error_no_status.SetError(cmb_status, "Book status required");
                                }
                                else
                                {
                                    error_no_status.Clear();


                                    con.Open();
                                    cmd = new SqlCommand("insert into Book(ISBN, Title, Author, Publisher, Status) values ('" + txt_ISBN.Text + "', '" + txt_title.Text + "', '" + txt_author.Text + "' ,'" + txt_pub.Text + "', '" + cmb_status.Text + "')", con);
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


        private void frm_add_book_Load(object sender, EventArgs e)
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
    }
}

