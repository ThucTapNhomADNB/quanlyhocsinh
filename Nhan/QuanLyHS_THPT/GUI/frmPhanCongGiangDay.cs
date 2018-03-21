using QuanLyHS_THPT.DAL;
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
    public partial class frmPhanCongGiangDay : Form
    {
        public frmPhanCongGiangDay()
        {
            InitializeComponent();
            HienThiDSGiaoVien();
            LoadLop();
            LoadMon();
        }
        private void HienThiDSGiaoVien()
        {
            dgvGiaoVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            GiaoVienDAL gvDAL = new GiaoVienDAL();
            dgvGiaoVien.DataSource = gvDAL.LoadDS();
        }
        private void LoadLop()
        {
            LopDAL LOPdal = new LopDAL();
            DataTable dataLop = LOPdal.LoadDS();
            cbLop.DataSource = dataLop;
            cbLop.DisplayMember = "TENLOP";
            cbLop.ValueMember = "MALOP";

        }

        private void LoadMon()
        {
            MonHocDAL mondal = new MonHocDAL();
            DataTable dataLop = mondal.LoadDS();
            cbMon.DataSource = dataLop;
            cbMon.DisplayMember = "TENMONHOC";
            cbMon.ValueMember = "MAMONHOC";
        }
        private void dgvGiaoVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lbMaGV.Text = dgvGiaoVien.CurrentRow.Cells[0].Value.ToString();
            lbName.Text = dgvGiaoVien.CurrentRow.Cells[1].Value.ToString();
            lbChuyenMon.Text = dgvGiaoVien.CurrentRow.Cells[6].Value.ToString();
        }
    }
}
