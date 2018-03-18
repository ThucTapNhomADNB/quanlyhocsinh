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
    public partial class frmMonHoc : Form
    {
        public frmMonHoc()
        {
            InitializeComponent();
            HienThiDSMonHoc();
        }
        private void HienThiDSMonHoc()
        {
            dgvMonHoc.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            MonHocDAL hsDAL = new MonHocDAL();
            dgvMonHoc.DataSource = hsDAL.LoadDS();
        }

        private void dgvMonHoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int numrow = e.RowIndex;
            txtMaMH.Text = dgvMonHoc.Rows[numrow].Cells[0].Value.ToString();
            txtTenMH.Text= dgvMonHoc.Rows[numrow].Cells[1].Value.ToString();
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            MonHoc mh = new MonHoc();
            mh.MaMonHoc = Convert.ToInt32(txtMaMH.Text);
            MonHocDAL mhDAL = new MonHocDAL();

            if (txtMaMH.Text != mh.MaMonHoc.ToString())
            {
                MessageBox.Show("Không sửa được mã môn học", " lỗi ");
            }
            else
            {
                if (txtTenMH.TextLength == 0)
                {
                    MessageBox.Show("Chưa nhập tên môn học", " lỗi ");
                }
                else
                {
                    mh.TenMonHoc = txtTenMH.Text;
                    mhDAL.SuaMonHoc(mh);
                    dgvMonHoc.DataSource = mhDAL.LoadDS();
                }
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            MonHoc mh = new MonHoc();
            MonHocDAL mhDAL = new MonHocDAL();

            if (txtMaMH.TextLength != 0)
            {
                MessageBox.Show("Không cần nhập mã môn học", " lỗi ");
            }
            else
            {
                if (txtTenMH.TextLength == 0)
                {
                    MessageBox.Show("Chưa nhập tên môn học", " lỗi ");
                }
                else
                {
                    mh.TenMonHoc = txtTenMH.Text;
                    mhDAL.insertMonHoc(mh);
                    dgvMonHoc.DataSource = mhDAL.LoadDS();

                }
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            MonHocDAL mhDAL = new MonHocDAL();
            if (txtMaMH.TextLength == 0)
            {
                MessageBox.Show("Chưa có mã môn học", " lỗi ");
            }
            else
            {
                try
                {
                    int id = Convert.ToInt16(txtMaMH.Text);
                    mhDAL.deleteMonHoc(id);
                    dgvMonHoc.DataSource = mhDAL.LoadDS();
                }
                catch
                {
                    MessageBox.Show("Mã môn học không thỏa mãn", " lỗi ");
                }

            }
        }

        private void frmMonHoc_Load(object sender, EventArgs e)
        {

        }

       
    }
}
