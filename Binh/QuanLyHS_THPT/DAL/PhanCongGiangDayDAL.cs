using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyHS_THPT.DAL
{
    class PhanCongGiangDayDAL
    {
        DatabaseConnect dtConnect = new DatabaseConnect();
        public DataTable LayMonLop()
        {
           
            string query = "SELECT DISTINCT LopMon.MALOP, LopMon.TENLOP,LopMon.MAMONHOC, LopMon.TENMONHOC,gv.MAGIAOVIEN, gv.HOTEN FROM(SELECT l.MALOP,l.TENLOP,m.MAMONHOC, m.TENMONHOC, lm.MAGIAOVIEN FROM dbo.LOP l, dbo.MONHOC m, dbo.LOP_MON lm, dbo.GIAOVIEN gv WHERE l.MALOP = lm.MALOP AND m.MAMONHOC = lm.MAMONHOC)LopMon LEFT JOIN dbo.GIAOVIEN gv ON LopMon.MAGIAOVIEN = gv.MAGIAOVIEN";
            return dtConnect.GETdata(query);
        }
        public void PhanCong(int maMon, int maLop, int maGV)
        {
            string query =string.Format("UPDATE dbo.LOP_MON SET MAGIAOVIEN={0} WHERE MAMONHOC={1} AND MALOP={2}",maGV,maMon,maLop);
            dtConnect.ExecuteNonQuery(query);
        }
    }
}
