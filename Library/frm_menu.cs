using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    public partial class frm_menu : Form
    {
        public frm_menu()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result;
            
            result =MessageBox.Show("Are you sure you want to exit?", "Exit confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(result == DialogResult.Yes)
            {
                this.Close();
            }
            
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_login obj = new frm_login();
            obj.Show();
            this.Hide();

        }

        private void memberListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_view_member obj = new frm_view_member();
            obj.Show();
            this.Hide();
        }

        private void newBookToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frm_view_books obj = new frm_view_books();
            obj.Show();
            this.Hide();
        }

        private void newMeberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_add_member obj = new frm_add_member();
            obj.Show();
            this.Hide();
        }

        private void newBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_add_book obj = new frm_add_book();
            obj.Show();
            this.Hide();
        }

        private void updateMemberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_update_mem obj = new frm_update_mem();
            obj.Show();
            this.Hide();

        }

        private void deleteMemberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_del_mem obj = new frm_del_mem();
            obj.Show();
            this.Hide();
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void newBorrowRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_add_borrow_rec obj = new frm_add_borrow_rec();
            obj.Show();
            this.Hide();
        }

        private void borrowRecordsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            view_borrow_rec obj = new view_borrow_rec();
            obj.Show();
            this.Hide();
        }

        private void fineRecordsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            view_fine_recs obj = new view_fine_recs();
            obj.Show();
            this.Hide();


        }

        private void newFineRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            add_fine_rec obj = new add_fine_rec();
            obj.Show();
            this.Hide();
        }

        private void updateFineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            edit_fine_rec obj = new edit_fine_rec();
            obj.Show();
            this.Hide();
        }

        private void fineRecordsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
        }

        private void returnBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            return_book obj = new return_book();
            obj.Show();
            this.Hide();
        }
    }
}
