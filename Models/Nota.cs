using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace ApiBop.Models
{
    public class Nota
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string id {get; set;}

        [BsonElement("id_note")]
        public int id_note {get; set;}
        [BsonElement("titulo")]
        public string Titulo {get; set;}
        [BsonElement("descricao")]
        public string Descricao {get; set;}
    }
}