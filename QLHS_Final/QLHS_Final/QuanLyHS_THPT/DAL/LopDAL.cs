using QuanLyHS_THPT.ENTITY;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyHS_THPT.DAL
{
    class LopDAL
    {

        DatabaseConnect dtConnect = new DatabaseConnect();
        public DataTable LoadDS()
        {
            string query = "SELECT l.MALOP,l.TENLOP,l.SISO,l.MA_GVCHUNHIEM,gv.HOTEN FROM dbo.LOP l, dbo.GIAOVIEN gv WHERE l.MA_GVCHUNHIEM=gv.MAGIAOVIEN ";
            return dtConnect.GETdata(query);
        }
        public void insertLOP(Lop l)
        {
            // string query = string.Format("INSERT dbo.LOP VALUES  ( N'{0}', N'{1}' , N'{2}' )", l.TenLop, l.SiSo, l.MaGVCN);
            string query = string.Format("dbo.themLop @teblop = '{0}', @siso = {1}, @magv = {2}", l.TenLop, l.SiSo, l.MaGVCN);
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
        public Lop getLop(int ma)
        {
            Lop l = new Lop();
            string query = string.Format("SELECT * FROM dbo.LOP WHERE MALOP = {0}", ma);
            DataTable data = dtConnect.GETdata(query);
            return l;
        }

        // lấy danh sách các môn học của 1 lớp

        public DataTable getMonLop(int idLop)
        {
            string query = string.Format("SELECT lm.MAMONHOC, m.TENMONHOC FROM dbo.LOP_MON lm , dbo.MONHOC m WHERE lm.MAMONHOC=m.MAMONHOC AND lm.MALOP={0}",idLop);
            return dtConnect.GETdata(query);
        }

        // them 1 mon hoc vao lop

        public void insertMonLop(int maLop, int maMon, int maGV)
        {
            string query = string.Format("INSERT dbo.LOP_MON ( MAMONHOC, MALOP, MAGIAOVIEN ) VALUES(   {0},  {1},  {2} )", maMon, maLop, maGV);
            dtConnect.ExecuteNonQuery(query);
        }
        public void XoaMonLop(int maLop, int maMon)
        {
            string query = string.Format("DELETE dbo.LOP_MON WHERE MAMONHOC= {0} AND MALOP={1}", maMon, maLop);
            dtConnect.ExecuteNonQuery(query);
        }
    }
}
