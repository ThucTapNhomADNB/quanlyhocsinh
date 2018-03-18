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
    public partial class frmNhapHS : Form
    {
        public frmNhapHS()
        {
            InitializeComponent();
            HienThiDSHocSinh();
        }

        private void frmNhapHS_Load(object sender, EventArgs e)
        {

        }
        private void HienThiDSHocSinh()
        {
            dgvHocSinh.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            HocSinhDAL hsDAL = new HocSinhDAL();
            dgvHocSinh.DataSource = hsDAL.LoadDS();
        }

        private void dgvHocSinh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int numRow;
            numRow = e.RowIndex;
            //   textBox1.Text = dataView.Rows[numrow].Cells[1].Value.ToString();
            tbMaHs.Text = dgvHocSinh.Rows[numRow].Cells[0].Value.ToString();
            tbHoTen.Text = dgvHocSinh.Rows[numRow].Cells[1].Value.ToString();
            string gt= dgvHocSinh.Rows[numRow].Cells[2].Value.ToString();
            if (gt == "Nam") rbNam.Checked = true;
            else if (gt == "Nữ") rbNu.Checked = true;

            string ns = dgvHocSinh.Rows[numRow].Cells[3].Value.ToString();
            tbNgaySinh.Text = ns;
            tbNoiSinh.Text = dgvHocSinh.Rows[numRow].Cells[4].Value.ToString();
            tbDanToc.Text = dgvHocSinh.Rows[numRow].Cells[5].Value.ToString();
            tbTonGiao.Text = dgvHocSinh.Rows[numRow].Cells[6].Value.ToString();

        }

        private void btThem_Click(object sender, EventArgs e)
        {
            HocSinh hs = new HocSinh();
            HocSinhDAL hsDAL = new HocSinhDAL();
            
            if(tbMaHs.TextLength != 0)
            {
                MessageBox.Show("Khong can nhap ma hoc sinh"," loi " );
            }
            else
            {
                if (tbHoTen.TextLength ==0)
                {
                    MessageBox.Show("Chua nhap ho ten hoc sinh"," loi ");
                }
                else
                {
                    hs.HoTen = tbHoTen.Text;
                    if(rbNam.Checked== false && rbNu.Checked == false)
                    {
                        MessageBox.Show("Chua chon gioi tinh"," loi " );
                    }
                    else
                    {
                        if (rbNam.Checked == true) hs.GioiTinh = "Nam";
                        else if (rbNu.Checked == true) hs.GioiTinh = "Nữ";
                        if(tbNgaySinh.Text=="dd-mm-yyyy" || tbNgaySinh.TextLength==0)
                        {
                            MessageBox.Show("Chua nhap ngay sinh"," loi " );
                        }
                        else
                        {
                            hs.NgaySinh =Convert.ToDateTime( tbNgaySinh.Text);
                     
                            if (tbNoiSinh.TextLength == 0)
                            {
                                MessageBox.Show("Chua nhap noi sinh "," loi " );
                            }
                            else
                            {
                                hs.NoiSinh = tbNoiSinh.Text;
                                if (tbDanToc.TextLength == 0)
                                {
                                    MessageBox.Show("Chua nhap dan toc", " loi ");
                                }
                                else
                                {
                                    hs.DanToc = tbDanToc.Text;
                                    if (tbTonGiao.TextLength == 0)
                                    {
                                        MessageBox.Show("Chua nhap ton giao", " loi ");
                                    }
                                    else
                                    {
                                        hs.TonGiao = tbTonGiao.Text;
                                        hsDAL.insertHocSinh(hs);
                                        dgvHocSinh.DataSource = hsDAL.LoadDS();
                                    }
                                }
                            }   
                        }
                    }
                }
            }
            

        }

        private void btXoa_Click(object sender, EventArgs e)
        {

            HocSinhDAL hsDAL = new HocSinhDAL();
            if (tbMaHs.TextLength == 0)
            {
                MessageBox.Show("Chua co ma hoc sinh", " loi ");
            }
            else
            {
                try
                {
                    int id = Convert.ToInt16(tbMaHs.Text);
                    hsDAL.deleteHocSinh(id);
                    dgvHocSinh.DataSource = hsDAL.LoadDS();
                }
                catch
                {
                    MessageBox.Show("ma hoc sinh khong thoa man", " loi ");
                }

            }
         }

        private void btSua_Click(object sender, EventArgs e)
        {
            HocSinh hs = new HocSinh();
            hs.MaHocSinh = Convert.ToInt32(tbMaHs.Text);
            HocSinhDAL hsDAL = new HocSinhDAL();

            if (tbMaHs.Text != hs.MaHocSinh.ToString())
            {
                MessageBox.Show("Khong duoc sua ma hoc sinh", " loi ");
            }
            else
            {
                if (tbHoTen.TextLength == 0)
                {
                    MessageBox.Show("Chua nhap ho ten hoc sinh", " loi ");
                }
                else
                {
                    hs.HoTen = tbHoTen.Text;
                    if (rbNam.Checked == false && rbNu.Checked == false)
                    {
                        MessageBox.Show("Chua chon gioi tinh", " loi ");
                    }
                    else
                    {
                        if (rbNam.Checked == true) hs.GioiTinh = "Nam";
                        else if (rbNu.Checked == true) hs.GioiTinh = "Nữ";
                        if (tbNgaySinh.Text == "dd-mm-yyyy" || tbNgaySinh.TextLength == 0)
                        {
                            MessageBox.Show("Chua nhap ngay sinh", " loi ");
                        }
                        else
                        {
                            hs.NgaySinh = Convert.ToDateTime(tbNgaySinh.Text);

                            if (tbNoiSinh.TextLength == 0)
                            {
                                MessageBox.Show("Chua nhap noi sinh ", " loi ");
                            }
                            else
                            {
                                hs.NoiSinh = tbNoiSinh.Text;
                                if (tbDanToc.TextLength == 0)
                                {
                                    MessageBox.Show("Chua nhap dan toc", " loi ");
                                }
                                else
                                {
                                    hs.DanToc = tbDanToc.Text;
                                    if (tbTonGiao.TextLength == 0)
                                    {
                                        MessageBox.Show("Chua nhap ton giao", " loi ");
                                    }
                                    else
                                    {
                                        hs.TonGiao = tbTonGiao.Text;
                                        hsDAL.SuaHocSinh(hs);
                                        dgvHocSinh.DataSource = hsDAL.LoadDS();
                                    }
                                }
                            }
                        }
                    }
                }
            }

        }
    }
}
