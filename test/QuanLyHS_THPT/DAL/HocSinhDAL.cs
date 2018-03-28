using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyHS_THPT.ENTITY;
namespace QuanLyHS_THPT.DAL
{
    class HocSinhDAL
    {
        DatabaseConnect dtConnect = new DatabaseConnect();
        public DataTable LoadDS()
        {
            string query = "SELECT * FROM  dbo.HOCSINH ";
            return dtConnect.GETdata(query);
        }
        public void insertHocSinh(HocSinh hs)
        {
            string query =string.Format("INSERT dbo.HOCSINH VALUES  ( N'{0}' ,N'{1}' , '{2}' , N'{3}' , N'{4}' , N'{5}')", hs.HoTen, hs.GioiTinh, hs.NgaySinh.ToShortDateString(),hs.NoiSinh, hs.DanToc, hs.TonGiao) ;
            DatabaseConnect dtConnet = new DatabaseConnect();
            dtConnet.ExecuteNonQuery(query);
        }
        public void deleteHocSinh(int id)
        {
            string query = string.Format("DELETE dbo.HOCSINH WHERE MAHOCSINH={0}",id);
            DatabaseConnect dtConnet = new DatabaseConnect();
            dtConnet.ExecuteNonQuery(query);
        }
        public void SuaHocSinh(HocSinh hs )
        {
            string query = string.Format("UPDATE dbo.HOCSINH SET HOTEN ='{0}' ,GIOITINH='{1}',NGAYSINH='{2}',NOISINH='{3}',DANTOC='{4}',TONGIAO='{5}' WHERE MAHOCSINH= {6}", hs.HoTen, hs.GioiTinh, hs.NgaySinh.ToShortDateString(), hs.NoiSinh, hs.DanToc, hs.TonGiao,hs.MaHocSinh);
            DatabaseConnect dtConnet = new DatabaseConnect();
            dtConnet.ExecuteNonQuery(query);
        }
        public DataTable searchHS(string name)
        {
            string query = string.Format("SELECT * FROM dbo.HOCSINH WHERE HOTEN LIKE '%{0}%'", name);
            return dtConnect.GETdata(query);
        }


    }
}
