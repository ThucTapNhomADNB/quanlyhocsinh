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
    public partial class frmNhapDiem : Form
    {
        public frmNhapDiem()
        {
            InitializeComponent();
            Load();
        }

        private void cbLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        void Load()
        {
            BangDiemDAL bangdiemDAL = new BangDiemDAL();
            DataTable dataLop = bangdiemDAL.LoadDSLop();

            cbLop.DataSource = dataLop;
            //cbLop.DisplayMember = "TENLOP";
            //cbLop.ValueMember = "MALOP";
            cbLop.DisplayMember = "HOTEN";
            cbLop.ValueMember = "MAHOCSINH";
        }

    
    }
}
