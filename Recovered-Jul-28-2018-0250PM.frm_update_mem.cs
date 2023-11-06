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
            

        }

        private void btn_update_mem_Click(object sender, EventArgs e)
        {
            con.Open();
            
            


            con.Close();
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
            con.Open();

            string name, add, gs_div, nic;

            cmd = new SqlCommand(" select m_name from Member where nic = '" +txt_search.Text+ "' ", con);
            con.Close();
        }

        private void btn_clear_search_Click(object sender, EventArgs e)
        {
            txt_search.Text = "";
        }
    }
}
