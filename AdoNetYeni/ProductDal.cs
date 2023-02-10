using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoNetYeni
{
    public class ProductDal
    {
        SqlConnection _connection = new SqlConnection
              ("server=(localdb)\\MSSQLLocalDB;initial catalog=ETrade;integrated security=true");
        public List<Product> GetAll()
        {
            //connectin string boglanti qururuq
            ConnectionControl();
            //baglantinin aciq olub olmamasini yoxlyruq

            SqlCommand sqlCommand = new SqlCommand("Select * from Products", _connection);

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
            _connection.Close();
            //connectionu baglayiriq
            return products;
            //datatable dondururuk




        }

        public void Add(Product product)
        {
            ConnectionControl();

            SqlCommand command = new
                SqlCommand("Insert into Products values(@name,@unitPrice,@stockAmount)", _connection);
            command.Parameters.AddWithValue("@name", product.Name);
            command.Parameters.AddWithValue("@unitPrice", product.UnitPrice);
            command.Parameters.AddWithValue("@stockAmount", product.StockAmount);

            command.ExecuteNonQuery();

            _connection.Close();
        }
        public void Update(Product product)
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand("Update Products set Name=@name, UnitPrice=@unitPrice, " +
                "StockAmount=@stockAmount where Id=@id ", _connection);
            command.Parameters.AddWithValue("@name", product.Name);
            command.Parameters.AddWithValue("@unitPrice", product.UnitPrice);
            command.Parameters.AddWithValue("@stockAmount", product.StockAmount);
            command.Parameters.AddWithValue("@id", product.Id);
            command.ExecuteNonQuery();
            _connection.Close();



        }
        public void Delete(int Id)
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand("Delete From Products where Id=@id", _connection);
            command.Parameters.AddWithValue("@id",Id);
            command.ExecuteNonQuery();
            _connection.Close();

        }
        private void ConnectionControl()
        {
            if (_connection.State == ConnectionState.Closed)
            {

                _connection.Open();
            }
        }
    }
}
