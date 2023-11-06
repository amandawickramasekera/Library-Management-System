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
    public partial class return_book : Form
    {
        public return_book()
        {
            InitializeComponent();
        }
        SqlConnection con;
        SqlCommand cmd;
        SqlCommand cmd2;
        SqlDataAdapter da;

        private void button4_Click(object sender, EventArgs e)
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
            txt_book_isbn.Clear();
            txt_mem_nic.Clear();
            checkBox1.Checked = false;
        }

        private void btn_get_Click(object sender, EventArgs e)
        {
            try
            {
                con.Close();
                if (txt_mem_nic.TextLength != 10)
                {
                    error_nic.SetError(txt_mem_nic, "Valid NIC number required");

                    if (txt_book_isbn.TextLength <= 0)
                    {
                        error_isbn.SetError(txt_book_isbn, "Book ISBN required");

                        if (checkBox1.Checked == false)
                        {
                            error_check.SetError(checkBox1, "Please confirm that the book is recieved");
                        }
                        else
                        {
                            error_check.Clear();
                        }
                    }
                    else
                    {
                        error_isbn.Clear();

                    }
                }
                else
                {
                    error_nic.Clear();

                    if (txt_book_isbn.TextLength <= 0)
                    {
                        error_isbn.SetError(txt_book_isbn, "Book ISBN required");

                        if (checkBox1.Checked == false)
                        {
                            error_check.SetError(checkBox1, "Please confirm that the book is recieved");
                        }
                        else
                        {
                            error_check.Clear();
                        }
                    }
                    else
                    {
                        error_isbn.Clear();

                        if (checkBox1.Checked == false)
                        {
                            error_check.SetError(checkBox1, "Please confirm that the book is recieved");
                        }
                        else
                        {
                            error_check.Clear();

                            con.Open();
                            cmd = new SqlCommand("insert into borrow (NICNo, ISBN, Status, LUDate) values('" + txt_mem_nic.Text + "', '" + txt_book_isbn.Text + "', 'Recieved', '" + dateTimePicker1.Value + "')", con);

                            cmd.ExecuteNonQuery();

                            cmd2 = new SqlCommand("update book set Status = 'Available' where ISBN = '" + txt_book_isbn + "'", con);
                            cmd2.ExecuteNonQuery();
                            con.Close();

                            MessageBox.Show("Record inserted successfully", "Succeeded", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void return_book_Load(object sender, EventArgs e)
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
