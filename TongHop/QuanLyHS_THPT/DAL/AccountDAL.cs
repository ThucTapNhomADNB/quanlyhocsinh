using QuanLyHS_THPT.ENTITY;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyHS_THPT.DAL
{
    class AccountDAL
    {
        DatabaseConnect dtconnect = new DatabaseConnect();
        public DataTable getTableAcc()
        {
            string query = "SELECT*FROM dbo.ACCOUNT";
            return dtconnect.GETdata(query);
        }
        public void doiMatKhau(string username, string oldpassword, string newpassword)
        {
            string query = string.Format("UPDATE dbo.ACCOUNT SET PASSWORD='{0}' WHERE USERNAME='{1}'AND PASSWORD='{2}'", newpassword, username, oldpassword);
            dtconnect.ExecuteNonQuery(query);
        }
    }
}
