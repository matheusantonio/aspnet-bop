using System.Collections.Generic;
using System.Linq;
using ApiBop.Models;
using Microsoft.Extensions.Configuration;
using MongoDB.Driver;

namespace ApiBop.Services
{
    public class NotaService
    {
        private readonly IMongoCollection<Nota> _notas;

        public NotaService(IConfiguration config){
            var client = new MongoClient(config.GetConnectionString("notas_db"));
            var database = client.GetDatabase("notas_db");
            _notas = database.GetCollection<Nota>("tb_nota");
        }

        public List<Nota> Get(){
            return _notas.Find(nota => true).ToList();
        }

        public Nota Get(string id){
            return _notas.Find<Nota>(nota => nota._id == id).FirstOrDefault();
        }


    }
}