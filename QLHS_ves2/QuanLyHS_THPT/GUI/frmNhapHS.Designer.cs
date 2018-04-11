namespace QuanLyHS_THPT.GUI
{
    partial class frmNhapHS
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
            this.menu = new System.Windows.Forms.MenuStrip();
            this.mnuSystem = new System.Windows.Forms.ToolStripMenuItem();
            this.thốngKêToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.btxoa = new System.Windows.Forms.Button();
            this.btSua = new System.Windows.Forms.Button();
            this.btThem = new System.Windows.Forms.Button();
            this.rbNu = new System.Windows.Forms.RadioButton();
            this.rbNam = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbTonGiao = new System.Windows.Forms.TextBox();
            this.tbDanToc = new System.Windows.Forms.TextBox();
            this.tbNoiSinh = new System.Windows.Forms.TextBox();
            this.tbHoTen = new System.Windows.Forms.TextBox();
            this.tbMaHs = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.tbTimKIem = new System.Windows.Forms.TextBox();
            this.dgvHocSinh = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.dgvLop = new System.Windows.Forms.DataGridView();
            this.btXoaLop = new System.Windows.Forms.Button();
            this.cbLop = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btThemLop = new System.Windows.Forms.Button();
            this.menu.SuspendLayout();
            this.pnlMenu.SuspendLayout();
            this.pnlContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHocSinh)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLop)).BeginInit();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuSystem,
            this.thốngKêToolStripMenuItem});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(1207, 24);
            this.menu.TabIndex = 0;
            this.menu.Text = "menuStrip1";
            // 
            // mnuSystem
            // 
            this.mnuSystem.Name = "mnuSystem";
            this.mnuSystem.Size = new System.Drawing.Size(69, 20);
            this.mnuSystem.Text = "Hệ thống";
            // 
            // thốngKêToolStripMenuItem
            // 
            this.thốngKêToolStripMenuItem.Name = "thốngKêToolStripMenuItem";
            this.thốngKêToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.thốngKêToolStripMenuItem.Text = "Thống kê";
            // 
            // pnlMenu
            // 
            this.pnlMenu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlMenu.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlMenu.Controls.Add(this.dtpNgaySinh);
            this.pnlMenu.Controls.Add(this.btxoa);
            this.pnlMenu.Controls.Add(this.btSua);
            this.pnlMenu.Controls.Add(this.btThem);
            this.pnlMenu.Controls.Add(this.rbNu);
            this.pnlMenu.Controls.Add(this.rbNam);
            this.pnlMenu.Controls.Add(this.label8);
            this.pnlMenu.Controls.Add(this.label7);
            this.pnlMenu.Controls.Add(this.tbTonGiao);
            this.pnlMenu.Controls.Add(this.tbDanToc);
            this.pnlMenu.Controls.Add(this.tbNoiSinh);
            this.pnlMenu.Controls.Add(this.tbHoTen);
            this.pnlMenu.Controls.Add(this.tbMaHs);
            this.pnlMenu.Controls.Add(this.label6);
            this.pnlMenu.Controls.Add(this.label5);
            this.pnlMenu.Controls.Add(this.label4);
            this.pnlMenu.Controls.Add(this.label3);
            this.pnlMenu.Controls.Add(this.label2);
            this.pnlMenu.Controls.Add(this.label1);
            this.pnlMenu.Location = new System.Drawing.Point(0, 27);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(212, 403);
            this.pnlMenu.TabIndex = 1;
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgaySinh.Location = new System.Drawing.Point(74, 126);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(120, 20);
            this.dtpNgaySinh.TabIndex = 11;
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
            this.btxoa.Click += new System.EventHandler(this.btXoa_Click);
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
            this.rbNu.Location = new System.Drawing.Point(135, 102);
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
            this.rbNam.Location = new System.Drawing.Point(74, 102);
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
            // tbTonGiao
            // 
            this.tbTonGiao.Location = new System.Drawing.Point(74, 205);
            this.tbTonGiao.Name = "tbTonGiao";
            this.tbTonGiao.Size = new System.Drawing.Size(120, 20);
            this.tbTonGiao.TabIndex = 8;
            // 
            // tbDanToc
            // 
            this.tbDanToc.Location = new System.Drawing.Point(74, 178);
            this.tbDanToc.Name = "tbDanToc";
            this.tbDanToc.Size = new System.Drawing.Size(120, 20);
            this.tbDanToc.TabIndex = 7;
            // 
            // tbNoiSinh
            // 
            this.tbNoiSinh.Location = new System.Drawing.Point(74, 152);
            this.tbNoiSinh.Name = "tbNoiSinh";
            this.tbNoiSinh.Size = new System.Drawing.Size(120, 20);
            this.tbNoiSinh.TabIndex = 6;
            // 
            // tbHoTen
            // 
            this.tbHoTen.Location = new System.Drawing.Point(74, 74);
            this.tbHoTen.Name = "tbHoTen";
            this.tbHoTen.Size = new System.Drawing.Size(120, 20);
            this.tbHoTen.TabIndex = 2;
            // 
            // tbMaHs
            // 
            this.tbMaHs.Location = new System.Drawing.Point(74, 51);
            this.tbMaHs.Name = "tbMaHs";
            this.tbMaHs.Size = new System.Drawing.Size(120, 20);
            this.tbMaHs.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 208);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Tôn giáo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 181);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Dân tộc";
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
            this.label2.Text = "Mã HS";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập dữ liệu học sinh";
            // 
            // pnlContent
            // 
            this.pnlContent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlContent.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.pnlContent.Controls.Add(this.label10);
            this.pnlContent.Controls.Add(this.tbTimKIem);
            this.pnlContent.Controls.Add(this.dgvHocSinh);
            this.pnlContent.Controls.Add(this.label9);
            this.pnlContent.Location = new System.Drawing.Point(218, 27);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(698, 403);
            this.pnlContent.TabIndex = 2;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(419, 41);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(86, 13);
            this.label10.TabIndex = 8;
            this.label10.Text = "Search by Name";
            // 
            // tbTimKIem
            // 
            this.tbTimKIem.Location = new System.Drawing.Point(528, 41);
            this.tbTimKIem.Name = "tbTimKIem";
            this.tbTimKIem.Size = new System.Drawing.Size(144, 20);
            this.tbTimKIem.TabIndex = 11;
            this.tbTimKIem.TextChanged += new System.EventHandler(this.tbTimKIem_TextChanged);
            // 
            // dgvHocSinh
            // 
            this.dgvHocSinh.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvHocSinh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHocSinh.Location = new System.Drawing.Point(8, 64);
            this.dgvHocSinh.Name = "dgvHocSinh";
            this.dgvHocSinh.Size = new System.Drawing.Size(664, 327);
            this.dgvHocSinh.TabIndex = 2;
            this.dgvHocSinh.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHocSinh_CellClick);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(15, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(348, 26);
            this.label9.TabIndex = 1;
            this.label9.Text = "Danh sách học sinh toàn trường  ";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.btThemLop);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.cbLop);
            this.panel1.Controls.Add(this.btXoaLop);
            this.panel1.Controls.Add(this.dgvLop);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Location = new System.Drawing.Point(924, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(282, 398);
            this.panel1.TabIndex = 3;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(23, 11);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(219, 18);
            this.label11.TabIndex = 1;
            this.label11.Text = "Danh sách các lớp của học sinh";
            // 
            // dgvLop
            // 
            this.dgvLop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLop.Location = new System.Drawing.Point(26, 44);
            this.dgvLop.Name = "dgvLop";
            this.dgvLop.Size = new System.Drawing.Size(240, 150);
            this.dgvLop.TabIndex = 2;
            this.dgvLop.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLop_CellClick);
            // 
            // btXoaLop
            // 
            this.btXoaLop.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btXoaLop.Location = new System.Drawing.Point(119, 204);
            this.btXoaLop.Name = "btXoaLop";
            this.btXoaLop.Size = new System.Drawing.Size(60, 25);
            this.btXoaLop.TabIndex = 12;
            this.btXoaLop.Text = "Xóa";
            this.btXoaLop.UseVisualStyleBackColor = true;
            this.btXoaLop.Click += new System.EventHandler(this.btXoaLop_Click);
            // 
            // cbLop
            // 
            this.cbLop.FormattingEnabled = true;
            this.cbLop.Location = new System.Drawing.Point(40, 274);
            this.cbLop.Name = "cbLop";
            this.cbLop.Size = new System.Drawing.Size(139, 21);
            this.cbLop.TabIndex = 13;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Tempus Sans ITC", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(116, 246);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(71, 17);
            this.label12.TabIndex = 12;
            this.label12.Text = "Thêm Lớp";
            // 
            // btThemLop
            // 
            this.btThemLop.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThemLop.Location = new System.Drawing.Point(195, 274);
            this.btThemLop.Name = "btThemLop";
            this.btThemLop.Size = new System.Drawing.Size(60, 25);
            this.btThemLop.TabIndex = 12;
            this.btThemLop.Text = "Thêm";
            this.btThemLop.UseVisualStyleBackColor = true;
            this.btThemLop.Click += new System.EventHandler(this.btThemLop_Click);
            // 
            // frmNhapHS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1207, 430);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(this.menu);
            this.MainMenuStrip = this.menu;
            this.Name = "frmNhapHS";
            this.Text = "Hồ sơ Học sinh";
            this.Load += new System.EventHandler(this.frmNhapHS_Load);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.pnlMenu.ResumeLayout(false);
            this.pnlMenu.PerformLayout();
            this.pnlContent.ResumeLayout(false);
            this.pnlContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHocSinh)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLop)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem mnuSystem;
        private System.Windows.Forms.ToolStripMenuItem thốngKêToolStripMenuItem;
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.Button btxoa;
        private System.Windows.Forms.Button btSua;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.RadioButton rbNu;
        private System.Windows.Forms.RadioButton rbNam;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbTonGiao;
        private System.Windows.Forms.TextBox tbDanToc;
        private System.Windows.Forms.TextBox tbNoiSinh;
        private System.Windows.Forms.TextBox tbHoTen;
        private System.Windows.Forms.TextBox tbMaHs;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dgvHocSinh;
        private System.Windows.Forms.TextBox tbTimKIem;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btXoaLop;
        private System.Windows.Forms.DataGridView dgvLop;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btThemLop;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cbLop;
    }
}