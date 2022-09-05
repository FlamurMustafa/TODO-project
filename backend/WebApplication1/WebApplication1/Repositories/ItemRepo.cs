using System.Data.SqlClient;
using WebApplication1.models;

namespace WebApplication1.Repositories
{
    public class ItemRepo : ITodoList
    {
        public Item getItemById(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Item> getItems()
        {
            string queryString = "SELECT * from todolist";
            SqlConnection connection = new SqlConnection("Data Source=DESKTOP-13K214P;Initial Catalog=todo;Trusted_Connection=True");
            connection.Open();

            SqlCommand command = new SqlCommand(queryString, connection);
            // int result = command.ExecuteNonQuery();
            using (SqlDataReader reader = command.ExecuteReader())
            {
                if (reader.Read())
                {
                    Console.WriteLine(String.Format("{0}", reader["id"]));
                }
            }

            return Enumerable.Empty<Item>();
                        
            
        }

    }    
}


