using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EZTest.Models
{
    public class Institution
    {
        public int InstitutionId { get; set; }
        public string InstitutionName { get; set; }
        public string Type { get; set; } // like school, university etc.  

        public virtual ICollection<TeacherInstitution> TeacherInstitutions { get; set; }
        public virtual ICollection<Adress> Adresses { get; set; }
        

    }
}
