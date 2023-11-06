namespace Library
{
    partial class frm_add_book
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_ISBN = new System.Windows.Forms.TextBox();
            this.txt_title = new System.Windows.Forms.TextBox();
            this.txt_author = new System.Windows.Forms.TextBox();
            this.txt_pub = new System.Windows.Forms.TextBox();
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            this.btn_cls = new System.Windows.Forms.Button();
            this.btn_add_book = new System.Windows.Forms.Button();
            this.error_no_isbn = new System.Windows.Forms.ErrorProvider(this.components);
            this.error_no_title = new System.Windows.Forms.ErrorProvider(this.components);
            this.error_no_author = new System.Windows.Forms.ErrorProvider(this.components);
            this.error_no_pub = new System.Windows.Forms.ErrorProvider(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.error_no_status = new System.Windows.Forms.ErrorProvider(this.components);
            this.cmb_status = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.error_no_isbn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.error_no_title)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.error_no_author)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.error_no_pub)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.error_no_status)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "ISBN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Title";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(69, 213);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Author";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(69, 286);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Publisher";
            // 
            // txt_ISBN
            // 
            this.txt_ISBN.Location = new System.Drawing.Point(340, 61);
            this.txt_ISBN.Name = "txt_ISBN";
            this.txt_ISBN.Size = new System.Drawing.Size(189, 32);
            this.txt_ISBN.TabIndex = 6;
            // 
            // txt_title
            // 
            this.txt_title.Location = new System.Drawing.Point(340, 128);
            this.txt_title.Name = "txt_title";
            this.txt_title.Size = new System.Drawing.Size(189, 32);
            this.txt_title.TabIndex = 7;
            // 
            // txt_author
            // 
            this.txt_author.Location = new System.Drawing.Point(340, 204);
            this.txt_author.Name = "txt_author";
            this.txt_author.Size = new System.Drawing.Size(189, 32);
            this.txt_author.TabIndex = 9;
            // 
            // txt_pub
            // 
            this.txt_pub.Location = new System.Drawing.Point(340, 277);
            this.txt_pub.Name = "txt_pub";
            this.txt_pub.Size = new System.Drawing.Size(189, 32);
            this.txt_pub.TabIndex = 10;
            // 
            // btn_exit
            // 
            this.btn_exit.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exit.Location = new System.Drawing.Point(627, 454);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(93, 36);
            this.btn_exit.TabIndex = 22;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // btn_back
            // 
            this.btn_back.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back.Location = new System.Drawing.Point(494, 454);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(96, 36);
            this.btn_back.TabIndex = 21;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // btn_cls
            // 
            this.btn_cls.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cls.Location = new System.Drawing.Point(362, 454);
            this.btn_cls.Name = "btn_cls";
            this.btn_cls.Size = new System.Drawing.Size(94, 36);
            this.btn_cls.TabIndex = 20;
            this.btn_cls.Text = "Clear";
            this.btn_cls.UseVisualStyleBackColor = true;
            this.btn_cls.Click += new System.EventHandler(this.btn_cls_Click);
            // 
            // btn_add_book
            // 
            this.btn_add_book.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add_book.Location = new System.Drawing.Point(202, 454);
            this.btn_add_book.Name = "btn_add_book";
            this.btn_add_book.Size = new System.Drawing.Size(121, 36);
            this.btn_add_book.TabIndex = 19;
            this.btn_add_book.Text = "Add book";
            this.btn_add_book.UseVisualStyleBackColor = true;
            this.btn_add_book.Click += new System.EventHandler(this.btn_add_book_Click);
            // 
            // error_no_isbn
            // 
            this.error_no_isbn.ContainerControl = this;
            // 
            // error_no_title
            // 
            this.error_no_title.ContainerControl = this;
            // 
            // error_no_author
            // 
            this.error_no_author.ContainerControl = this;
            // 
            // error_no_pub
            // 
            this.error_no_pub.ContainerControl = this;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(69, 356);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 23);
            this.label5.TabIndex = 24;
            this.label5.Text = "Status";
            // 
            // error_no_status
            // 
            this.error_no_status.ContainerControl = this;
            // 
            // cmb_status
            // 
            this.cmb_status.FormattingEnabled = true;
            this.cmb_status.Items.AddRange(new object[] {
            "Available",
            "Taken"});
            this.cmb_status.Location = new System.Drawing.Point(340, 348);
            this.cmb_status.Name = "cmb_status";
            this.cmb_status.Size = new System.Drawing.Size(189, 31);
            this.cmb_status.TabIndex = 25;
            // 
            // frm_add_book
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(856, 536);
            this.Controls.Add(this.cmb_status);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.btn_cls);
            this.Controls.Add(this.btn_add_book);
            this.Controls.Add(this.txt_pub);
            this.Controls.Add(this.txt_author);
            this.Controls.Add(this.txt_title);
            this.Controls.Add(this.txt_ISBN);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "frm_add_book";
            this.Text = "Add New Book";
            this.Load += new System.EventHandler(this.frm_add_book_Load);
            ((System.ComponentModel.ISupportInitialize)(this.error_no_isbn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.error_no_title)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.error_no_author)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.error_no_pub)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.error_no_status)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_ISBN;
        private System.Windows.Forms.TextBox txt_title;
        private System.Windows.Forms.TextBox txt_author;
        private System.Windows.Forms.TextBox txt_pub;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Button btn_cls;
        private System.Windows.Forms.Button btn_add_book;
        private System.Windows.Forms.ErrorProvider error_no_isbn;
        private System.Windows.Forms.ErrorProvider error_no_title;
        private System.Windows.Forms.ErrorProvider error_no_author;
        private System.Windows.Forms.ErrorProvider error_no_pub;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ErrorProvider error_no_status;
        private System.Windows.Forms.ComboBox cmb_status;
    }
}