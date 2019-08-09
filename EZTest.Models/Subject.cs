using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EZTest.Models
{
    public class Subject
    {
        public int SubjectId { get; set; }
        public string Name { get; set; }
        public string TypeOfScience { get; set; } // IT, Math, Biology, etc. //ToDo
        
        public virtual ICollection<SubjectQuestion> SubjectQuestions { get; set; }
        public virtual ICollection<TeacherSubject> TeacherSubjects { get; set; }
    }
}