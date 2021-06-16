using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aludin.Models
{
    public class InUniInfo
    {
        public string Code { get; set; }
        public string Major { get; set; }
        public string Campus { get; set; }
        public DateTime GraduationDate { get; set; }
        public int K { get; set; }
        public string DiplomaRank { get; set; }
        public List<string> Archivements { get; set; }
    }
}
