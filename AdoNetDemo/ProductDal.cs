using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoNetDemo
{
    public class ProductDal
    {
        public List<Product> GetAll()
        {
            SqlConnection connection =  new SqlConnection
             ("server=(localdb)\\MSSQLLocalDB;initial catalog=ETrade;integrated security=true");
            //connectin string boglanti qururuq
            if (connection.State == ConnectionState.Closed)
            {

               connection.Open();
            }
            //baglantinin aciq olub olmamasini yoxlyruq

            SqlCommand sqlCommand = new SqlCommand("Select * from Products",connection);

            //baglantiya gonderilecek sorgunu yaziriq
            SqlDataReader reader = sqlCommand.ExecuteReader();
            //sogunu oxuyuruq
            List<Product> products = new List<Product>();

            while (reader.Read())
            {
                Product product = new Product
                {
                    Id = Convert.ToInt32(reader["Id"]),
                    Name = reader["Name"].ToString(),
                    StockAmount = Convert.ToInt32(reader["StockAmount"]),
                    UnitPrice = Convert.ToDecimal(reader["UnitPrice"])
                };
                products.Add(product);

            }

            //oxudugumuz datani datatableye yaziiri
            reader.Close();
            //readeri baglayiriq
            connection.Close();
            //connectionu baglayiriq
            return products;
            //datatable dondururuk

          
            

        }
       
    }
}
