namespace ToDoList.Core.Interfaces
{
    using ToDoList.Core.Model;

    public interface IItemService
    {
        ItemEntity AddItem(ItemEntity item);

        List<ItemEntity> GetItems();

        ItemEntity GetItem(string id);

        void DeleteItem(string id);

        ItemEntity UpdateItem(ItemEntity item);
    }
}