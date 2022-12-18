namespace ToDoList.Core.Services
{
    using MongoDB.Driver;
    using ToDoList.Core.Interfaces;
    using ToDoList.Core.Model;

    public class ItemsService : IItemService
    {
        private readonly IMongoCollection<ItemEntity> items;
        public ItemsService(IDbService dbClient)
        {
            items = dbClient.GetItemsCollection();
        }
        public List<ItemEntity> GetItems() => items.Find(item=> true).ToList();
        
        public ItemEntity AddItem(ItemEntity item)
        {
            items.InsertOne(item);
            return item;
        }

        public ItemEntity GetItem(string id)
        {
            return items.Find(item => item.Id == id).First();
        }

        public void DeleteItem(string id)
        {
            items.DeleteOne(item => item.Id == id);
        }

        public ItemEntity UpdateItem(ItemEntity item)
        {
            items.ReplaceOne(i => i.Id == item.Id, item);
            return item;
        }
    }
}