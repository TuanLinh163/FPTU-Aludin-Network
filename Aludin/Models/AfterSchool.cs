using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aludin.Models
{
    [BsonKnownTypes(typeof(Job), typeof(Academy), typeof(Archivement))]
    public class AfterSchool
    {

    }

    public class Job : 
        AfterSchool
    {
        public string Description { get; set; }
        public string Major { get; set; }
        public string Promotion { get; set; }
        public string Company { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public double Salary { get; set; }
    }


    public class Academy :
        AfterSchool
    {
        public string Major { get; set; }
        public string School { get; set; }
        public string Description { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
    }

    public class Archivement :
        AfterSchool
    {
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public string Reward { get; set; }
    }
}
