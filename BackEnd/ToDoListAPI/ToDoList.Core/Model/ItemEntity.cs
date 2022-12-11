using MongoDB.Bson.Serialization.Attributes;

namespace ToDoList.Core.Model
{
    public class ItemEntity
    {
        [BsonId]
        [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        public Guid Id { get; set; }

        public string Name { get; set; }

        public DateTime CreationDate { get; set; }

        public string Category { get; set; }

        public string Creator { get; set; }

    }
}
