using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyHS_THPT.DAL
{
    class KQHTDAL
    {
        DatabaseConnect dtConnect = new DatabaseConnect();
        public DataTable LoadDS()
        {
            string query = " SELECT  HS.MAHOCSINH , DIEMTBKY1 , DIEMTBKY2, DIEMTBCANAM, HANHKIEM_KY1, HANHKIEM_KI2, HANHKIEM_KY3  FROM dbo.KETQUAHOCTAP kqht, dbo.HOCSINH HS WHERE kqht.MAHOCSINH = HS.MAHOCSINH";
            return dtConnect.GETdata(query);
        }
    }
}
