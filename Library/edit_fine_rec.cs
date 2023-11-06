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
using System.Drawing.Printing;

namespace Library
{
    public partial class edit_fine_rec : Form
    {
        public edit_fine_rec()
        {
            InitializeComponent();
        }
        SqlConnection con;
        SqlCommand cmd;

        SqlDataAdapter da;

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
            txt_fno.Text = "";
            txt_nic.Text = "";
            checkBox1.Checked = false;
            txt_amt.Clear();
        }

        private void edit_fine_rec_Load(object sender, EventArgs e)
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

        private void btn_update_Click(object sender, EventArgs e)
        {
            try
            {

                if (txt_fno.TextLength <= 0)
                {
                    error_fno.SetError(txt_fno, "Fine code required");

                    if (txt_nic.TextLength != 10)
                    {
                        error_nic.SetError(txt_nic, "Valid NIC number required");
                        if (txt_amt.TextLength <= 0)
                        {
                            errorProvider1.SetError(txt_amt, "Enter total fine amount");


                            if (checkBox1.Checked == false)
                            {
                                error_check.SetError(checkBox1, "Please confirm that fine is paied");
                            }
                            else
                            {
                                error_check.Clear();
                            }
                        }
                        else
                        {
                            errorProvider1.Clear();
                        }
                    }
                    else
                    {
                        error_nic.Clear();



                    }

                }
                else
                {
                    error_fno.Clear();

                    if (txt_nic.TextLength != 10)
                    {
                        error_nic.SetError(txt_nic, "Valid NIC number required");
                        if (txt_amt.TextLength <= 0)
                        {
                            errorProvider1.SetError(txt_amt, "Enter total fine amount");

                            if (checkBox1.Checked == false)
                            {
                                error_check.SetError(checkBox1, "Please confirm that fine is paied");

                            }
                            else
                            {
                                error_check.Clear();

                            }
                        }
                        errorProvider1.Clear();
                    }
                    else
                    {
                        error_nic.Clear();
                        if (txt_amt.TextLength <= 0)
                        {
                            errorProvider1.SetError(txt_amt, "Enter total fine amount");
                        }
                        else
                        {
                            errorProvider1.Clear();


                            if (checkBox1.Checked == false)
                            {
                                error_check.SetError(checkBox1, "Please confirm that fine is paid");
                            }
                            else
                            {
                                error_check.Clear();
                            }
                        }
                        if (txt_amt.TextLength <= 0)
                        {

                            errorProvider1.SetError(txt_amt, "Enter total fine amount");

                            if (checkBox1.Checked == false)
                            {
                                error_check.SetError(checkBox1, "Please confirm that fine is paid");
                            }
                            else
                            {
                                error_check.Clear();
                            }

                        }
                        else
                        {
                            errorProvider1.Clear();

                            if (checkBox1.Checked == false)
                            {
                                error_check.SetError(checkBox1, "Please confirm that fine is paid");
                            }
                            else
                            {
                                error_check.Clear();
                                con = new SqlConnection("Data Source=DESKTOP-GECQNKL;Initial Catalog=librarydb;Integrated Security=True");
                                con.Open();
                                cmd = new SqlCommand("update Fine set amount=" + txt_amt.Text + ", status = 'Paid', ludate = '" + dateTimePicker1.Value + "' where fineno ='" + txt_fno.Text + "'", con);

                                cmd.ExecuteNonQuery();
                                con.Close();


                                MessageBox.Show("Fine payment updated successfully", "Succeeded", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btn_print_Click(object sender, EventArgs e)

        {
            try
            {


                if (txt_fno.TextLength <= 0)
                {
                    error_fno.SetError(txt_fno, "Fine code required");

                    if (txt_nic.TextLength != 10)
                    {
                        error_nic.SetError(txt_nic, "Valid NIC number required");
                        if (txt_amt.TextLength <= 0)
                        {
                            errorProvider1.SetError(txt_amt, "Enter total fine amount");


                            if (checkBox1.Checked == false)
                            {
                                error_check.SetError(checkBox1, "Please confirm that fine is paied");
                            }
                            else
                            {
                                error_check.Clear();
                            }
                        }
                        else
                        {
                            errorProvider1.Clear();
                        }
                    }
                    else
                    {
                        error_nic.Clear();



                    }

                }
                else
                {
                    error_fno.Clear();

                    if (txt_nic.TextLength != 10)
                    {
                        error_nic.SetError(txt_nic, "Valid NIC number required");
                        if (txt_amt.TextLength <= 0)
                        {
                            errorProvider1.SetError(txt_amt, "Enter total fine amount");

                            if (checkBox1.Checked == false)
                            {
                                error_check.SetError(checkBox1, "Please confirm that fine is paied");

                            }
                            else
                            {
                                error_check.Clear();

                            }
                        }
                        errorProvider1.Clear();
                    }
                    else
                    {
                        error_nic.Clear();
                        if (txt_amt.TextLength <= 0)
                        {
                            errorProvider1.SetError(txt_amt, "Enter total fine amount");
                            if (checkBox1.Checked == false)
                            {
                                error_check.SetError(checkBox1, "Please confirm that fine is paid");
                            }
                            else
                            {
                                error_check.Clear();
                            }
                        }
                        else
                        {
                            errorProvider1.Clear();


                            if (checkBox1.Checked == false)
                            {
                                error_check.SetError(checkBox1, "Please confirm that fine is paid");
                            }
                            else
                            {
                                error_check.Clear();
                        
            




                                CaptureScreen();
                                printDocument1.Print();
                            }
                        }
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Please check again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        Bitmap memoryImage;

        private void CaptureScreen()
        {
            Graphics myGraphics = this.CreateGraphics();
            Size s = this.Size;
            memoryImage = new Bitmap(s.Width, s.Height, myGraphics);
            Graphics memoryGraphics = Graphics.FromImage(memoryImage);
            memoryGraphics.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, s);

        }

        private void printDocument1_PrintPage(System.Object sender, System.Drawing.Printing.PrintPageEventArgs e)
         

        {
            try
            {

            
            e.Graphics.DrawImage(memoryImage, 0, 0);

        }


   
            catch (Exception)
            {
                MessageBox.Show("Please check again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
    }
}

