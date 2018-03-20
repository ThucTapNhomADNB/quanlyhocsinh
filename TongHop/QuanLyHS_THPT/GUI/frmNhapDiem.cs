using QuanLyHS_THPT.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyHS_THPT.GUI
{
    public partial class frmNhapDiem : Form
    {
        private int maLop = 0;
        private int maMon = 0;

        public frmNhapDiem()
        {
            InitializeComponent();
            LoadLop();
            LoadMon();
            HienThiDSHocSinh();
        }
        private void HienThiDSHocSinh()
        {
            //dgvGiaoVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            //GiaoVienDAL gvDAL = new GiaoVienDAL();
            //dgvGiaoVien.DataSource = gvDAL.LoadDS();
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
            cbMonHoc.DataSource = dataLop;
            cbMonHoc.DisplayMember = "TENMONHOC";
            cbMonHoc.ValueMember = "MAMONHOC";
        }

        private void cbLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void cbMonHoc_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
