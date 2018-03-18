using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyHS_THPT.DAL
{
    class DatabassConnect
    {
        protected SqlConnection connection = new SqlConnection(@"Data Source=.\sqlexpress;Initial Catalog=QUANLYHOCSINH;Integrated Security=True");
   
     
    }
}
