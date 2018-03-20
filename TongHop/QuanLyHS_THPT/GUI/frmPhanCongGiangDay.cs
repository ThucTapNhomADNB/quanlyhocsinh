using QuanLyHS_THPT.DAL;
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
    public partial class frmPhanCongGiangDay : Form
    {
        private int magv = 0;
        private int malop = 0;
        private int mamon = 0;
        public frmPhanCongGiangDay()
        {
            InitializeComponent();
            HienThiDSLopMon();
            LoadGV();
        }
        private void HienThiDSLopMon()
        {
            dgvLopMon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            PhanCongGiangDayDAL LopMonDAL = new PhanCongGiangDayDAL();
            dgvLopMon.DataSource = LopMonDAL.LayMonLop();
        }
        private void LoadGV()
        {
            GiaoVienDAL gvDAL = new GiaoVienDAL();
            DataTable dataGV = gvDAL.LoadDS();
            cbGiaoVien.DataSource = dataGV;
            cbGiaoVien.DisplayMember = "HOTEN";
            cbGiaoVien.ValueMember = "MAGIAOVIEN";

        }
        private void dgvLopMon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int numrow = e.RowIndex;
            if(dgvLopMon.Rows[numrow].Cells[4].Value.ToString()!="")
            {
                int maGV = Convert.ToInt32(dgvLopMon.Rows[numrow].Cells[4].Value.ToString());
                cbGiaoVien.SelectedValue = maGV;
                GiaoVienDAL gvDAL = new GiaoVienDAL();
                GiaoVien gv = gvDAL.getGiaoVien(maGV);
                lbMaGV.Text = gv.MaGiaoVien.ToString();
                lbName.Text = gv.HoTen;
                lbChuyenMon.Text = gv.ChuyenMon;
                

            }
            //textBox1.Text = dgvLopMon.Rows[numrow].Cells[0].Value.ToString();
            this.mamon = Convert.ToInt16(dgvLopMon.Rows[numrow].Cells[2].Value.ToString());
            this.malop = Convert.ToInt16(dgvLopMon.Rows[numrow].Cells[0].Value.ToString());
        }

        private void cbLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int ma = Convert.ToInt16(cbGiaoVien.SelectedValue.ToString());

                GiaoVienDAL gvDAL = new GiaoVienDAL();
                GiaoVien gv = gvDAL.getGiaoVien(ma);
                lbMaGV.Text = gv.MaGiaoVien.ToString();
                lbName.Text = gv.HoTen;
                lbChuyenMon.Text = gv.ChuyenMon;
                this.magv = ma;
            }
            catch
            {
            }     
        }

        private void btPhanCong_Click(object sender, EventArgs e)
        {
           // if(magv!=0 &&mamon!=0&& malop!=0)
            {
                PhanCongGiangDayDAL LopMonDAL = new PhanCongGiangDayDAL();
                LopMonDAL.PhanCong(this.mamon, this.malop, this.magv);
                
                HienThiDSLopMon();
                this.magv = 0;
                this.malop = 0;
                this.mamon = 0;
            }
            //else
            //{
            //    MessageBox.Show("heheh", "");
            //}
        }

       
    }
}
