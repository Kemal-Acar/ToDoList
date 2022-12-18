namespace ToDoList.Core.Services
{
    using MongoDB.Driver;
    using ToDoList.Core.Interfaces;
    using ToDoList.Core.Model;

    public class ItemsService : IItemService
    {
        private readonly IMongoCollection<ItemEntity> items;
        public ItemsService(IDbClient dbClient)
        {
            items = dbClient.GetItemsCollection();
        }
        public List<ItemEntity> GetItems() => items.Find(item=> true).ToList();
        
    }
}