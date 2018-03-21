namespace QuanLyHS_THPT.GUI
{
    partial class frmKQHT
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblmagvcn = new System.Windows.Forms.Label();
            this.lblsiso = new System.Windows.Forms.Label();
            this.lblmalop = new System.Windows.Forms.Label();
            this.cblop = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvdslop = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdslop)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.Info;
            this.panel1.Controls.Add(this.lblmagvcn);
            this.panel1.Controls.Add(this.lblsiso);
            this.panel1.Controls.Add(this.lblmalop);
            this.panel1.Controls.Add(this.cblop);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(331, 452);
            this.panel1.TabIndex = 0;
            // 
            // lblmagvcn
            // 
            this.lblmagvcn.AutoSize = true;
            this.lblmagvcn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmagvcn.Location = new System.Drawing.Point(177, 276);
            this.lblmagvcn.Name = "lblmagvcn";
            this.lblmagvcn.Size = new System.Drawing.Size(71, 18);
            this.lblmagvcn.TabIndex = 2;
            this.lblmagvcn.Text = "mã gvcn";
            // 
            // lblsiso
            // 
            this.lblsiso.AutoSize = true;
            this.lblsiso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsiso.Location = new System.Drawing.Point(177, 225);
            this.lblsiso.Name = "lblsiso";
            this.lblsiso.Size = new System.Drawing.Size(45, 18);
            this.lblsiso.TabIndex = 2;
            this.lblsiso.Text = "sĩ số";
            // 
            // lblmalop
            // 
            this.lblmalop.AutoSize = true;
            this.lblmalop.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmalop.Location = new System.Drawing.Point(177, 177);
            this.lblmalop.Name = "lblmalop";
            this.lblmalop.Size = new System.Drawing.Size(59, 18);
            this.lblmalop.TabIndex = 2;
            this.lblmalop.Text = "mã lớp";
            // 
            // cblop
            // 
            this.cblop.FormattingEnabled = true;
            this.cblop.Location = new System.Drawing.Point(68, 102);
            this.cblop.Name = "cblop";
            this.cblop.Size = new System.Drawing.Size(136, 24);
            this.cblop.TabIndex = 1;
            this.cblop.SelectedIndexChanged += new System.EventHandler(this.cblop_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(30, 276);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 18);
            this.label5.TabIndex = 1;
            this.label5.Text = "Mã GVCN";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(30, 225);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 18);
            this.label4.TabIndex = 1;
            this.label4.Text = "Sĩ số";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(30, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 18);
            this.label3.TabIndex = 1;
            this.label3.Text = "Mã lớp";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(88, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Chọn lớp";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kết quả học tập";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(376, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(256, 32);
            this.label6.TabIndex = 1;
            this.label6.Text = "DANH SÁCH LỚP";
            // 
            // dgvdslop
            // 
            this.dgvdslop.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvdslop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdslop.Location = new System.Drawing.Point(339, 104);
            this.dgvdslop.Name = "dgvdslop";
            this.dgvdslop.RowTemplate.Height = 24;
            this.dgvdslop.Size = new System.Drawing.Size(413, 347);
            this.dgvdslop.TabIndex = 2;
            // 
            // frmKQHT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 451);
            this.Controls.Add(this.dgvdslop);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel1);
            this.Name = "frmKQHT";
            this.Text = "frmKQHT";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdslop)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cblop;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblmagvcn;
        private System.Windows.Forms.Label lblsiso;
        private System.Windows.Forms.Label lblmalop;
        private System.Windows.Forms.DataGridView dgvdslop;
    }
}