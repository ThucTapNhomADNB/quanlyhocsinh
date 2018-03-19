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

        private void hồSơGiáoViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNhapGiaoVien frmNhapGv = new frmNhapGiaoVien();
            frmNhapGv.ShowDialog();
        }
    }
}
