using MongoDB.Bson.Serialization.Attributes;

namespace cybershield_api.Models
{
    public class ScoresModel
    {
        [BsonId]
        [BsonElement("_id"), BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        public string? Id { get; set; }

        [BsonElement("Users_id"), BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        public string Users_id { get; set; }

        [BsonElement("Score"), BsonRepresentation(MongoDB.Bson.BsonType.Int64)]
        public int score { get; set; }

        [BsonElement("HoraPontuacao"), BsonRepresentation(MongoDB.Bson.BsonType.String)]
        public string HoraPontuacao { get; set; }

        public ScoresModel(string users_id, int score, string horaPontuacao)
        {
            Users_id = users_id;
            this.score = score;
            HoraPontuacao = horaPontuacao;
        }
    }
}
