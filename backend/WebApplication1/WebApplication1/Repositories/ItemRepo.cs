using System.Data.SqlClient;
using System.Reflection.Metadata.Ecma335;
using System.Text.Json.Nodes;
using WebApplication1.models;

namespace WebApplication1.Repositories
{
    public class ItemRepo : ITodoList
    {
        private SqlConnection connection;

        public ItemRepo()
        {
            this.connection = new SqlConnection("Data Source=DESKTOP-13K214P;Initial Catalog=todo;Trusted_Connection=True");
            connection.Open();
        }
        List<Item> list= new List<Item>();


        public CreateItemModel CreateItem(CreateItemModel item)
        {
            DateTime localDate = DateTime.Now;
            string queryString = $"insert into todolist(name, description, completed, createdtime) values('{item.Name}', '{item.Description}', {0}, '{localDate}');";
            SqlCommand command = new SqlCommand(queryString, connection);
            
            try
            {
                int numberofRows = command.ExecuteNonQuery();
            }
            catch
            {
                return null;
            }
            return item;

        }

        public IEnumerable<Item> getItems()
        {
            string queryString = "SELECT * from todolist";
            
            
            SqlCommand command = new SqlCommand(queryString, connection);
            // int result = command.ExecuteNonQuery();
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    var id = reader.GetInt32(0);
                    var name = reader.GetString(1);
                    var desc = reader.GetString(2);
                    var finished = int.Parse(reader.GetString(3));
                    var created = reader.GetDateTime(4);
                    list.Add(new Item(id, name, desc, finished, created));
                }
            }

            return list;      
            
        }
             
        public int deleteItemByName(string itemName)
        {
            string queryString = $"DELETE FROM todolist where name='{itemName}'";
            SqlCommand command = new SqlCommand(queryString, connection);
            int numbersOfRows = command.ExecuteNonQuery();

            return numbersOfRows;
        }

        public Item UpdateItem(Item item)
        {
            deleteItemByName(item.Name);
            string queryString = $"insert into todolist(name, description, completed, createdtime) values('{item.Name}', '{item.Description}', {0}, '{item.DateCreated}');";
            SqlCommand command = new SqlCommand(queryString, connection);
            SqlDataReader reader = command.ExecuteReader();

            reader.Read();
            var id = reader.GetInt32(0);
            var name = reader.GetString(1);
            var desc = reader.GetString(2);
            var finished = int.Parse(reader.GetString(3));
            var created = reader.GetDateTime(4);

            return new Item(id, name, desc, finished, created);

        }
    }
    
}


