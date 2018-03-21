using QuanLyHS_THPT.ENTITY;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyHS_THPT.DAL
{
    class MonHocDAL
    {
        DatabaseConnect dtConnect = new DatabaseConnect();
        public DataTable LoadDS()
        {
            string query = "SELECT * FROM  dbo.MONHOC ";
            return dtConnect.GETdata(query);
        }
        public void insertMonHoc(MonHoc mh)
        {
            string query = string.Format("INSERT dbo.MONHOC VALUES ( N'{0}')", mh.TenMonHoc);
            dtConnect.ExecuteNonQuery(query);
        }
        public void deleteMonHoc(int id)
        {
            string query = string.Format("DELETE dbo.MONHOC WHERE MAMONHOC={0}", id);
            dtConnect.ExecuteNonQuery(query);
        }
        public void SuaMonHoc(MonHoc mh)
        {
            string query = string.Format("UPDATE dbo.MONHOC SET TENMONHOC='{1}' WHERE MAMONHOC={0}", mh.MaMonHoc, mh.TenMonHoc);
            dtConnect.ExecuteNonQuery(query);
        }
        public DataTable searchMonHoc(string name)
        {
            string query = string.Format("SELECT * FROM dbo.MONHOC WHERE TENMONHOC LIKE '%{0}%'", name);
            return dtConnect.GETdata(query);
        }
    }
}
