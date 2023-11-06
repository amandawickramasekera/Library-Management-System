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
    public partial class add_fine_rec : Form
    {
        public add_fine_rec()
        {
            InitializeComponent();
        }
        SqlConnection con;
        SqlCommand cmd;
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
            txt_fno.Clear();
            txt_nic.Clear();
            txt_amt.Clear();
        }

        private void btn_insert_Click(object sender, EventArgs e)
        {
            try
            {
                con.Close();
                if (txt_fno.TextLength <= 0)
                {
                    error_no_fno.SetError(txt_fno, "Fine code required");

                    if (txt_nic.TextLength != 10)
                    {
                        error_no_nic.SetError(txt_nic, "Valid NIC number required");

                        if (txt_amt.TextLength <= 0)
                        {
                            errorProvider1.SetError(txt_amt, "Fine amount reqired");

                        }
                        else
                        {
                            errorProvider1.Clear();
                        }
                    }
                    else
                    {
                        error_no_nic.Clear();



                    }

                }
                else
                {
                    error_no_fno.Clear();

                    if (txt_nic.TextLength != 10)
                    {
                        error_no_nic.SetError(txt_nic, "Valid NIC number required");

                        if (txt_amt.TextLength <= 0)
                        {
                            errorProvider1.SetError(txt_amt, "Fine amount reqired");
                        }
                        else
                        {
                            errorProvider1.Clear();

                        }
                    }
                    else
                    {
                        error_no_nic.Clear();

                        if (txt_amt.TextLength <= 0)
                        {
                            errorProvider1.SetError(txt_amt, "Fine amount reqired");
                        }
                        else
                        {

                            errorProvider1.Clear();

                            con.Open();
                            cmd = new SqlCommand("insert into Fine(FineNo, NICNo, Amount, Status, luDate) values ('" + txt_fno.Text + "','" + txt_nic.Text + "', "+txt_amt.Text+", 'Not Paid', '"+dateTimePicker1.Value+"')", con);
                            cmd.ExecuteNonQuery();
                            con.Close();

                            MessageBox.Show("Data inserted successfully", "Succeeded", MessageBoxButtons.OK, MessageBoxIcon.Information);

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

        private void add_fine_rec_Load(object sender, EventArgs e)
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
