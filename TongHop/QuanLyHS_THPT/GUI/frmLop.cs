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

        private void dgvLop_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int numRow;
            numRow = e.RowIndex;
            txtmalop.Text = dgvLop.Rows[numRow].Cells[0].Value.ToString();
            txttenlop.Text = dgvLop.Rows[numRow].Cells[1].Value.ToString();
            txtsiso.Text = dgvLop.Rows[numRow].Cells[2].Value.ToString();
            txtmagvcn.Text = dgvLop.Rows[numRow].Cells[3].Value.ToString();

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
                        l.MaGVCN = Convert.ToInt16(txtmagvcn.Text);
                        lDAL.insertLOP(l);
                        dgvLop.DataSource = lDAL.LoadDS();

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
                        l.MaGVCN = Convert.ToInt16(txtmagvcn.Text);
                        lDAL.SuaLop(l);
                        dgvLop.DataSource = lDAL.LoadDS();

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

       
    }
}
