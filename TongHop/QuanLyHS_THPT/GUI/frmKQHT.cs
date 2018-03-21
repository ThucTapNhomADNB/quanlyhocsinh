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
    public partial class frmKQHT : Form
    {
        private int malop = 0;
        public frmKQHT()
        {
        
            InitializeComponent();
            LoadLop();
            HienThiDSLop();
        }

        private void HienThiDSLop()
        {
            dgvdslop.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            KQHTDAL hsDAL = new KQHTDAL();
            dgvdslop.DataSource = hsDAL.LoadDS();
        }

        private void LoadLop()
        {
            LopDAL lDAL = new LopDAL();
            DataTable dataLOP = lDAL.LoadDS();
            cblop.DataSource = dataLOP;
            cblop.DisplayMember = "TENLOP";
            cblop.ValueMember = "MALOP";
        }

        private void cblop_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int ma = Convert.ToInt16(cblop.SelectedValue.ToString());

                LopDAL lDAL = new LopDAL();
                Lop l = lDAL.getLop(ma);
                lblmalop.Text = l.MaLop.ToString();
                lblsiso.Text = l.SiSo.ToString();
                lblmagvcn.Text = l.MaGVCN.ToString();
                this.malop = ma;
            }
            catch
            {
            }
        }
    }
}
