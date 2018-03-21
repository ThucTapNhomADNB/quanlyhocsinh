using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyHS_THPT.DAL
{
    class HocSinhLopDAL
    {
        DatabaseConnect dtConnect = new DatabaseConnect();
        public DataTable dslop(int mahs)
        {
            string query = string.Format(" SELECT * FROM dbo.LOP WHERE MALOP IN ( SELECT MALOP FROM dbo.KETQUAHOCTAP kq WHERE kq.MAHOCSINH = {0})",mahs);
            return dtConnect.GETdata(query);
        }
        public void insertketquahoctap(int malop, int mahs)
        {
            string query = string.Format("INSERT dbo.KETQUAHOCTAP VALUES  ( N'{0}' ,N'{1}' , '{2}' , N'{3}' , N'{4}' , N'{5}',N'{6}',N'{7}', N'{8}')",mahs, malop, "", "", "", "", "", "");
            DatabaseConnect dtConnet = new DatabaseConnect();
            dtConnet.ExecuteNonQuery(query);
        }
    }
}
