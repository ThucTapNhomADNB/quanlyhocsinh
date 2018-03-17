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
            DataTable dataHS = new DataTable();
            HocSinhDAL hsDAL = new HocSinhDAL();
            dataHS = hsDAL.GET();
            dgvHocSinh.DataSource = dataHS;
        }

        private void dgvHocSinh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int numRow;
            numRow = e.RowIndex;
            //   textBox1.Text = dataView.Rows[numrow].Cells[1].Value.ToString();
            tbMaHs.Text = dgvHocSinh.Rows[numRow].Cells[0].Value.ToString();
            tbHoTen.Text = dgvHocSinh.Rows[numRow].Cells[1].Value.ToString();
            tbNoiSinh.Text = dgvHocSinh.Rows[numRow].Cells[4].Value.ToString();
            tbDanToc.Text = dgvHocSinh.Rows[numRow].Cells[6].Value.ToString();
            tbTonGiao.Text = dgvHocSinh.Rows[numRow].Cells[5].Value.ToString();

        }
    }
}
