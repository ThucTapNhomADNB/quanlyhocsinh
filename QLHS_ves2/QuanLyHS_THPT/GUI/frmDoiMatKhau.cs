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
    public partial class frmDoiMatKhau : Form
    {
        Account acc = new Account();
        public frmDoiMatKhau(string username, string password)
        {
            InitializeComponent();
            acc.Usename = username;
            acc.Password = password;
        }
        
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();

            this.Show();

        }

        private void btnDoiMK_Click(object sender, EventArgs e)
        {
            string oldpass = txtOldPass.Text;
            string newPass = txtNewPass.Text;

         //   if (MessageBox.Show("Bạn có thật sự muốn đôi mật khẩu ?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                if (acc.Password == oldpass && newPass != "")
                {
                    this.Hide();
                    AccountDAL accDAL = new AccountDAL();
                    accDAL.doiMatKhau(acc.Usename, oldpass, newPass);

                    acc.Password = newPass;
                }
                else
                {
                    MessageBox.Show("Nhập không đúng mật khẩu", "Lỗi ");
                }
            }

            
        }
    }
}
