using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EZTest.Models
{
    public class TeacherSubject
    {
        public int TeacherSubjectId { get; set; }
        public int TeacherId { get; set; }
        public int SubjectId { get; set; }
        public DateTime AssignDate { get; set; }
        public virtual Teacher Teacher  { get; set; }
        public virtual Subject Subject { get; set; }
    }
}
