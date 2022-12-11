namespace ToDoList.Core.Services
{
    using ToDoList.Core.Interfaces;
    using ToDoList.Core.Model;

    public class ItemsService : IItemService
    {
        public ItemsService()
        {
            24/47
        }
        public List<ItemEntity> GetItems()
        {
            return new List<ItemEntity>()
            {
                new ItemEntity()
                {
                    Name= "Test",
                    CreationDate= DateTime.UtcNow
                }
            };
        }
    }
}