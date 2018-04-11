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
    public partial class frmLop : Form
    {
        public frmLop()
        {
            InitializeComponent();
            HienThiDSLop();
            LoadGVCN();
            LoadMon();
            LoadGVBM();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void HienThiDSLop()
        {
            dgvLop.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            LopDAL hsDAL = new LopDAL();
            dgvLop.DataSource = hsDAL.LoadDS();

        }
        private void HienThiDSMonLop()
        {
            LopDAL lopdal = new LopDAL();
            try
            {
                int ma = Convert.ToInt32(txtmalop.Text);
                DataTable data = lopdal.getMonLop(ma);
                dgvMonLop.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvMonLop.DataSource = data;
            }
            catch
            {

            }
        }
        private void LoadGVCN()
        {
            GiaoVienDAL gvDAL = new GiaoVienDAL();
            DataTable dataGV = gvDAL.LoadDS();
            cbGiaoVien.DataSource = dataGV;
            cbGiaoVien.DisplayMember = "HOTEN";
            cbGiaoVien.ValueMember = "MAGIAOVIEN";

        }
        private void LoadGVBM()
        {
            GiaoVienDAL gvDAL = new GiaoVienDAL();
            DataTable dataGV = gvDAL.LoadDS();
            cbGVBM.DataSource = dataGV;
            cbGVBM.DisplayMember = "HOTEN";
            cbGVBM.ValueMember = "MAGIAOVIEN";

        }

        private void LoadMon()
        {
            MonHocDAL mondal = new MonHocDAL();
            DataTable data = mondal.LoadDS();
            cbMon.DataSource = data;
            cbMon.DisplayMember = "TENMONHOC";
            cbMon.ValueMember = "MAMONHOC";
        }
        private void dgvLop_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int numRow;
            numRow = e.RowIndex;
            txtmalop.Text = dgvLop.Rows[numRow].Cells[0].Value.ToString();
            txttenlop.Text = dgvLop.Rows[numRow].Cells[1].Value.ToString();
            txtsiso.Text = dgvLop.Rows[numRow].Cells[2].Value.ToString();
            //   txtmagvcn.Text = dgvLop.Rows[numRow].Cells[3].Value.ToString();
            if (dgvLop.Rows[numRow].Cells[3].Value.ToString() != "")
            {
                int maGV = Convert.ToInt32(dgvLop.Rows[numRow].Cells[3].Value.ToString());
                cbGiaoVien.SelectedValue = maGV;
            }
            HienThiDSMonLop();
            
           
            
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            Lop l = new Lop();
            LopDAL lDAL = new LopDAL();

            if (txtmalop.TextLength != 0)
            {
                MessageBox.Show("Không cần nhập mã lớp", " lỗi ");
            }
            else
            {
                if (txttenlop.TextLength == 0)
                {
                    MessageBox.Show("Chưa nhập tên lớp", " lỗi ");
                }
                else
                {
                    l.TenLop = txttenlop.Text;
                    if (txtsiso.TextLength == 0)
                    {
                        MessageBox.Show(" Chưa nhập sĩ số", "lỗi");
                    }
                    else
                    {
                        l.SiSo = Convert.ToInt16(txtsiso.Text);

                        try
                        {
                            int maGV = Convert.ToInt16(cbGiaoVien.SelectedValue.ToString());
                            l.MaGVCN = maGV;
                            lDAL.insertLOP(l);
                            dgvLop.DataSource = lDAL.LoadDS();

                        }
                        catch
                        {
                        }

                    }
                }
            }
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            Lop l = new Lop();
            l.MaLop = Convert.ToInt32(txtmalop.Text);
            LopDAL lDAL = new LopDAL();

            if (txtmalop.Text != l.MaLop.ToString())
            {
                MessageBox.Show("Không được sửa mã lớp", " lỗi ");
            }
            else
            {
                if (txttenlop.TextLength == 0)
                {
                    MessageBox.Show("Chưa nhập tên lớp", " lỗi ");
                }
                else
                {
                    l.TenLop = txttenlop.Text;
                    if (txtsiso.TextLength == 0)
                    {
                        MessageBox.Show(" Chưa nhập sĩ số", "lỗi");
                    }
                    else
                    {
                        l.SiSo = Convert.ToInt16(txtsiso.Text);
                        try
                        {
                            int maGV = Convert.ToInt16(cbGiaoVien.SelectedValue.ToString());
                            l.MaGVCN = maGV;
                            lDAL.SuaLop(l);
                            dgvLop.DataSource = lDAL.LoadDS();

                        }
                        catch
                        {
                        }
                       
                    }
                }
            }
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();// dong form
            this.Dispose();// Huy toan bo form trong bo nho tam
        }

        private void txttimkiem_TextChanged_1(object sender, EventArgs e)
        {
            string searchtxt = txttimkiem.Text;
            LopDAL lDAL = new LopDAL();
            dgvLop.DataSource = lDAL.searchLop(searchtxt);
        }

        private void btThemMon_Click(object sender, EventArgs e)
        {
            try
            {
                int malop = Convert.ToInt32(txtmalop.Text);
                int maMon = Convert.ToInt16(cbMon.SelectedValue.ToString()); ;
                int maGV = Convert.ToInt16(cbGVBM.SelectedValue.ToString()); ;
                LopDAL lDAL = new LopDAL();
                lDAL.insertMonLop(malop, maMon, maGV);
                HienThiDSMonLop();
            }
            catch
            {

            }
        }

        int idMon;

        private void dgvMonLop_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            int numRow;
            numRow = e.RowIndex;
            idMon = Convert.ToInt32(dgvMonLop.Rows[numRow].Cells[0].Value.ToString());

        }

        private void btMon_Click(object sender, EventArgs e)
        {
            try
            {
                int malop = Convert.ToInt32(txtmalop.Text);
                LopDAL lDAL = new LopDAL();
                lDAL.XoaMonLop(malop, idMon);
                HienThiDSMonLop();
            }
            catch
            {

            }
        }
    }
}
