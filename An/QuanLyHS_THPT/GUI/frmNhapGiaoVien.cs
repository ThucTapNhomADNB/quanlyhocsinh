using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyHS_THPT.DAL;
using QuanLyHS_THPT.ENTITY;
using System;

namespace QuanLyHS_THPT.GUI
{
    public partial class frmNhapGiaoVien : Form
    {
        public frmNhapGiaoVien()
        {
            InitializeComponent();
            HienThiDSGiaoVien();
        }
        private void HienThiDSGiaoVien()
        {
            dgvGiaoVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            GiaoVienDAL gvDAL = new GiaoVienDAL();
            dgvGiaoVien.DataSource = gvDAL.LoadDS();
        }
        private void dgvGiaoVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbMagv.Text = dgvGiaoVien.CurrentRow.Cells[0].Value.ToString();
            tbHoTen.Text= dgvGiaoVien.CurrentRow.Cells[1].Value.ToString();
            string gt = dgvGiaoVien.CurrentRow.Cells[2].Value.ToString();
            if (gt == "Nam") rbNam.Checked = true;
            else if (gt == "Nữ") rbNu.Checked = true;
            dtpgv.Value = Convert.ToDateTime(dgvGiaoVien.CurrentRow.Cells[3].Value);
            tbNoiSinh.Text = dgvGiaoVien.CurrentRow.Cells[4].Value.ToString();
            tbĐiaChi.Text = dgvGiaoVien.CurrentRow.Cells[5].Value.ToString();
            tbChuyenMon.Text = dgvGiaoVien.CurrentRow.Cells[6].Value.ToString();
            tbSdt.Text = dgvGiaoVien.CurrentRow.Cells[7].Value.ToString();
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            GiaoVien gv = new GiaoVien();
            GiaoVienDAL gvDAL = new GiaoVienDAL();
            if (tbMagv.TextLength != 0)
            {
                MessageBox.Show("Không cần nhập mã Giáo Viên", " lỗi ");
            }
            else
            {
                if (tbHoTen.TextLength == 0)
                {
                    MessageBox.Show("Chưa nhập họ tên Giáo Viên", " lỗi ");
                }
                else
                {
                    gv.HoTen = tbHoTen.Text;
                    if (rbNam.Checked == false && rbNu.Checked == false)
                    {
                        MessageBox.Show("Chua chon gioi tinh", " loi ");
                    }
                    else
                    {
                        if (rbNam.Checked == true) gv.GioiTinh = "Nam";
                        else if (rbNu.Checked == true) gv.GioiTinh = "Nữ";
             
                            if (tbNoiSinh.TextLength == 0)
                            {
                                MessageBox.Show("Chưa nhập nơi sinh ", " lỗi ");
                            }
                            else
                            {
                                gv.NoiSinh = tbNoiSinh.Text;
                                if (tbĐiaChi.TextLength == 0)
                                {
                                    MessageBox.Show("Chưa nhập Địa chỉ", " lỗi ");
                                }
                                else
                                {
                                    gv.DiaChi = tbĐiaChi.Text;
                                    if (tbChuyenMon.TextLength == 0)
                                    {
                                        MessageBox.Show("Chưa nhập chuyên môn", " lỗi ");
                                    }
                                    else
                                    {
                                        gv.ChuyenMon = tbChuyenMon.Text;
                                        if(tbSdt.TextLength==0)
                                    {
                                        MessageBox.Show("Chưa nhập sdt", " lỗi ");
                                    }
                                        else
                                    {
                                        gv.SoDienThoai = tbSdt.Text;
                                        gvDAL.SuaGIAOVIEN(gv);
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
                MessageBox.Show("Khong duoc sua ma giáo Viên", " loi ");
            }
            else
            {
                if (tbHoTen.TextLength == 0)
                {
                    MessageBox.Show("Chua nhap ho ten hoc sinh", " loi ");
                }
                else
                {
                    gv.HoTen = tbHoTen.Text;
                    if (rbNam.Checked == false && rbNu.Checked == false)
                    {
                        MessageBox.Show("Chua chon gioi tinh", " loi ");
                    }

                            if (tbNoiSinh.TextLength == 0)
                            {
                                MessageBox.Show("Chua nhap noi sinh ", " loi ");
                            }
                            else
                            {
                                gv.NoiSinh = tbNoiSinh.Text;
                                if (tbĐiaChi.TextLength == 0)
                                {
                                    MessageBox.Show("Chua nhap dia chi", " loi ");
                                }
                                else
                                {
                                    gv.DiaChi = tbĐiaChi.Text;
                                    if (tbChuyenMon.TextLength == 0)
                                    {
                                        MessageBox.Show("Chua nhap chuyen mon", " loi ");
                                    }
                                    else
                                    {
                                        gv.ChuyenMon = tbChuyenMon.Text;
                                        gvDAL.SuaGIAOVIEN(gv);
                                        dgvGiaoVien.DataSource = gvDAL.LoadDS();
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
                MessageBox.Show("Chua co ma giao vien", " loi ");
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
                    MessageBox.Show("ma Giao Vien khong thoa man", " loi ");
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
