using DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class RestaurantRepository
    {
        public List<Restaurant> GettAllRestaurant()
        {
            List<Restaurant> all = new List<Restaurant>();

            using (SqlConnection sqlConnection = new SqlConnection(Constants.connectionString))
            {
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = "SELECT * FROM MenuItems";

                sqlConnection.Open();

                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    Restaurant r = new Restaurant();
                    r.Id = sqlDataReader.GetInt32(0);
                    r.Title = sqlDataReader.GetString(1);
                    r.Description = sqlDataReader.GetString(2);
                    r.Price = sqlDataReader.GetDecimal(3);

                    all.Add(r);
                }

            }

            return all;
        }

        public int InsertMenuItems(Restaurant r)
        {
            using(SqlConnection sqlConnection = new SqlConnection(Constants.connectionString))
            {
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = String.Format("INSERT INTO MenuItems VALUES ('{0}', '{1}', {2})", r.Title, r.Description, r.Price);

                sqlConnection.Open();

                return sqlCommand.ExecuteNonQuery();
            }
        }
    }
}
