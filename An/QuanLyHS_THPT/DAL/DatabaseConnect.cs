using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyHS_THPT.DAL
{
    class DatabaseConnect
    {
        public SqlConnection dataConection() {
             return new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=QUANLYHOCSINH;Integrated Security=True");
        }
        public DataTable GETdata(string querySQL)
        {
            try
            {
                SqlConnection connection = dataConection();
                SqlDataAdapter adapter = new SqlDataAdapter(querySQL, connection);
                DataTable data = new DataTable();
                adapter.Fill(data);
                return data;
            }
            catch
            {
                MessageBox.Show("Khong lai duoc du lieu", "loi");
                return null;
            }
        }
        
        public void ExecuteNonQuery(string querySQL)
        {
            try
            {
                SqlConnection connection = dataConection();
                connection.Open();
                SqlCommand command = new SqlCommand(querySQL, connection);
                command.ExecuteNonQuery();
                command.Dispose();
                connection.Close();

            }
            catch
            {
                MessageBox.Show("Loi thuc thi ", "Loi");
                
            }

        }
    }
}
