using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyHS_THPT.ENTITY;

namespace QuanLyHS_THPT.DAL
{
    class LopDAL
    {

        DatabaseConnect dtConnect = new DatabaseConnect();
        public DataTable LoadDS()
        {
            string query = "SELECT * FROM  dbo.LOP ";
            return dtConnect.GETdata(query);
        }
        public void insertLOP(Lop l)
        {
            string query = string.Format("INSERT dbo.LOP VALUES  ( N'{0}', N'{1}' , N'{2}' )", l.TenLop, l.SiSo, l.MaGVCN);
            DatabaseConnect dtConnet = new DatabaseConnect();
            dtConnet.ExecuteNonQuery(query);
        }

        public void SuaLop(Lop l)
        {
            string query = string.Format("UPDATE dbo.LOP SET TENLOP ='{0}' , SISO='{1}', MA_GVCHUNHIEM='{2}'WHERE MALOP= {3}", l.TenLop, l.SiSo, l.MaGVCN, l.MaLop);
            DatabaseConnect dtConnet = new DatabaseConnect();
            dtConnet.ExecuteNonQuery(query);
        }
        public DataTable searchLop(string name)
        {
            string query = string.Format("SELECT * FROM dbo.LOP WHERE TENLOP LIKE '%{0}%'", name);
            return dtConnect.GETdata(query);
        }

    }
}
