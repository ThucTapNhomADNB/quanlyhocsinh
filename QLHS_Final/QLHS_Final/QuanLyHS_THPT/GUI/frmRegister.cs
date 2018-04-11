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
    public partial class frmRegister : Form
    {
        public frmRegister()
        {
            InitializeComponent();
        }

        private void btDangKi_Click(object sender, EventArgs e)
        {
            int key = 0;
            AccountDAL accDAL = new AccountDAL();
            DataTable dataAcc = accDAL.getTableAcc();

            Account acc = new Account();
            string textUsename = txtUsername.Text;
            string textPass = txtPass.Text;
            string textRePass = txtRePass.Text;

            // kiem tra username trung 
            // lọc từ datatable cac dong có username = username người dùng nhập
            string filterExpression = string.Format("USERNAME='{0}'", textUsename);
            DataRow[] rows = dataAcc.Select(filterExpression);
            if (rows.Length == 0)
            {
                acc.Usename = textUsename;
            }
            else
            {
                key++;
                lbLoiUsername.Text = "*Tên đăng nhập bị trùng";
            }
            // kiem tra do an toan cua mat khau
            if (textPass.Length >= 8)
            {

            }
            else
            {
                key++;
                lbLoiPass.Text = "*Mật khẩu it nhất 8 kí tự";
            }

            //kiem tra Repassword
            if (textPass == textRePass)
            {
                acc.Password = textPass;
            }
            else
            {
                key++;
                lbLoiRePass.Text = "*Xác nhận mật khẩu không chính xác";
            }

            // kiem tra Phan quyen
            if (rbAdmin.Checked == true)
            {
                acc.PhanQuyen = 1;
            }
            else
            {
                if (rbUser.Checked == true)
                {
                    acc.PhanQuyen = 0;
                }
                else
                {
                    lbLoiPhanQuyen.Text = "Bạn chưa phân quyền tài khoản";
                }
            }
            if (key == 0)
            {
                accDAL.InsertAcc(acc);
                lbNotice.Text = "Thêm tài khoản thành công";
            }
            else
            {
                lbNotice.Text = "Thêm tài khoản thất bại";
            }

        }
    }
}
