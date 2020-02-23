namespace TTN_QLTV
{
    partial class TaiKhoan
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
            this.dtgvtaikhoan = new System.Windows.Forms.DataGridView();
            this.Column1MaTK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1Usename = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1Password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btthoat = new System.Windows.Forms.Button();
            this.btXoa = new System.Windows.Forms.Button();
            this.btSua = new System.Windows.Forms.Button();
            this.btThem = new System.Windows.Forms.Button();
            this.txtmatkhau = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtten = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtma = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvtaikhoan)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgvtaikhoan
            // 
            this.dtgvtaikhoan.AllowUserToAddRows = false;
            this.dtgvtaikhoan.AllowUserToDeleteRows = false;
            this.dtgvtaikhoan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvtaikhoan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1MaTK,
            this.Column1Usename,
            this.Column1Password});
            this.dtgvtaikhoan.Location = new System.Drawing.Point(125, 282);
            this.dtgvtaikhoan.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtgvtaikhoan.Name = "dtgvtaikhoan";
            this.dtgvtaikhoan.ReadOnly = true;
            this.dtgvtaikhoan.Size = new System.Drawing.Size(593, 180);
            this.dtgvtaikhoan.TabIndex = 4;
            // 
            // Column1MaTK
            // 
            this.Column1MaTK.DataPropertyName = "MaTK";
            this.Column1MaTK.HeaderText = "Mã Tài Khoản";
            this.Column1MaTK.Name = "Column1MaTK";
            this.Column1MaTK.ReadOnly = true;
            // 
            // Column1Usename
            // 
            this.Column1Usename.DataPropertyName = "Usename";
            this.Column1Usename.HeaderText = "Tên Tài Khoản";
            this.Column1Usename.Name = "Column1Usename";
            this.Column1Usename.ReadOnly = true;
            this.Column1Usename.Width = 150;
            // 
            // Column1Password
            // 
            this.Column1Password.DataPropertyName = "Password";
            this.Column1Password.HeaderText = "Mật Khẩu";
            this.Column1Password.Name = "Column1Password";
            this.Column1Password.ReadOnly = true;
            this.Column1Password.Width = 150;
            // 
            // btthoat
            // 
            this.btthoat.Location = new System.Drawing.Point(652, 228);
            this.btthoat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btthoat.Name = "btthoat";
            this.btthoat.Size = new System.Drawing.Size(100, 28);
            this.btthoat.TabIndex = 12;
            this.btthoat.Text = "Thoát";
            this.btthoat.UseVisualStyleBackColor = true;
            this.btthoat.Click += new System.EventHandler(this.btthoat_Click);
            // 
            // btXoa
            // 
            this.btXoa.Location = new System.Drawing.Point(465, 228);
            this.btXoa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(100, 28);
            this.btXoa.TabIndex = 13;
            this.btXoa.Text = "Xóa";
            this.btXoa.UseVisualStyleBackColor = true;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // btSua
            // 
            this.btSua.Location = new System.Drawing.Point(291, 228);
            this.btSua.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(100, 28);
            this.btSua.TabIndex = 14;
            this.btSua.Text = "Sửa";
            this.btSua.UseVisualStyleBackColor = true;
            this.btSua.Click += new System.EventHandler(this.btSua_Click);
            // 
            // btThem
            // 
            this.btThem.Location = new System.Drawing.Point(125, 228);
            this.btThem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(100, 28);
            this.btThem.TabIndex = 15;
            this.btThem.Text = "Thêm";
            this.btThem.UseVisualStyleBackColor = true;
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // txtmatkhau
            // 
            this.txtmatkhau.Location = new System.Drawing.Point(557, 154);
            this.txtmatkhau.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtmatkhau.Name = "txtmatkhau";
            this.txtmatkhau.Size = new System.Drawing.Size(207, 22);
            this.txtmatkhau.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(461, 158);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Mật Khẩu";
            // 
            // txtten
            // 
            this.txtten.Location = new System.Drawing.Point(207, 154);
            this.txtten.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtten.Name = "txtten";
            this.txtten.Size = new System.Drawing.Size(196, 22);
            this.txtten.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(97, 154);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Tên Tài Khoản";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(344, 42);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(176, 24);
            this.label4.TabIndex = 7;
            this.label4.Text = "Quản lý tài khoản";
            // 
            // txtma
            // 
            this.txtma.Location = new System.Drawing.Point(207, 91);
            this.txtma.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtma.Name = "txtma";
            this.txtma.Size = new System.Drawing.Size(196, 22);
            this.txtma.TabIndex = 16;
            this.txtma.TextChanged += new System.EventHandler(this.txtma_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(97, 95);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 17);
            this.label1.TabIndex = 17;
            this.label1.Text = "Mã Tài Khoản";
            // 
            // TaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 507);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtma);
            this.Controls.Add(this.dtgvtaikhoan);
            this.Controls.Add(this.btthoat);
            this.Controls.Add(this.btXoa);
            this.Controls.Add(this.btSua);
            this.Controls.Add(this.btThem);
            this.Controls.Add(this.txtmatkhau);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtten);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "TaiKhoan";
            this.Text = "TaiKhoan";
            this.Load += new System.EventHandler(this.TaiKhoan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvtaikhoan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvtaikhoan;
        private System.Windows.Forms.Button btthoat;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.Button btSua;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.TextBox txtmatkhau;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtten;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtma;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1MaTK;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1Usename;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1Password;
    }
}