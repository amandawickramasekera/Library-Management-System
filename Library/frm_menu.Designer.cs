namespace Library
{
    partial class frm_menu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_menu));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.memberListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newBookToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.borrowRecordsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fineRecordsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newMeberToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newBorrowRecordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newFineRecordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateMemberToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteMemberToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fineRecordsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.updateFineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.returnBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewToolStripMenuItem,
            this.addToolStripMenuItem,
            this.editToolStripMenuItem,
            this.backToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(727, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.memberListToolStripMenuItem,
            this.newBookToolStripMenuItem1,
            this.borrowRecordsToolStripMenuItem,
            this.fineRecordsToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // memberListToolStripMenuItem
            // 
            this.memberListToolStripMenuItem.Name = "memberListToolStripMenuItem";
            this.memberListToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.memberListToolStripMenuItem.Text = "Member list";
            this.memberListToolStripMenuItem.Click += new System.EventHandler(this.memberListToolStripMenuItem_Click);
            // 
            // newBookToolStripMenuItem1
            // 
            this.newBookToolStripMenuItem1.Name = "newBookToolStripMenuItem1";
            this.newBookToolStripMenuItem1.Size = new System.Drawing.Size(154, 22);
            this.newBookToolStripMenuItem1.Text = "Book list";
            this.newBookToolStripMenuItem1.Click += new System.EventHandler(this.newBookToolStripMenuItem1_Click);
            // 
            // borrowRecordsToolStripMenuItem
            // 
            this.borrowRecordsToolStripMenuItem.Name = "borrowRecordsToolStripMenuItem";
            this.borrowRecordsToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.borrowRecordsToolStripMenuItem.Text = "Borrow records";
            this.borrowRecordsToolStripMenuItem.Click += new System.EventHandler(this.borrowRecordsToolStripMenuItem_Click);
            // 
            // fineRecordsToolStripMenuItem
            // 
            this.fineRecordsToolStripMenuItem.Name = "fineRecordsToolStripMenuItem";
            this.fineRecordsToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.fineRecordsToolStripMenuItem.Text = "Fine records";
            this.fineRecordsToolStripMenuItem.Click += new System.EventHandler(this.fineRecordsToolStripMenuItem_Click);
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newMeberToolStripMenuItem,
            this.newBookToolStripMenuItem,
            this.newBorrowRecordToolStripMenuItem,
            this.newFineRecordToolStripMenuItem});
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.addToolStripMenuItem.Text = "Add";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
            // 
            // newMeberToolStripMenuItem
            // 
            this.newMeberToolStripMenuItem.Name = "newMeberToolStripMenuItem";
            this.newMeberToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.newMeberToolStripMenuItem.Text = "New member";
            this.newMeberToolStripMenuItem.Click += new System.EventHandler(this.newMeberToolStripMenuItem_Click);
            // 
            // newBookToolStripMenuItem
            // 
            this.newBookToolStripMenuItem.Name = "newBookToolStripMenuItem";
            this.newBookToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.newBookToolStripMenuItem.Text = "New book";
            this.newBookToolStripMenuItem.Click += new System.EventHandler(this.newBookToolStripMenuItem_Click);
            // 
            // newBorrowRecordToolStripMenuItem
            // 
            this.newBorrowRecordToolStripMenuItem.Name = "newBorrowRecordToolStripMenuItem";
            this.newBorrowRecordToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.newBorrowRecordToolStripMenuItem.Text = "New borrow record";
            this.newBorrowRecordToolStripMenuItem.Click += new System.EventHandler(this.newBorrowRecordToolStripMenuItem_Click);
            // 
            // newFineRecordToolStripMenuItem
            // 
            this.newFineRecordToolStripMenuItem.Name = "newFineRecordToolStripMenuItem";
            this.newFineRecordToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.newFineRecordToolStripMenuItem.Text = "New fine record";
            this.newFineRecordToolStripMenuItem.Click += new System.EventHandler(this.newFineRecordToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bookListToolStripMenuItem,
            this.fineRecordsToolStripMenuItem1,
            this.returnBookToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // bookListToolStripMenuItem
            // 
            this.bookListToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.updateMemberToolStripMenuItem,
            this.deleteMemberToolStripMenuItem});
            this.bookListToolStripMenuItem.Name = "bookListToolStripMenuItem";
            this.bookListToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.bookListToolStripMenuItem.Text = "Member list";
            // 
            // updateMemberToolStripMenuItem
            // 
            this.updateMemberToolStripMenuItem.Name = "updateMemberToolStripMenuItem";
            this.updateMemberToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.updateMemberToolStripMenuItem.Text = "Update member";
            this.updateMemberToolStripMenuItem.Click += new System.EventHandler(this.updateMemberToolStripMenuItem_Click);
            // 
            // deleteMemberToolStripMenuItem
            // 
            this.deleteMemberToolStripMenuItem.Name = "deleteMemberToolStripMenuItem";
            this.deleteMemberToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.deleteMemberToolStripMenuItem.Text = "Delete member";
            this.deleteMemberToolStripMenuItem.Click += new System.EventHandler(this.deleteMemberToolStripMenuItem_Click);
            // 
            // fineRecordsToolStripMenuItem1
            // 
            this.fineRecordsToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.updateFineToolStripMenuItem});
            this.fineRecordsToolStripMenuItem1.Name = "fineRecordsToolStripMenuItem1";
            this.fineRecordsToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.fineRecordsToolStripMenuItem1.Text = "Fine records";
            this.fineRecordsToolStripMenuItem1.Click += new System.EventHandler(this.fineRecordsToolStripMenuItem1_Click);
            // 
            // updateFineToolStripMenuItem
            // 
            this.updateFineToolStripMenuItem.Name = "updateFineToolStripMenuItem";
            this.updateFineToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.updateFineToolStripMenuItem.Text = "Update fine";
            this.updateFineToolStripMenuItem.Click += new System.EventHandler(this.updateFineToolStripMenuItem_Click);
            // 
            // returnBookToolStripMenuItem
            // 
            this.returnBookToolStripMenuItem.Name = "returnBookToolStripMenuItem";
            this.returnBookToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.returnBookToolStripMenuItem.Text = "Return book";
            this.returnBookToolStripMenuItem.Click += new System.EventHandler(this.returnBookToolStripMenuItem_Click);
            // 
            // backToolStripMenuItem
            // 
            this.backToolStripMenuItem.Name = "backToolStripMenuItem";
            this.backToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.backToolStripMenuItem.Text = "Back";
            this.backToolStripMenuItem.Click += new System.EventHandler(this.backToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(238, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 47);
            this.label1.TabIndex = 1;
            this.label1.Text = "Welcome back!";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(212, 124);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(291, 242);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // frm_menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(727, 442);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frm_menu";
            this.Text = "Menu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem memberListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newBookToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newMeberToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newBookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bookListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateMemberToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteMemberToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem borrowRecordsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fineRecordsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fineRecordsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem updateFineToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem returnBookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newBorrowRecordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newFineRecordToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}