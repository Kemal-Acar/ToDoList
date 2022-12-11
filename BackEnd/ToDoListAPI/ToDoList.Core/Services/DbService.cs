using Microsoft.Extensions.Options;
using MongoDB.Driver;
using ToDoList.Core.Configuration;
using ToDoList.Core.Interfaces;
using ToDoList.Core.Model;

namespace ToDoList.Core.Services
{
    public class DbService : IDbClient
    {
        private readonly IMongoCollection<ItemEntity> items;
        public DbService(
            IOptions<ItemsDbConfig> itemsDbConfig)
        {
            var client = new MongoClient(itemsDbConfig.Value.Connection_String);
            var databse = client.GetDatabase(itemsDbConfig.Value.DatabseName);
            this.items = databse.GetCollection<ItemEntity>(itemsDbConfig.Value.Items_Collection_Name);
        }
        public IMongoCollection<ItemEntity> GetItemsCollection()
        {
            return this.items;
        }
    }
}
