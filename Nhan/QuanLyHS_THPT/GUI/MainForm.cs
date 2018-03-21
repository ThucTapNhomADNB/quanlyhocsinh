using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyHS_THPT.GUI
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void hồSơHọcSinhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNhapHS FrmNhapHs = new frmNhapHS();
            FrmNhapHs.ShowDialog();
        }

        private void danhSáchMônHọcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMonHoc FrmMonHoc = new frmMonHoc();
            FrmMonHoc.ShowDialog();
        }

        private void nhậpĐiểmHọcSinhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNhapDiem FrmNhapDiem = new frmNhapDiem();
            FrmNhapDiem.ShowDialog();
        }

        private void hồSơGiáoViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNhapGiaoVien FrmNhapGiaoVien = new frmNhapGiaoVien();
            FrmNhapGiaoVien.ShowDialog();
        }

        private void danhSáchLớpHọcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLop FrmLop = new frmLop();
            FrmLop.ShowDialog();
        }

        private void phânCôngGiảngDạyToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmPhanCongGiangDay FrmPCGiangDay = new frmPhanCongGiangDay();
            FrmPCGiangDay.ShowDialog();
        }

        private void kếtQuảHọcTậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmKQHT FrmKQHT = new frmKQHT();
            FrmKQHT.ShowDialog();
        }

        private void đăngNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDangNhap FrmDN = new frmDangNhap();
            FrmDN.ShowDialog();
        }
    }
}
