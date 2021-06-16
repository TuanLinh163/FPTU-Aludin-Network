using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aludin.Models
{
    public class Alumnus
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public string AccId { get; set; }
        public string Name { get; set; }
        public int Gender { get; set; }
        public DateTime BirthDate { get; set; }
        public string Email { get; set; }
        public int Address { get; set; }
        public string Ethnic { get; set; }
        public string PhoneNo { get; set; }
        public string Religion { get; set; }
        public string IdCard { get; set; }
        public int MaritalStatus { get; set; }
        public string Hobbies { get; set; }
        public string CurrentJob { get; set; }
        public InUniInfo InUniInfo { get; set; }
        public Dictionary<string, string> SocialLinks { get; set; }
        public List<AfterSchool> AfterSchools { get; set; }
    }
}
