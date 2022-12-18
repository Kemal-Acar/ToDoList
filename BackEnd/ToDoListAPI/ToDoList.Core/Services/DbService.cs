namespace ToDoList.Core.Services
{
    using Microsoft.Extensions.Options;
    using MongoDB.Driver;
    using ToDoList.Core.Configuration;
    using ToDoList.Core.Interfaces;
    using ToDoList.Core.Model;

    public class DbService : IDbService
    {
        private readonly IMongoCollection<ItemEntity> items;
        public DbService(IOptions<ItemsDbConfig> itemsDbConfig)
        {
            var client = new MongoClient(itemsDbConfig.Value.Connection_String);
            var database = client.GetDatabase(itemsDbConfig.Value.Database_Name);
            this.items = database.GetCollection<ItemEntity>(itemsDbConfig.Value.Items_Collection_Name);
        }
        public IMongoCollection<ItemEntity> GetItemsCollection()
        {
            return this.items;
        }
    }
}
