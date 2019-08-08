using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EZTest.Models
{
    public class TeacherInstitution
    {
        public int TeacherInstitutionId { get; set; }
        public int TeacherId { get; set; }
        public int InstitutionId { get; set; }

        public DateTime HireDate { get; set; }

        public virtual Teacher Teacher { get; set; }
        public virtual Institution Institution { get; set; }
    }
}
