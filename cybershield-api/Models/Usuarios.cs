using MongoDB.Bson.Serialization.Attributes;

namespace cybershield_api.Models
{
    public class Usuarios
    {
        [BsonId]
        [BsonElement("_id"), BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        public string? Id { get; set; }

        [BsonElement("Username"), BsonRepresentation(MongoDB.Bson.BsonType.String)]
        public string Username { get; set; }

        [BsonElement("Email"), BsonRepresentation(MongoDB.Bson.BsonType.String)]
        public string Email { get; set; }

        [BsonElement("Dt_atualizacao"), BsonRepresentation(MongoDB.Bson.BsonType.String)]
        public string Dt_atualizacao { get; set; }

        [BsonElement("Dt_criacao"), BsonRepresentation(MongoDB.Bson.BsonType.String)]
        public string Dt_criacao { get; set; }

        [BsonElement("Password"), BsonRepresentation(MongoDB.Bson.BsonType.String)]
        public string Password { get; set; }
        public Usuarios(string username, string email, string password)
        {
            DateTime CreatedAt = DateTime.Now;
            Username = username;
            Email = email;
            Dt_atualizacao = CreatedAt.ToString();
            Dt_criacao = CreatedAt.ToString();
            Password = password;
        }
    }
}
