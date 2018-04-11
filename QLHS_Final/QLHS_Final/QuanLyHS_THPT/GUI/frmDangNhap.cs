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
    public partial class frmDangNhap : Form
    {
        private Account acc;
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Account acc = new Account();
            acc.Usename = txtUser.Text;
            acc.Password = txtPassword.Text;

            AccountDAL accDAL = new AccountDAL();
            DataTable data = accDAL.getTableAcc();


            // lọc từ datatable dong có username = username người dùng nhập
            string filterExpression = string.Format("USERNAME='{0}'",acc.Usename);
             DataRow[] rows = data.Select(filterExpression);

            if (rows.Length != 0)
            {
                if (rows[0].ItemArray[1].ToString() == acc.Password)
                {
                    this.Hide();
                    int PhanQuyen = Convert.ToInt32(rows[0].ItemArray[3].ToString());
                    MainForm mf = new MainForm(PhanQuyen);
                  
                    mf.ShowDialog();
                 //  this.Show();
                }
                else
                {
                    MessageBox.Show("mật khẩu của bạn bị sai", "Lỗi đăng nhâp");
                }
               
            }
            else
            {
                MessageBox.Show("tài khoản không tồn tại", "Lỗi đăng nhâp");
            }


        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmDangNhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            //if (MessageBox.Show("Bạn có thật sự muốn thoát chương trình?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            //{
            //    e.Cancel = true;
            //}
            Application.Exit();
        }
    }
}
