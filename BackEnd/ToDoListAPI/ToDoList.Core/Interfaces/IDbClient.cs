using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoList.Core.Model;

namespace ToDoList.Core.Interfaces
{
    public interface IDbClient
    {
        IMongoCollection<ItemEntity> GetItemsCollection();
    }
}
