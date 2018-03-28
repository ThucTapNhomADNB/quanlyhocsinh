using QuanLyHS_THPT.ENTITY;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyHS_THPT.DAL
{
    class BangDiemDAL
    {
        DatabaseConnect dtConnect = new DatabaseConnect();
        public DataTable LoadDSLop()
        {
            string query = "SELECT * FROM dbo.HOCSINH ";
            return dtConnect.GETdata(query);
        }
        public DataTable LoadDSMon()
        {
            string query = "SELECT * FROM dbo.MONHOC";
            return dtConnect.GETdata(query);
        }
        public DataTable LoadBangDiemHS(int mamon, int malop)
        {
            string query = string.Format("SELECT DISTINCT bd.MAHOCSINH, hs.HOTEN, bd.MAMONHOC,bd.HOCKY, bd.DIEMMIENG, bd.DIEM15PHUT, bd.DIEM1TIET, bd.DIEMHK, bd.DIEMTB FROM dbo.BANGDIEM bd, dbo.HOCSINH hs, dbo.MONHOC mh, dbo.LOP_MON ml WHERE bd.MAHOCSINH = hs.MAHOCSINH AND bd.MAMONHOC = mh.MAMONHOC AND bd.MAMONHOC = {0} AND  hs.MAHOCSINH IN(SELECT kq.MAHOCSINH FROM dbo.KETQUAHOCTAP kq WHERE kq.MALOP = {1})", mamon,malop);
            return dtConnect.GETdata(query);
        }
        public void updateBangdiem(BangDiem bd)
        {
            string query = string.Format("UPDATE dbo.BANGDIEM SET HOCKY={0}, DIEM15PHUT={1},DIEMMIENG={2},DIEM1TIET={3},DIEMHK={4},DIEMTB={5} WHERE MAHOCSINH={6} AND MAMONHOC={7}  ",bd.HocKi,bd.DiemMieng,bd.Diem15ph,bd.Diem1tiet, bd.DiemCuoiKi,bd.DiemTB,bd.MaHocSinh,bd.MaMon);
            dtConnect.ExecuteNonQuery(query);
        }
    }
}
