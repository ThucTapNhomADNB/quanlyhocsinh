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
    public partial class frmNhapGiaoVien : Form
    {
        public frmNhapGiaoVien()
        {
            InitializeComponent();
            HienThiDSGiaoVien();
        }
       public void HienThiDSGiaoVien()
        {
            dgvGiaoVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            GiaoVienDAL gvDAL = new GiaoVienDAL();
            dgvGiaoVien.DataSource = gvDAL.LoadDS();
        }

        private void dgvGiaoVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int numRow;
            numRow = e.RowIndex;
            tbMagv.Text = dgvGiaoVien.Rows[numRow].Cells[0].Value.ToString();
            tbHoTen.Text = dgvGiaoVien.Rows[numRow].Cells[1].Value.ToString();
            string gt = dgvGiaoVien.Rows[numRow].Cells[2].Value.ToString();
            if (gt == "Nam") rbNam.Checked = true;
            else if (gt == "Nữ") rbNu.Checked = true;
            dtpgv.Value = Convert.ToDateTime(dgvGiaoVien.Rows[numRow].Cells[3].Value);
            tbNoiSinh.Text = dgvGiaoVien.Rows[numRow].Cells[4].Value.ToString();
            tbĐiaChi.Text = dgvGiaoVien.Rows[numRow].Cells[5].Value.ToString();
            tbChuyenMon.Text = dgvGiaoVien.Rows[numRow].Cells[6].Value.ToString();
            tbSdt.Text = dgvGiaoVien.Rows[numRow].Cells[7].Value.ToString();
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            GiaoVien gv = new GiaoVien();
            GiaoVienDAL gvDAL = new GiaoVienDAL();
            if (tbMagv.TextLength != 0)
            {
                MessageBox.Show("Khong can nhap ma giao vien", " Lỗi ");
            }
            else
            {
                if (tbHoTen.TextLength == 0)
                {
                    MessageBox.Show("Chua nhap ho ten giao vien", " Lỗi ");
                }
                else
                {
                    gv.HoTen = tbHoTen.Text;
                    if (rbNam.Checked == false && rbNu.Checked == false)
                    {
                        MessageBox.Show("Chua chon gioi tinh", " Lỗi ");
                    }
                    else
                    {
                        if (rbNam.Checked == true) gv.GioiTinh = "Nam";
                        else if (rbNu.Checked == true) gv.GioiTinh = "Nữ";
                        gv.NgaySinh = Convert.ToDateTime(dtpgv.Value);

                        if (tbNoiSinh.TextLength == 0)
                        {
                            MessageBox.Show("Chua nhap noi sinh ", " Lỗi ");
                        }
                        else
                        {
                            gv.NoiSinh = tbNoiSinh.Text;
                            if (tbĐiaChi.TextLength == 0)
                            {
                                MessageBox.Show("Chua nhap dia chi", " Lỗi ");
                            }
                            else
                            {
                                gv.DiaChi = tbĐiaChi.Text;
                                if (tbChuyenMon.TextLength == 0)
                                {
                                    MessageBox.Show("Chua nhap chuyen mon", " Lỗi ");
                                }
                                else
                                {
                                    gv.ChuyenMon = tbChuyenMon.Text;
                                    if(tbSdt.TextLength==0)
                                    {
                                        MessageBox.Show("chua nhap so dien thoai", "lỗi");
                                    }
                                    else
                                    {
                                        gv.SoDienThoai = tbSdt.Text;
                                        gvDAL.insertGiaoVien(gv);
                                        dgvGiaoVien.DataSource = gvDAL.LoadDS();
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            GiaoVien gv = new GiaoVien();
            gv.MaGiaoVien = Convert.ToInt32(tbMagv.Text);
            GiaoVienDAL gvDAL = new GiaoVienDAL();

            if (tbMagv.Text != gv.MaGiaoVien.ToString())
            {
                MessageBox.Show("Khong duoc sua ma giao vien", " Lỗi ");
            }
            else
            {
                if (tbHoTen.TextLength == 0)
                {
                    MessageBox.Show("Chua nhap ho ten giao vien", " Lỗi ");
                }
                else
                {
                    gv.HoTen = tbHoTen.Text;
                    if (rbNam.Checked == false && rbNu.Checked == false)
                    {
                        MessageBox.Show("Chua chon gioi tinh", " Lỗi ");
                    }
                    else
                    {
                        if (rbNam.Checked == true) gv.GioiTinh = "Nam";
                        else if (rbNu.Checked == true) gv.GioiTinh = "Nữ";
                        gv.NgaySinh = Convert.ToDateTime(dtpgv.Value);

                        if (tbNoiSinh.TextLength == 0)
                        {
                            MessageBox.Show("Chua nhap noi sinh ", " Lỗi ");
                        }
                        else
                        {
                            gv.NoiSinh = tbNoiSinh.Text;
                            if (tbĐiaChi.TextLength == 0)
                            {
                                MessageBox.Show("Chua nhap dia chi", " Lỗi ");
                            }
                            else
                            {
                                gv.DiaChi = tbĐiaChi.Text;
                                if (tbChuyenMon.TextLength == 0)
                                {
                                    MessageBox.Show("Chua nhap chuyen mon", " Lỗi ");
                                }
                                else
                                {
                                    gv.ChuyenMon = tbChuyenMon.Text;
                                    if(tbSdt.TextLength == 0)
                                    {
                                        MessageBox.Show("chua nhap so dien thoai", "lỗi");
                                    }
                                    else
                                    {
                                        gv.SoDienThoai = tbSdt.Text;
                                        gvDAL.SuaGiaoVien(gv);
                                        dgvGiaoVien.DataSource = gvDAL.LoadDS();
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
        private void btxoa_Click(object sender, EventArgs e)
        {
            GiaoVienDAL gvDAL = new GiaoVienDAL();
            if (tbMagv.TextLength == 0)
            {
                MessageBox.Show("Chua co ma giao vien", " Lỗi ");
            }
            else
            {
                try
                {
                    int id = Convert.ToInt16(tbMagv.Text);
                    gvDAL.deleteGiaoVien(id);
                    dgvGiaoVien.DataSource = gvDAL.LoadDS();
                }
                catch
                {
                    MessageBox.Show("ma giao vien khong thoa man", " Lỗi ");
                }
            }
        }

        private void tbTimKIem_TextChanged(object sender, EventArgs e)
        {
            string searchtxt = tbTimKIem.Text;
            GiaoVienDAL gvDAL = new GiaoVienDAL();
            dgvGiaoVien.DataSource = gvDAL.searchGV(searchtxt);
        }
    }
}
