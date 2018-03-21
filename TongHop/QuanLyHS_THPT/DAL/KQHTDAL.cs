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
        public DataTable LoadDS(int ma)
        {
            string query = string.Format(" SELECT  HS.MAHOCSINH , HOTEN, DIEMTBKY1 , DIEMTBKY2, DIEMTBCANAM  FROM dbo.KETQUAHOCTAP kqht, dbo.HOCSINH HS WHERE kqht.MAHOCSINH = HS.MAHOCSINH and kqht.MALOP={0}", ma);
            return dtConnect.GETdata(query);

        }
    }
}
