using WebApplication1.models;

namespace WebApplication1.Repositories
{
    public interface ITodoList
    {
        IEnumerable<Item> getItems();
        Item getItemById(int id);


    }
}
