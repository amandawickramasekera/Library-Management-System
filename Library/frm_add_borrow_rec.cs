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
    
    public partial class frm_add_borrow_rec : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlCommand cmd2;
        SqlDataAdapter da;

        public frm_add_borrow_rec()
        {
            InitializeComponent();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            
                
                
            
        }

        private void frm_add_borrow_rec_Load(object sender, EventArgs e)
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

        private void btn_search_member_Click(object sender, EventArgs e)
        {
            try
            {
                error_no_isbn.Clear();
                if (txt_nic.TextLength !=10)
                {
                    error_no_nic.SetError(txt_nic, "Valid NIC number required to search");
                }
                else
                {
                    error_no_nic.Clear();

                    con.Open();
                    da = new SqlDataAdapter("select*from Member where NICNo = '" + txt_nic.Text + "'", con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    con.Close();
                    dataGridView1.DataSource = dt;
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

        private void btn_search_book_Click(object sender, EventArgs e)
        {
            try
            {
                error_no_nic.Clear();
                if (txt_isbn.TextLength <= 0)
                {
                    error_no_isbn.SetError(txt_isbn, "ISBN required to search");
                }
                else
                {
                    error_no_isbn.Clear();

                    con.Open();
                    da = new SqlDataAdapter("select*from Book where ISBN = '" + txt_isbn.Text + "'", con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    con.Close();
                    dataGridView1.DataSource = dt;
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

        private void btn_cls_search_Click(object sender, EventArgs e)
        {
            txt_isbn.Text = "";
            txt_nic.Text = "";
            
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

        private void btn__Click(object sender, EventArgs e)
        {
            try
            {
                con.Close();
                if (txt_mem_nic.TextLength != 10)
                {
                    errorProvider1.SetError(txt_mem_nic, "Valid NIC number required to issue");

                    if (txt_book_isbn.TextLength <= 0)
                    {
                        errorProvider2.SetError(txt_book_isbn, "ISBN required to issue");
                    }
                    else
                    {
                        errorProvider2.Clear();
                    }
                }
                else
                {
                    errorProvider1.Clear();

                    if (txt_book_isbn.TextLength <= 0)
                    {
                        errorProvider2.SetError(txt_book_isbn, "ISBN required to issue");
                    }
                    else
                    {
                        errorProvider2.Clear();


                        con.Open();
                        cmd = new SqlCommand("insert into borrow (NICNo, ISBN, Status, LUDate) values('" + txt_mem_nic.Text + "', '" + txt_book_isbn.Text + "', 'Taken', '" + dateTimePicker1.Value + "')", con);

                        cmd.ExecuteNonQuery();

                        cmd2 = new SqlCommand("update Book set Status = 'Taken' where ISBN = '" + txt_book_isbn + "'", con);
                        cmd2.ExecuteNonQuery();
                        con.Close();

                        MessageBox.Show("Record inserted successfully", "Succeeded", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void btn_cls_Click(object sender, EventArgs e)
        {
            txt_book_isbn.Clear();
            txt_mem_nic.Clear();
        }

        private void btb_change_status_Click(object sender, EventArgs e)
        {

        }
    }
}
