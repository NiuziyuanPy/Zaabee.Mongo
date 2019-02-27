using System.Linq;
using Xunit;
using MongoDB.Bson;
using Zaabee.Mongo;
using Zaabee.Mongo.Abstractions;

namespace NiuZiYuanTestProject
{
    public class AddTest
    {
        private readonly IZaabeeMongoClient _client;

        public AddTest()
        {
            _client = new ZaabeeMongoClient(
                "mongodb://192.168.213.130:27017/TestDB/?readPreference=primary", "TestDB");
        }

        [Fact]
        public void Add()
        {
            var model = new GetModel().AddModel();
            _client.Add(model);
            var result = _client.GetQueryable<Add>().FirstOrDefault(p => p.Id == model.Id);
            Assert.NotNull(result);
            Assert.Equal(model.ToJson(), result.ToJson());
        }
        
    }
}