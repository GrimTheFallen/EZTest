using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EZTest.Models
{
    public class InstitutionType
    {
        public int InstitutionTypeId { get; set; }
        public string Type { get; set; }

        public virtual ICollection<Institution> Institutions { get; set; }
    }
}
