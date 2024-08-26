using MongoDB.Driver;

namespace cybershield_api.Data
{
    public class DBContext
    {
        private IMongoDatabase _database;
        public DBContext() 
        {
            string connectionUri = "mongodb+srv://araujog175:GMtgb123.@cluster0.peqin.mongodb.net/Jogdb";
            var mongoUrl = MongoUrl.Create(connectionUri);
            var client = new MongoClient(mongoUrl);
            _database = client.GetDatabase(mongoUrl.DatabaseName);
        }
        public IMongoDatabase? Database => _database;
    }
}
