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
        public DateTime HireDate { get; set; }
        public Teacher Teacher { get; set; }
        public Institution Institution { get; set; }
    }
}
