namespace Library
{
    partial class return_book
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_book_isbn = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_mem_nic = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.btn_get = new System.Windows.Forms.Button();
            this.btn_cls = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.error_nic = new System.Windows.Forms.ErrorProvider(this.components);
            this.error_isbn = new System.Windows.Forms.ErrorProvider(this.components);
            this.error_check = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.error_nic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.error_isbn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.error_check)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(309, 223);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(316, 29);
            this.dateTimePicker1.TabIndex = 32;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(83, 229);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 21);
            this.label5.TabIndex = 31;
            this.label5.Text = "Date returned";
            // 
            // txt_book_isbn
            // 
            this.txt_book_isbn.Location = new System.Drawing.Point(309, 155);
            this.txt_book_isbn.Name = "txt_book_isbn";
            this.txt_book_isbn.Size = new System.Drawing.Size(192, 29);
            this.txt_book_isbn.TabIndex = 30;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(81, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 21);
            this.label4.TabIndex = 29;
            this.label4.Text = "Book ISBN";
            // 
            // txt_mem_nic
            // 
            this.txt_mem_nic.Location = new System.Drawing.Point(309, 88);
            this.txt_mem_nic.Name = "txt_mem_nic";
            this.txt_mem_nic.Size = new System.Drawing.Size(192, 29);
            this.txt_mem_nic.TabIndex = 28;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(81, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 21);
            this.label3.TabIndex = 27;
            this.label3.Text = "Member NIC number";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(85, 304);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(137, 25);
            this.checkBox1.TabIndex = 33;
            this.checkBox1.Text = "Book recieved";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // btn_get
            // 
            this.btn_get.Location = new System.Drawing.Point(309, 347);
            this.btn_get.Name = "btn_get";
            this.btn_get.Size = new System.Drawing.Size(101, 32);
            this.btn_get.TabIndex = 34;
            this.btn_get.Text = "Get book";
            this.btn_get.UseVisualStyleBackColor = true;
            this.btn_get.Click += new System.EventHandler(this.btn_get_Click);
            // 
            // btn_cls
            // 
            this.btn_cls.Location = new System.Drawing.Point(447, 347);
            this.btn_cls.Name = "btn_cls";
            this.btn_cls.Size = new System.Drawing.Size(83, 32);
            this.btn_cls.TabIndex = 35;
            this.btn_cls.Text = "Clear";
            this.btn_cls.UseVisualStyleBackColor = true;
            this.btn_cls.Click += new System.EventHandler(this.btn_cls_Click);
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(568, 347);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(80, 32);
            this.btn_back.TabIndex = 36;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(684, 347);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(77, 32);
            this.btn_exit.TabIndex = 37;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.button4_Click);
            // 
            // error_nic
            // 
            this.error_nic.ContainerControl = this;
            // 
            // error_isbn
            // 
            this.error_isbn.ContainerControl = this;
            // 
            // error_check
            // 
            this.error_check.ContainerControl = this;
            // 
            // return_book
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(837, 426);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.btn_cls);
            this.Controls.Add(this.btn_get);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_book_isbn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_mem_nic);
            this.Controls.Add(this.label3);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "return_book";
            this.Text = "Return Book";
            this.Load += new System.EventHandler(this.return_book_Load);
            ((System.ComponentModel.ISupportInitialize)(this.error_nic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.error_isbn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.error_check)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_book_isbn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_mem_nic;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button btn_get;
        private System.Windows.Forms.Button btn_cls;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.ErrorProvider error_nic;
        private System.Windows.Forms.ErrorProvider error_isbn;
        private System.Windows.Forms.ErrorProvider error_check;
    }
}