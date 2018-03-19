namespace QuanLyHS_THPT.GUI
{
    partial class frmNhapGiaoVien
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
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.dtpgv = new System.Windows.Forms.DateTimePicker();
            this.tbSdt = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btxoa = new System.Windows.Forms.Button();
            this.btSua = new System.Windows.Forms.Button();
            this.btThem = new System.Windows.Forms.Button();
            this.rbNu = new System.Windows.Forms.RadioButton();
            this.rbNam = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbChuyenMon = new System.Windows.Forms.TextBox();
            this.tbĐiaChi = new System.Windows.Forms.TextBox();
            this.tbNoiSinh = new System.Windows.Forms.TextBox();
            this.tbHoTen = new System.Windows.Forms.TextBox();
            this.tbMagv = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tbTimKIem = new System.Windows.Forms.TextBox();
            this.dgvGiaoVien = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.pnlMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGiaoVien)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMenu
            // 
            this.pnlMenu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlMenu.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlMenu.Controls.Add(this.dtpgv);
            this.pnlMenu.Controls.Add(this.tbSdt);
            this.pnlMenu.Controls.Add(this.label11);
            this.pnlMenu.Controls.Add(this.btxoa);
            this.pnlMenu.Controls.Add(this.btSua);
            this.pnlMenu.Controls.Add(this.btThem);
            this.pnlMenu.Controls.Add(this.rbNu);
            this.pnlMenu.Controls.Add(this.rbNam);
            this.pnlMenu.Controls.Add(this.label8);
            this.pnlMenu.Controls.Add(this.label7);
            this.pnlMenu.Controls.Add(this.tbChuyenMon);
            this.pnlMenu.Controls.Add(this.tbĐiaChi);
            this.pnlMenu.Controls.Add(this.tbNoiSinh);
            this.pnlMenu.Controls.Add(this.tbHoTen);
            this.pnlMenu.Controls.Add(this.tbMagv);
            this.pnlMenu.Controls.Add(this.label6);
            this.pnlMenu.Controls.Add(this.label5);
            this.pnlMenu.Controls.Add(this.label4);
            this.pnlMenu.Controls.Add(this.label3);
            this.pnlMenu.Controls.Add(this.label2);
            this.pnlMenu.Controls.Add(this.label1);
            this.pnlMenu.Location = new System.Drawing.Point(12, 11);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(232, 364);
            this.pnlMenu.TabIndex = 2;
            // 
            // dtpgv
            // 
            this.dtpgv.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpgv.Location = new System.Drawing.Point(87, 126);
            this.dtpgv.Name = "dtpgv";
            this.dtpgv.Size = new System.Drawing.Size(120, 20);
            this.dtpgv.TabIndex = 13;
            // 
            // tbSdt
            // 
            this.tbSdt.Location = new System.Drawing.Point(87, 234);
            this.tbSdt.Name = "tbSdt";
            this.tbSdt.Size = new System.Drawing.Size(120, 20);
            this.tbSdt.TabIndex = 12;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(14, 237);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(34, 13);
            this.label11.TabIndex = 11;
            this.label11.Text = "Số Đt";
            // 
            // btxoa
            // 
            this.btxoa.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btxoa.Location = new System.Drawing.Point(146, 278);
            this.btxoa.Name = "btxoa";
            this.btxoa.Size = new System.Drawing.Size(60, 25);
            this.btxoa.TabIndex = 10;
            this.btxoa.Text = "Xóa";
            this.btxoa.UseVisualStyleBackColor = true;
            this.btxoa.Click += new System.EventHandler(this.btxoa_Click);
            // 
            // btSua
            // 
            this.btSua.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSua.Location = new System.Drawing.Point(80, 278);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(60, 25);
            this.btSua.TabIndex = 10;
            this.btSua.Text = "Sửa";
            this.btSua.UseVisualStyleBackColor = true;
            this.btSua.Click += new System.EventHandler(this.btSua_Click);
            // 
            // btThem
            // 
            this.btThem.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThem.Location = new System.Drawing.Point(11, 278);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(60, 25);
            this.btThem.TabIndex = 9;
            this.btThem.Text = "Thêm";
            this.btThem.UseVisualStyleBackColor = true;
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // rbNu
            // 
            this.rbNu.AutoSize = true;
            this.rbNu.Location = new System.Drawing.Point(155, 102);
            this.rbNu.Name = "rbNu";
            this.rbNu.Size = new System.Drawing.Size(39, 17);
            this.rbNu.TabIndex = 4;
            this.rbNu.TabStop = true;
            this.rbNu.Text = "Nữ";
            this.rbNu.UseVisualStyleBackColor = true;
            // 
            // rbNam
            // 
            this.rbNam.AutoSize = true;
            this.rbNam.Location = new System.Drawing.Point(87, 102);
            this.rbNam.Name = "rbNam";
            this.rbNam.Size = new System.Drawing.Size(47, 17);
            this.rbNam.TabIndex = 3;
            this.rbNam.TabStop = true;
            this.rbNam.Text = "Nam";
            this.rbNam.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 130);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Ngày sinh";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 104);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Giới tính";
            // 
            // tbChuyenMon
            // 
            this.tbChuyenMon.Location = new System.Drawing.Point(87, 205);
            this.tbChuyenMon.Name = "tbChuyenMon";
            this.tbChuyenMon.Size = new System.Drawing.Size(120, 20);
            this.tbChuyenMon.TabIndex = 8;
            // 
            // tbĐiaChi
            // 
            this.tbĐiaChi.Location = new System.Drawing.Point(86, 178);
            this.tbĐiaChi.Name = "tbĐiaChi";
            this.tbĐiaChi.Size = new System.Drawing.Size(120, 20);
            this.tbĐiaChi.TabIndex = 7;
            // 
            // tbNoiSinh
            // 
            this.tbNoiSinh.Location = new System.Drawing.Point(86, 153);
            this.tbNoiSinh.Name = "tbNoiSinh";
            this.tbNoiSinh.Size = new System.Drawing.Size(120, 20);
            this.tbNoiSinh.TabIndex = 6;
            // 
            // tbHoTen
            // 
            this.tbHoTen.Location = new System.Drawing.Point(87, 77);
            this.tbHoTen.Name = "tbHoTen";
            this.tbHoTen.Size = new System.Drawing.Size(120, 20);
            this.tbHoTen.TabIndex = 2;
            // 
            // tbMagv
            // 
            this.tbMagv.Location = new System.Drawing.Point(86, 51);
            this.tbMagv.Name = "tbMagv";
            this.tbMagv.Size = new System.Drawing.Size(120, 20);
            this.tbMagv.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 208);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Chuyên Môn";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 181);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Địa Chỉ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Nơi sinh";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Họ và tên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã GV";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập dữ liệu Giáo Viên";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(691, 34);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(86, 13);
            this.label10.TabIndex = 14;
            this.label10.Text = "Search by Name";
            // 
            // tbTimKIem
            // 
            this.tbTimKIem.Location = new System.Drawing.Point(783, 34);
            this.tbTimKIem.Name = "tbTimKIem";
            this.tbTimKIem.Size = new System.Drawing.Size(144, 20);
            this.tbTimKIem.TabIndex = 15;
            this.tbTimKIem.TextChanged += new System.EventHandler(this.tbTimKIem_TextChanged);
            // 
            // dgvGiaoVien
            // 
            this.dgvGiaoVien.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvGiaoVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGiaoVien.Location = new System.Drawing.Point(250, 88);
            this.dgvGiaoVien.Name = "dgvGiaoVien";
            this.dgvGiaoVien.Size = new System.Drawing.Size(704, 287);
            this.dgvGiaoVien.TabIndex = 13;
            this.dgvGiaoVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGiaoVien_CellClick);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(262, 24);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(226, 26);
            this.label9.TabIndex = 12;
            this.label9.Text = "Danh sách Giáo Viên";
            // 
            // frmNhapGiaoVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 387);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.tbTimKIem);
            this.Controls.Add(this.dgvGiaoVien);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.pnlMenu);
            this.Name = "frmNhapGiaoVien";
            this.Text = "frmNhapGiaoVien";
            this.pnlMenu.ResumeLayout(false);
            this.pnlMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGiaoVien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Button btxoa;
        private System.Windows.Forms.Button btSua;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.RadioButton rbNu;
        private System.Windows.Forms.RadioButton rbNam;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbChuyenMon;
        private System.Windows.Forms.TextBox tbĐiaChi;
        private System.Windows.Forms.TextBox tbNoiSinh;
        private System.Windows.Forms.TextBox tbHoTen;
        private System.Windows.Forms.TextBox tbMagv;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbTimKIem;
        private System.Windows.Forms.DataGridView dgvGiaoVien;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbSdt;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker dtpgv;
    }
}