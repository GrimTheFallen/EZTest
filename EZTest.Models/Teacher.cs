using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EZTest.Models
{
   public class Teacher
    {
        public int TeacherId { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public bool IsBoss { get; set; }

        public virtual ICollection<TeacherSubject> TeacherSubjects { get; set; }
        public virtual ICollection<TeacherInstitution> TeacherInstitutions { get; set; }
    }
}
