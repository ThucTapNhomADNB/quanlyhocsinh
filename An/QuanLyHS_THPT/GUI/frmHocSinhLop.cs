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
using QuanLyHS_THPT.ENTITY;

namespace QuanLyHS_THPT.GUI
{
    public partial class frmHocSinhLop : Form
    {
        public frmHocSinhLop()
        {
            InitializeComponent();
            HienThiDSHocSinh();
            itemcomboBox();
        }
        private void HienThiDSHocSinh()
        {
            dgvhocsinhlop.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            HocSinhDAL hsDAL = new HocSinhDAL();
            dgvhocsinhlop.DataSource = hsDAL.LoadDS();
        }
        public void danhsachlop()
        {
            dgvdslop.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            HocSinhLopDAL hslop = new HocSinhLopDAL();
            dgvdslop.DataSource = hslop.dslop(Convert.ToInt16(dgvhocsinhlop.CurrentRow.Cells["MAHOCSINH"].Value));
        }
        public void itemcomboBox()
        {
            LopDAL lop = new LopDAL();
            comboBox1.DataSource = lop.LoadDS();
            comboBox1.DisplayMember = "TenLop";
            comboBox1.ValueMember = "MALOP";
        }
        private void dgvhocsinhlop_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbname.Text = dgvhocsinhlop.CurrentRow.Cells["HOTEN"].Value.ToString();
            danhsachlop();
        }
        //button thêm
        private void button1_Click(object sender, EventArgs e)
        {
            HocSinhLopDAL hslop = new HocSinhLopDAL();
            //hslop.insertketquahoctap(Convert.ToInt16(comboBox1.SelectedItem), Convert.ToInt16(dgvhocsinhlop.CurrentRow.Cells["MAHOCSINH"].Value));
            danhsachlop();
        }
    }
}
