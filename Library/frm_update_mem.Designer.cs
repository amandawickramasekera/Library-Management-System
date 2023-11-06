namespace Library
{
    partial class frm_update_mem
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
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            this.txt_address = new System.Windows.Forms.RichTextBox();
            this.cmb_div = new System.Windows.Forms.ComboBox();
            this.txt_m_name = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_cls = new System.Windows.Forms.Button();
            this.btn_update_mem = new System.Windows.Forms.Button();
            this.btn_search = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.btn_clear_search = new System.Windows.Forms.Button();
            this.error_no_nic = new System.Windows.Forms.ErrorProvider(this.components);
            this.error_no_name = new System.Windows.Forms.ErrorProvider(this.components);
            this.error_no_add = new System.Windows.Forms.ErrorProvider(this.components);
            this.error_no_gsd = new System.Windows.Forms.ErrorProvider(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.txt_contact = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.error_no_cno = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.error_no_nic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.error_no_name)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.error_no_add)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.error_no_gsd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.error_no_cno)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_exit
            // 
            this.btn_exit.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exit.Location = new System.Drawing.Point(701, 594);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(93, 36);
            this.btn_exit.TabIndex = 31;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // btn_back
            // 
            this.btn_back.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back.Location = new System.Drawing.Point(557, 594);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(96, 36);
            this.btn_back.TabIndex = 30;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // txt_address
            // 
            this.txt_address.Location = new System.Drawing.Point(380, 305);
            this.txt_address.Name = "txt_address";
            this.txt_address.Size = new System.Drawing.Size(200, 76);
            this.txt_address.TabIndex = 29;
            this.txt_address.Text = "";
            // 
            // cmb_div
            // 
            this.cmb_div.FormattingEnabled = true;
            this.cmb_div.Items.AddRange(new object[] {
            "Soysapura South",
            "Soysapura North"});
            this.cmb_div.Location = new System.Drawing.Point(380, 411);
            this.cmb_div.Name = "cmb_div";
            this.cmb_div.Size = new System.Drawing.Size(200, 31);
            this.cmb_div.TabIndex = 28;
            // 
            // txt_m_name
            // 
            this.txt_m_name.Location = new System.Drawing.Point(380, 239);
            this.txt_m_name.Name = "txt_m_name";
            this.txt_m_name.Size = new System.Drawing.Size(200, 32);
            this.txt_m_name.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(99, 414);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 23);
            this.label4.TabIndex = 24;
            this.label4.Text = "Devision";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(99, 270);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 23);
            this.label3.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(99, 327);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 23);
            this.label2.TabIndex = 22;
            this.label2.Text = "Address";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(99, 248);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 23);
            this.label1.TabIndex = 21;
            this.label1.Text = "Member name";
            // 
            // btn_cls
            // 
            this.btn_cls.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cls.Location = new System.Drawing.Point(424, 594);
            this.btn_cls.Name = "btn_cls";
            this.btn_cls.Size = new System.Drawing.Size(94, 36);
            this.btn_cls.TabIndex = 20;
            this.btn_cls.Text = "Clear";
            this.btn_cls.UseVisualStyleBackColor = true;
            this.btn_cls.Click += new System.EventHandler(this.btn_cls_Click);
            // 
            // btn_update_mem
            // 
            this.btn_update_mem.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update_mem.Location = new System.Drawing.Point(198, 594);
            this.btn_update_mem.Name = "btn_update_mem";
            this.btn_update_mem.Size = new System.Drawing.Size(191, 36);
            this.btn_update_mem.TabIndex = 19;
            this.btn_update_mem.Text = "Update member details";
            this.btn_update_mem.UseVisualStyleBackColor = true;
            this.btn_update_mem.Click += new System.EventHandler(this.btn_update_mem_Click);
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(416, 120);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(102, 37);
            this.btn_search.TabIndex = 34;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(99, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(235, 23);
            this.label5.TabIndex = 33;
            this.label5.Text = "Enter member NIC number";
            // 
            // txt_search
            // 
            this.txt_search.Location = new System.Drawing.Point(380, 53);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(180, 32);
            this.txt_search.TabIndex = 32;
            // 
            // btn_clear_search
            // 
            this.btn_clear_search.Location = new System.Drawing.Point(557, 120);
            this.btn_clear_search.Name = "btn_clear_search";
            this.btn_clear_search.Size = new System.Drawing.Size(120, 38);
            this.btn_clear_search.TabIndex = 35;
            this.btn_clear_search.Text = "Clear search";
            this.btn_clear_search.UseVisualStyleBackColor = true;
            this.btn_clear_search.Click += new System.EventHandler(this.btn_clear_search_Click);
            // 
            // error_no_nic
            // 
            this.error_no_nic.ContainerControl = this;
            // 
            // error_no_name
            // 
            this.error_no_name.ContainerControl = this;
            // 
            // error_no_add
            // 
            this.error_no_add.ContainerControl = this;
            // 
            // error_no_gsd
            // 
            this.error_no_gsd.ContainerControl = this;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(99, 483);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(148, 23);
            this.label7.TabIndex = 40;
            this.label7.Text = "Contact Number";
            // 
            // txt_contact
            // 
            this.txt_contact.Location = new System.Drawing.Point(380, 474);
            this.txt_contact.Name = "txt_contact";
            this.txt_contact.Size = new System.Drawing.Size(200, 32);
            this.txt_contact.TabIndex = 39;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(122, 411);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 23);
            this.label8.TabIndex = 38;
            // 
            // error_no_cno
            // 
            this.error_no_cno.ContainerControl = this;
            // 
            // frm_update_mem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(905, 661);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_contact);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btn_clear_search);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_search);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.txt_address);
            this.Controls.Add(this.cmb_div);
            this.Controls.Add(this.txt_m_name);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_cls);
            this.Controls.Add(this.btn_update_mem);
            this.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "frm_update_mem";
            this.Text = "Update Member";
            this.Load += new System.EventHandler(this.frm_update_mem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.error_no_nic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.error_no_name)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.error_no_add)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.error_no_gsd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.error_no_cno)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.RichTextBox txt_address;
        private System.Windows.Forms.ComboBox cmb_div;
        private System.Windows.Forms.TextBox txt_m_name;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_cls;
        private System.Windows.Forms.Button btn_update_mem;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.Button btn_clear_search;
        private System.Windows.Forms.ErrorProvider error_no_nic;
        private System.Windows.Forms.ErrorProvider error_no_name;
        private System.Windows.Forms.ErrorProvider error_no_add;
        private System.Windows.Forms.ErrorProvider error_no_gsd;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_contact;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ErrorProvider error_no_cno;
    }
}