using QuanLyHS_THPT.ENTITY;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            string query = string.Format("INSERT dbo.GIAOVIEN VALUES  ( N'{0}' ,N'{1}' , '{2}' , N'{3}' , N'{4}' , N'{5}' , N'{6}')", gv.HoTen, gv.GioiTinh, gv.NgaySinh.ToShortDateString(), gv.NoiSinh, gv.DiaChi, gv.ChuyenMon, gv.SoDienThoai);
            DatabaseConnect dtConnet = new DatabaseConnect();
            dtConnet.ExecuteNonQuery(query);
        }
        public void deleteGiaoVien(int id)
        {
            string query = string.Format("DELETE dbo.GIAOVIEN WHERE MAGIAOVIEN={0}", id);
            DatabaseConnect dtConnet = new DatabaseConnect();
            dtConnet.ExecuteNonQuery(query);
        }
        public void SuaGiaoVien(GiaoVien gv)
        {
<<<<<<< HEAD
            string query = string.Format("UPDATE dbo.GIAOVIEN SET HOTEN =N'{0}' ,GTINH=N'{1}',NGAYSINH='{2}',NOISINH=N'{3}',DIACHI=N'{4}',CHUYENMON=N'{5}', SODIENTHOAI='{6}' WHERE MAGIAOVIEN= {7}", gv.HoTen, gv.GioiTinh, gv.NgaySinh.ToShortDateString(), gv.NoiSinh, gv.DiaChi, gv.ChuyenMon,gv.SoDienThoai ,gv.MaGiaoVien);
=======
            string query = string.Format("UPDATE dbo.GIAOVIEN SET HOTEN ='{0}' ,GTINH='{1}',NGAYSINH='{2}',NOISINH='{3}',DIACHI='{4}',CHUYENMON='{5}', SODIENTHOAI='{6}' WHERE MAGIAOVIEN= {7}", gv.HoTen, gv.GioiTinh, gv.NgaySinh.ToShortDateString(), gv.NoiSinh, gv.DiaChi, gv.ChuyenMon,gv.SoDienThoai ,gv.MaGiaoVien);
>>>>>>> 513e542340675370ce69a68b32895404c21e792d
            DatabaseConnect dtConnet = new DatabaseConnect();
            dtConnet.ExecuteNonQuery(query);
        }
        public DataTable searchGV(string name)
        {
            string query = string.Format("SELECT * FROM dbo.GIAOVIEN WHERE HOTEN LIKE '%{0}%'", name);
            return dtConnect.GETdata(query);
        }
    public GiaoVien getGiaoVien(int ma)
        {
            GiaoVien gv = new GiaoVien();
            string query =string.Format( "SELECT * FROM dbo.GIAOVIEN WHERE MAGIAOVIEN = {0}",ma);
            DataTable data = dtConnect.GETdata(query);
            gv.MaGiaoVien = data.Rows[0].Field<int>(0);
            gv.HoTen = data.Rows[0].Field<string>(1);
            gv.ChuyenMon = data.Rows[0].Field<string>(6);
            return gv;
        }
    }
}
