namespace ToDoList.Core.Interfaces
{
    using ToDoList.Core.Model;

    public interface IItemService
    {
        List<ItemEntity> GetItems();
    }
}