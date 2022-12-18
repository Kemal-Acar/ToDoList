namespace ToDoList.Core.Interfaces
{
    using MongoDB.Driver;
    using ToDoList.Core.Model;
    public interface IDbService
    {
        IMongoCollection<ItemEntity> GetItemsCollection();
    }
}
