using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ApiBop.Models
{
    public class Nota
    {
        /*
        Existem duas ids porque o MongoDB gera uma coluna de ID automática
        Eu pretendia simplesmente ignorar o atributo id (como fiz com o mysql)
        mas eu acabei chamando a coluna no postgres de "id" e isso gerou um
        conflito. Portanto, gerei uma coluna _id no postgres e estou apenas
        atribuindo como string o mesmo valor que o id_note */
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string _id {get; set;}

        [BsonElement("id_note")]
        [Column("id")]
        [Key]
        public int id_note {get; set;}
        [BsonElement("titulo")]
        [Column("titulo")]
        public string Titulo {get; set;}
        [BsonElement("descricao")]
        [Column("descricao")]
        public string Descricao {get; set;}
    }
}