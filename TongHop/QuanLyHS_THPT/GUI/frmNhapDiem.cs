using QuanLyHS_THPT.DAL;
using QuanLyHS_THPT.ENTITY;
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
            dgvHocSinh.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            BangDiemDAL bangDiemDAl = new BangDiemDAL();
            this.maMon = Convert.ToInt16(cbMonHoc.SelectedValue.ToString());
            this.maLop = Convert.ToInt16(cbLop.SelectedValue.ToString());
            dgvHocSinh.DataSource= bangDiemDAl.LoadBangDiemHS(this.maMon, this.maLop);
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
            try
            {
                BangDiemDAL bangDiemDAl = new BangDiemDAL();
                this.maMon = Convert.ToInt16(cbMonHoc.SelectedValue.ToString());
                this.maLop = Convert.ToInt16(cbLop.SelectedValue.ToString());
                dgvHocSinh.DataSource = bangDiemDAl.LoadBangDiemHS(maMon, maLop);
                // HienThiDSHocSinh();
            }
            catch { }
        }

        private void dgvHocSinh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int numrow = e.RowIndex;
            lbMaHS.Text = dgvHocSinh.Rows[numrow].Cells[0].Value.ToString();
            lbHoTen.Text = dgvHocSinh.Rows[numrow].Cells[1].Value.ToString();
            tbHocKi.Text = dgvHocSinh.Rows[numrow].Cells[3].Value.ToString();
            tbDMieng.Text= dgvHocSinh.Rows[numrow].Cells[4].Value.ToString();
            tbD15ph.Text = dgvHocSinh.Rows[numrow].Cells[5].Value.ToString();
            tbDMotTiet.Text = dgvHocSinh.Rows[numrow].Cells[6].Value.ToString();
            tbDiemCuoiKi.Text = dgvHocSinh.Rows[numrow].Cells[7].Value.ToString();
           
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            BangDiem bangDiem = new BangDiem();
            try
            {
                bangDiem.MaHocSinh = Convert.ToInt32(lbMaHS.Text);
               
                bangDiem.MaMon = this.maMon;
                bangDiem.HocKi = Convert.ToInt16(tbHocKi.Text);
                if (checkDiem(tbDMieng.Text) == true)
                {
                    bangDiem.DiemMieng = Convert.ToDouble(tbDMieng.Text);
                    if (checkDiem(tbD15ph.Text) == true)
                    {
                        bangDiem.Diem15ph = Convert.ToDouble(tbD15ph.Text);
                        if (checkDiem(tbDMotTiet.Text) == true)
                        {
                            bangDiem.Diem1tiet = Convert.ToDouble(tbDMotTiet.Text);
                            if (checkDiem(tbDiemCuoiKi.Text) == true)
                            {
                                bangDiem.DiemCuoiKi = Convert.ToDouble(tbDiemCuoiKi.Text);
                                bangDiem.DiemTB = (bangDiem.Diem15ph + bangDiem.DiemMieng + bangDiem.Diem1tiet * 2 + bangDiem.DiemCuoiKi * 3)/7.0;
                                BangDiemDAL bangDiemDAl = new BangDiemDAL();
                                bangDiemDAl.updateBangdiem(bangDiem);
                                dgvHocSinh.DataSource = bangDiemDAl.LoadBangDiemHS(maMon, maLop);
                            }
                        }
                    }
                }
            }
            catch
            {
                MessageBox.Show("diem", "Loi");
            }
        }
        private bool checkDiem(string diem)
        {
            try
            {
                double d = Convert.ToDouble(diem);
                if (d >= 0 && d <= 10) return true;
                else
                {
                    MessageBox.Show("Ban nhan sai diem", "Loi");
                }
                return false;
            }
            catch
            {
                MessageBox.Show("Ban nhan sai diem", "Loi");
                return false;
            }
        }
    }
}
