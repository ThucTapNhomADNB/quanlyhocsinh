using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyHS_THPT.ENTITY;
namespace QuanLyHS_THPT.DAL
{
    class MonHocDAL
    {
        DatabaseConnect dtConnet = new DatabaseConnect();
        public DataTable LoadDS()
        {
            string query = "SELECT * FROM  dbo.MONHOC ";
            DatabaseConnect dtConnet = new DatabaseConnect();
            return dtConnet.GETdata(query);
        }
        public void insertMonHoc(MonHoc mh)
        {
            string query = string.Format("INSERT dbo.MONHOC VALUES  ( N'{0}' ,N'{1}')", mh.MaMonHoc, mh.TenMonHoc);
            DatabaseConnect dtConnet = new DatabaseConnect();
            dtConnet.ExecuteNonQuery(query);
        }
        public void deleteMonHoc(int id)
        {
            string query = string.Format("DELETE dbo.MONHOC WHERE MAMONHOC={0}", id);
            DatabaseConnect dtConnet = new DatabaseConnect();
            dtConnet.ExecuteNonQuery(query);
        }
        public void SuaMonHoc(MonHoc mh)
        {
            string query = string.Format("UPDATE dbo.MONHOC SET MAMONHOC ='{0}' ,TENMONHOC='{1}'", mh.MaMonHoc, mh.TenMonHoc);
            DatabaseConnect dtConnet = new DatabaseConnect();
            dtConnet.ExecuteNonQuery(query);
        }
    }
}
