using QuanLyHS_THPT.ENTITY;
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
        private Account acc = new Account();
        public MainForm(string username, string password)
        {
            InitializeComponent();
            acc.Usename = username;
            acc.Password = password;
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
           this.Hide();
            frmDangNhap FrmDN = new frmDangNhap();
            FrmDN.ShowDialog();
           this.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
           this.Hide();
            frmDangNhap FrmDN = new frmDangNhap();
            FrmDN.ShowDialog();
            this.Show();
        }

        private void đôiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDoiMatKhau FrmDoiPass = new frmDoiMatKhau(acc.Usename,acc.Password);
            FrmDoiPass.ShowDialog();

        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
