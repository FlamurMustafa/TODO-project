using WebApplication1.models;

namespace WebApplication1.Repositories
{
    public interface ITodoList {

        public CreateItemModel CreateItem(CreateItemModel item);
        public IEnumerable<Item> getItems();
        public int deleteItemByName(string itemName);
        public int UpdateItem(CreateItemModel item, int itemId);

    }
}
