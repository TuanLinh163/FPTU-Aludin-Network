using Aludin.Models;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aludin.DAL
{
    public class AlumniDAO
    {
        private readonly IMongoCollection<Alumnus> _alumni;

        public AlumniDAO(IAludinDbContext dbContext)
        {
            var client = new MongoClient(dbContext.ConnectionString);
            var database = client.GetDatabase(dbContext.DatabaseName);

            _alumni = database.GetCollection<Alumnus>(dbContext.AlumniCollectionName);
        }
    }
}
