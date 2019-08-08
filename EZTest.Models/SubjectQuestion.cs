using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EZTest.Models
{
    public class SubjectQuestion
    {
        public int SubjectQestionId { get; set; } 
        public int SubjectId { get; set; }
        public int QuestionId { get; set; }

        public DateTime CreationDate { get; set; }

        public virtual Subject Subject { get; set; }
        public virtual Question Question { get; set; }
    }
}