using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aludin.DAL
{
    public class AludinDbContext : 
        IAludinDbContext
    {
        public string AlumniCollectionName { get; set; }
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }
    }

    public interface IAludinDbContext
    {
        string AlumniCollectionName { get; set; }
        string ConnectionString { get; set; }
        string DatabaseName { get; set; }
    }
}
