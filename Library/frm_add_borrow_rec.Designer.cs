namespace Library
{
    partial class frm_add_borrow_rec
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_add_borrow_rec));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_isbn = new System.Windows.Forms.TextBox();
            this.txt_nic = new System.Windows.Forms.TextBox();
            this.btn_cls_search = new System.Windows.Forms.Button();
            this.error_no_isbn = new System.Windows.Forms.ErrorProvider(this.components);
            this.error_no_nic = new System.Windows.Forms.ErrorProvider(this.components);
            this.btn_search_member = new System.Windows.Forms.Button();
            this.btn_search_book = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_back = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_ = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_mem_nic = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_book_isbn = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btn_cls = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.error_no_isbn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.error_no_nic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(89, 122);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Book ISBN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(85, 54);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Member NIC Number";
            // 
            // txt_isbn
            // 
            this.txt_isbn.Location = new System.Drawing.Point(268, 120);
            this.txt_isbn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txt_isbn.Name = "txt_isbn";
            this.txt_isbn.Size = new System.Drawing.Size(161, 29);
            this.txt_isbn.TabIndex = 2;
            // 
            // txt_nic
            // 
            this.txt_nic.Location = new System.Drawing.Point(268, 54);
            this.txt_nic.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txt_nic.Name = "txt_nic";
            this.txt_nic.Size = new System.Drawing.Size(161, 29);
            this.txt_nic.TabIndex = 3;
            // 
            // btn_cls_search
            // 
            this.btn_cls_search.Location = new System.Drawing.Point(614, 189);
            this.btn_cls_search.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_cls_search.Name = "btn_cls_search";
            this.btn_cls_search.Size = new System.Drawing.Size(106, 33);
            this.btn_cls_search.TabIndex = 7;
            this.btn_cls_search.Text = "Clear search";
            this.btn_cls_search.UseVisualStyleBackColor = true;
            this.btn_cls_search.Click += new System.EventHandler(this.btn_cls_search_Click);
            // 
            // error_no_isbn
            // 
            this.error_no_isbn.ContainerControl = this;
            // 
            // error_no_nic
            // 
            this.error_no_nic.ContainerControl = this;
            // 
            // btn_search_member
            // 
            this.btn_search_member.Location = new System.Drawing.Point(481, 53);
            this.btn_search_member.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_search_member.Name = "btn_search_member";
            this.btn_search_member.Size = new System.Drawing.Size(165, 27);
            this.btn_search_member.TabIndex = 9;
            this.btn_search_member.Text = "Search for member";
            this.btn_search_member.UseVisualStyleBackColor = true;
            this.btn_search_member.Click += new System.EventHandler(this.btn_search_member_Click);
            // 
            // btn_search_book
            // 
            this.btn_search_book.Location = new System.Drawing.Point(481, 120);
            this.btn_search_book.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_search_book.Name = "btn_search_book";
            this.btn_search_book.Size = new System.Drawing.Size(165, 29);
            this.btn_search_book.TabIndex = 10;
            this.btn_search_book.Text = "Search for book";
            this.btn_search_book.UseVisualStyleBackColor = true;
            this.btn_search_book.Click += new System.EventHandler(this.btn_search_book_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(219, 255);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(367, 137);
            this.dataGridView1.TabIndex = 11;
            // 
            // btn_back
            // 
            this.btn_back.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back.Location = new System.Drawing.Point(787, 623);
            this.btn_back.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(73, 34);
            this.btn_back.TabIndex = 12;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exit.Location = new System.Drawing.Point(897, 623);
            this.btn_exit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(69, 34);
            this.btn_exit.TabIndex = 13;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // btn_
            // 
            this.btn_.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_.Location = new System.Drawing.Point(526, 625);
            this.btn_.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_.Name = "btn_";
            this.btn_.Size = new System.Drawing.Size(105, 33);
            this.btn_.TabIndex = 20;
            this.btn_.Text = "Issue book";
            this.btn_.UseVisualStyleBackColor = true;
            this.btn_.Click += new System.EventHandler(this.btn__Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(89, 443);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 21);
            this.label3.TabIndex = 21;
            this.label3.Text = "Member NIC number";
            // 
            // txt_mem_nic
            // 
            this.txt_mem_nic.Location = new System.Drawing.Point(279, 435);
            this.txt_mem_nic.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txt_mem_nic.Name = "txt_mem_nic";
            this.txt_mem_nic.Size = new System.Drawing.Size(176, 29);
            this.txt_mem_nic.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(89, 505);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 21);
            this.label4.TabIndex = 23;
            this.label4.Text = "Book ISBN";
            // 
            // txt_book_isbn
            // 
            this.txt_book_isbn.Location = new System.Drawing.Point(279, 497);
            this.txt_book_isbn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txt_book_isbn.Name = "txt_book_isbn";
            this.txt_book_isbn.Size = new System.Drawing.Size(176, 29);
            this.txt_book_isbn.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(89, 572);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 21);
            this.label5.TabIndex = 25;
            this.label5.Text = "Date issued";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(279, 564);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(264, 29);
            this.dateTimePicker1.TabIndex = 26;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // btn_cls
            // 
            this.btn_cls.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cls.Location = new System.Drawing.Point(672, 624);
            this.btn_cls.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_cls.Name = "btn_cls";
            this.btn_cls.Size = new System.Drawing.Size(78, 33);
            this.btn_cls.TabIndex = 27;
            this.btn_cls.Text = "Clear";
            this.btn_cls.UseVisualStyleBackColor = true;
            this.btn_cls.Click += new System.EventHandler(this.btn_cls_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(591, 384);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(209, 199);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            // 
            // frm_add_borrow_rec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(1031, 684);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_cls);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_book_isbn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_mem_nic);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_search_book);
            this.Controls.Add(this.btn_search_member);
            this.Controls.Add(this.btn_cls_search);
            this.Controls.Add(this.txt_nic);
            this.Controls.Add(this.txt_isbn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frm_add_borrow_rec";
            this.Text = "Add Borrow Record";
            this.Load += new System.EventHandler(this.frm_add_borrow_rec_Load);
            ((System.ComponentModel.ISupportInitialize)(this.error_no_isbn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.error_no_nic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_isbn;
        private System.Windows.Forms.TextBox txt_nic;
        private System.Windows.Forms.Button btn_cls_search;
        private System.Windows.Forms.ErrorProvider error_no_isbn;
        private System.Windows.Forms.ErrorProvider error_no_nic;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_search_book;
        private System.Windows.Forms.Button btn_search_member;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_book_isbn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_mem_nic;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.Button btn_cls;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}