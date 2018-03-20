namespace QuanLyHS_THPT.GUI
{
    partial class frmLop
    {  /// <summary>
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hệThốngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thốngKêToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.txttimkiem = new System.Windows.Forms.TextBox();
            this.txtmagvcn = new System.Windows.Forms.TextBox();
            this.txtsiso = new System.Windows.Forms.TextBox();
            this.txttenlop = new System.Windows.Forms.TextBox();
            this.txtmalop = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnthoat = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnthem = new System.Windows.Forms.Button();
            this.lblmagvcn = new System.Windows.Forms.Label();
            this.lblsiso = new System.Windows.Forms.Label();
            this.lbltenlop = new System.Windows.Forms.Label();
            this.lblmalop = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvLop = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLop)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hệThốngToolStripMenuItem,
            this.thốngKêToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(966, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // hệThốngToolStripMenuItem
            // 
            this.hệThốngToolStripMenuItem.Name = "hệThốngToolStripMenuItem";
            this.hệThốngToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.hệThốngToolStripMenuItem.Text = "Hệ thống";
            // 
            // thốngKêToolStripMenuItem
            // 
            this.thốngKêToolStripMenuItem.Name = "thốngKêToolStripMenuItem";
            this.thốngKêToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.thốngKêToolStripMenuItem.Text = "Thống kê";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.txtmagvcn);
            this.panel1.Controls.Add(this.txtsiso);
            this.panel1.Controls.Add(this.txttenlop);
            this.panel1.Controls.Add(this.txtmalop);
            this.panel1.Controls.Add(this.btnthoat);
            this.panel1.Controls.Add(this.btnsua);
            this.panel1.Controls.Add(this.btnthem);
            this.panel1.Controls.Add(this.lblmagvcn);
            this.panel1.Controls.Add(this.lblsiso);
            this.panel1.Controls.Add(this.lbltenlop);
            this.panel1.Controls.Add(this.lblmalop);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 37);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(223, 350);
            this.panel1.TabIndex = 2;
            // 
            // txttimkiem
            // 
            this.txttimkiem.Location = new System.Drawing.Point(617, 44);
            this.txttimkiem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txttimkiem.Name = "txttimkiem";
            this.txttimkiem.Size = new System.Drawing.Size(113, 20);
            this.txttimkiem.TabIndex = 4;
            this.txttimkiem.TextChanged += new System.EventHandler(this.txttimkiem_TextChanged_1);
            // 
            // txtmagvcn
            // 
            this.txtmagvcn.Location = new System.Drawing.Point(79, 138);
            this.txtmagvcn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtmagvcn.Name = "txtmagvcn";
            this.txtmagvcn.Size = new System.Drawing.Size(125, 20);
            this.txtmagvcn.TabIndex = 3;
            // 
            // txtsiso
            // 
            this.txtsiso.Location = new System.Drawing.Point(79, 111);
            this.txtsiso.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtsiso.Name = "txtsiso";
            this.txtsiso.Size = new System.Drawing.Size(125, 20);
            this.txtsiso.TabIndex = 2;
            // 
            // txttenlop
            // 
            this.txttenlop.Location = new System.Drawing.Point(79, 85);
            this.txttenlop.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txttenlop.Name = "txttenlop";
            this.txttenlop.Size = new System.Drawing.Size(125, 20);
            this.txttenlop.TabIndex = 1;
            // 
            // txtmalop
            // 
            this.txtmalop.Location = new System.Drawing.Point(79, 57);
            this.txtmalop.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtmalop.Name = "txtmalop";
            this.txtmalop.Size = new System.Drawing.Size(125, 20);
            this.txtmalop.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(529, 47);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Search by name";
            // 
            // btnthoat
            // 
            this.btnthoat.Location = new System.Drawing.Point(148, 189);
            this.btnthoat.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(56, 32);
            this.btnthoat.TabIndex = 0;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseVisualStyleBackColor = true;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // btnsua
            // 
            this.btnsua.Location = new System.Drawing.Point(88, 189);
            this.btnsua.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(56, 32);
            this.btnsua.TabIndex = 0;
            this.btnsua.Text = "Sửa";
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnthem
            // 
            this.btnthem.Location = new System.Drawing.Point(22, 189);
            this.btnthem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(56, 32);
            this.btnthem.TabIndex = 0;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // lblmagvcn
            // 
            this.lblmagvcn.AutoSize = true;
            this.lblmagvcn.Location = new System.Drawing.Point(20, 141);
            this.lblmagvcn.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblmagvcn.Name = "lblmagvcn";
            this.lblmagvcn.Size = new System.Drawing.Size(55, 13);
            this.lblmagvcn.TabIndex = 0;
            this.lblmagvcn.Text = "Mã GVCN";
            // 
            // lblsiso
            // 
            this.lblsiso.AutoSize = true;
            this.lblsiso.Location = new System.Drawing.Point(20, 114);
            this.lblsiso.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblsiso.Name = "lblsiso";
            this.lblsiso.Size = new System.Drawing.Size(33, 13);
            this.lblsiso.TabIndex = 0;
            this.lblsiso.Text = "Sĩ số";
            // 
            // lbltenlop
            // 
            this.lbltenlop.AutoSize = true;
            this.lbltenlop.Location = new System.Drawing.Point(20, 89);
            this.lbltenlop.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbltenlop.Name = "lbltenlop";
            this.lbltenlop.Size = new System.Drawing.Size(43, 13);
            this.lbltenlop.TabIndex = 0;
            this.lbltenlop.Text = "Tên lớp";
            this.lbltenlop.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblmalop
            // 
            this.lblmalop.AutoSize = true;
            this.lblmalop.Location = new System.Drawing.Point(20, 61);
            this.lblmalop.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblmalop.Name = "lblmalop";
            this.lblmalop.Size = new System.Drawing.Size(39, 13);
            this.lblmalop.TabIndex = 0;
            this.lblmalop.Text = "Mã lớp";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập dữ liệu lớp";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel2.Controls.Add(this.txttimkiem);
            this.panel2.Controls.Add(this.dgvLop);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Location = new System.Drawing.Point(225, 37);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(740, 350);
            this.panel2.TabIndex = 3;
            // 
            // dgvLop
            // 
            this.dgvLop.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvLop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLop.Location = new System.Drawing.Point(2, 77);
            this.dgvLop.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvLop.Name = "dgvLop";
            this.dgvLop.RowTemplate.Height = 24;
            this.dgvLop.Size = new System.Drawing.Size(736, 270);
            this.dgvLop.TabIndex = 1;
            this.dgvLop.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLop_CellClick_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 23);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(281, 29);
            this.label2.TabIndex = 0;
            this.label2.Text = "DANH SÁCH LỚP HỌC";
            // 
            // frmLop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 387);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmLop";
            this.Text = "Danh sách lớp học";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLop)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hệThốngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thốngKêToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblmalop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbltenlop;
        private System.Windows.Forms.TextBox txttimkiem;
        private System.Windows.Forms.TextBox txtmagvcn;
        private System.Windows.Forms.TextBox txtsiso;
        private System.Windows.Forms.TextBox txttenlop;
        private System.Windows.Forms.TextBox txtmalop;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.Label lblmagvcn;
        private System.Windows.Forms.Label lblsiso;
        private System.Windows.Forms.DataGridView dgvLop;
        private System.Windows.Forms.Label label2;
    }
}