using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EZTest.Models
{
   public class SubjectType
    {
        public int SubjectTypeId { get; set; }
        public string Type { get; set; }

        public virtual ICollection<Subject> Subjects { get; set; }
    }
}
