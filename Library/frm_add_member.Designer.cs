namespace Library
{
    partial class frm_add_member
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
            this.btn_add_mem = new System.Windows.Forms.Button();
            this.btn_cls = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_m_name = new System.Windows.Forms.TextBox();
            this.txt_nic = new System.Windows.Forms.TextBox();
            this.cmb_div = new System.Windows.Forms.ComboBox();
            this.error_no_name = new System.Windows.Forms.ErrorProvider(this.components);
            this.error_no_address = new System.Windows.Forms.ErrorProvider(this.components);
            this.error_no_div = new System.Windows.Forms.ErrorProvider(this.components);
            this.error_nic = new System.Windows.Forms.ErrorProvider(this.components);
            this.txt_address = new System.Windows.Forms.RichTextBox();
            this.btn_back = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.txt_contact = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.error_no_cno = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.error_no_name)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.error_no_address)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.error_no_div)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.error_nic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.error_no_cno)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_add_mem
            // 
            this.btn_add_mem.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add_mem.Location = new System.Drawing.Point(204, 486);
            this.btn_add_mem.Name = "btn_add_mem";
            this.btn_add_mem.Size = new System.Drawing.Size(121, 36);
            this.btn_add_mem.TabIndex = 0;
            this.btn_add_mem.Text = "Add member";
            this.btn_add_mem.UseVisualStyleBackColor = true;
            this.btn_add_mem.Click += new System.EventHandler(this.btn_add_mem_Click);
            // 
            // btn_cls
            // 
            this.btn_cls.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cls.Location = new System.Drawing.Point(367, 486);
            this.btn_cls.Name = "btn_cls";
            this.btn_cls.Size = new System.Drawing.Size(94, 36);
            this.btn_cls.TabIndex = 1;
            this.btn_cls.Text = "Clear";
            this.btn_cls.UseVisualStyleBackColor = true;
            this.btn_cls.Click += new System.EventHandler(this.btn_cls_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "NIC number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(78, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(91, 230);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 23);
            this.label3.TabIndex = 4;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(78, 230);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 23);
            this.label4.TabIndex = 5;
            this.label4.Text = "Address";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(78, 402);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(148, 23);
            this.label7.TabIndex = 9;
            this.label7.Text = "Contact Number";
            // 
            // txt_m_name
            // 
            this.txt_m_name.Location = new System.Drawing.Point(396, 139);
            this.txt_m_name.Name = "txt_m_name";
            this.txt_m_name.Size = new System.Drawing.Size(200, 32);
            this.txt_m_name.TabIndex = 10;
            // 
            // txt_nic
            // 
            this.txt_nic.Location = new System.Drawing.Point(396, 65);
            this.txt_nic.Name = "txt_nic";
            this.txt_nic.Size = new System.Drawing.Size(200, 32);
            this.txt_nic.TabIndex = 11;
            // 
            // cmb_div
            // 
            this.cmb_div.FormattingEnabled = true;
            this.cmb_div.Items.AddRange(new object[] {
            "Soysapura South",
            "Soysapura North"});
            this.cmb_div.Location = new System.Drawing.Point(396, 317);
            this.cmb_div.Name = "cmb_div";
            this.cmb_div.Size = new System.Drawing.Size(200, 31);
            this.cmb_div.TabIndex = 15;
            // 
            // error_no_name
            // 
            this.error_no_name.ContainerControl = this;
            // 
            // error_no_address
            // 
            this.error_no_address.ContainerControl = this;
            // 
            // error_no_div
            // 
            this.error_no_div.ContainerControl = this;
            // 
            // error_nic
            // 
            this.error_nic.ContainerControl = this;
            // 
            // txt_address
            // 
            this.txt_address.Location = new System.Drawing.Point(396, 204);
            this.txt_address.Name = "txt_address";
            this.txt_address.Size = new System.Drawing.Size(200, 76);
            this.txt_address.TabIndex = 16;
            this.txt_address.Text = "";
            // 
            // btn_back
            // 
            this.btn_back.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back.Location = new System.Drawing.Point(500, 486);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(96, 36);
            this.btn_back.TabIndex = 17;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exit.Location = new System.Drawing.Point(643, 486);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(93, 36);
            this.btn_exit.TabIndex = 18;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // txt_contact
            // 
            this.txt_contact.Location = new System.Drawing.Point(396, 393);
            this.txt_contact.Name = "txt_contact";
            this.txt_contact.Size = new System.Drawing.Size(200, 32);
            this.txt_contact.TabIndex = 21;
            this.txt_contact.TextChanged += new System.EventHandler(this.txt_contact_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(78, 320);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 23);
            this.label6.TabIndex = 22;
            this.label6.Text = "Devision";
            // 
            // error_no_cno
            // 
            this.error_no_cno.ContainerControl = this;
            // 
            // frm_add_member
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(915, 551);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.txt_address);
            this.Controls.Add(this.cmb_div);
            this.Controls.Add(this.txt_nic);
            this.Controls.Add(this.txt_m_name);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_cls);
            this.Controls.Add(this.btn_add_mem);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_contact);
            this.Controls.Add(this.label3);
            this.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "frm_add_member";
            this.Text = "Add New Member";
            this.Load += new System.EventHandler(this.frm_add_member_Load);
            ((System.ComponentModel.ISupportInitialize)(this.error_no_name)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.error_no_address)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.error_no_div)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.error_nic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.error_no_cno)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_add_mem;
        private System.Windows.Forms.Button btn_cls;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_m_name;
        private System.Windows.Forms.TextBox txt_nic;
        private System.Windows.Forms.ComboBox cmb_div;
        private System.Windows.Forms.ErrorProvider error_no_name;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.RichTextBox txt_address;
        private System.Windows.Forms.ErrorProvider error_no_address;
        private System.Windows.Forms.ErrorProvider error_no_div;
        private System.Windows.Forms.ErrorProvider error_nic;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_contact;
        private System.Windows.Forms.ErrorProvider error_no_cno;
    }
}