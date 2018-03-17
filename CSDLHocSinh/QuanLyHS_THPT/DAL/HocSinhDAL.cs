using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyHS_THPT.DAL
{
    class HocSinhDAL: DatabassConnect
    {
        public DataTable GET()
        {
            try
            {
                string query = "SELECT * FROM HOCSINH ";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable data = new DataTable();
                adapter.Fill(data);
                return data;
            }
            catch
            {
                return null;
            }
        }
    }
}
