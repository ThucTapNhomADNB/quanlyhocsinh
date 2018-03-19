using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyHS_THPT.ENTITY;
using System.Data;

namespace QuanLyHS_THPT.DAL
{
    class GiaoVienDAL
    {
        DatabaseConnect dtConnect = new DatabaseConnect();
        public DataTable LoadDS()
        {
            string query = "SELECT * FROM  dbo.GIAOVIEN ";
            return dtConnect.GETdata(query);
        }
        public void insertGiaoVien(GiaoVien gv)
        {
            string query = string.Format("INSERT dbo.GIAOVIEN VALUES  ( N'{0}' ,N'{1}' , '{2}' , N'{3}' , N'{4}' , N'{5}',N'{6}')", gv.HoTen, gv.GioiTinh, gv.NgaySinh.ToShortDateString(), gv.NoiSinh, gv.DiaChi, gv.ChuyenMon,gv.SoDienThoai);
            DatabaseConnect dtConnet = new DatabaseConnect();
            dtConnet.ExecuteNonQuery(query);
        }
        public void deleteGiaoVien(int id)
        {
            string query = string.Format("DELETE dbo.GIAOVIEN WHERE MAGIAOVIEN={0}", id);
            DatabaseConnect dtConnet = new DatabaseConnect();
            dtConnet.ExecuteNonQuery(query);
        }
        public void SuaGIAOVIEN(GiaoVien gv)
        {
            string query = string.Format("UPDATE dbo.GIAOVIEN SET HOTEN ='{0}' ,GIOITINH='{1}',NGAYSINH='{2}',NOISINH='{3}',DICHI='{4}',CHUYENMON='{5}',SODIENTHOAI='{6}' WHERE MAGIAOVIEN= {7}", gv.HoTen, gv.GioiTinh, gv.NgaySinh.ToShortDateString(), gv.NoiSinh, gv.DiaChi, gv.ChuyenMon, gv.SoDienThoai);
            DatabaseConnect dtConnet = new DatabaseConnect();
            dtConnet.ExecuteNonQuery(query);
        }
        public DataTable searchGV(string name)
        {
            string query = string.Format("SELECT * FROM dbo.GIAOVIEN WHERE HOTEN LIKE '%{0}%'", name);
            return dtConnect.GETdata(query);
        }
    }
}
