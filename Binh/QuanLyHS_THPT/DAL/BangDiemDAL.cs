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
    }
}
