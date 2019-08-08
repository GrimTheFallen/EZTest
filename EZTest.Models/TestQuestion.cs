using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EZTest.Models
{
    public class TestQuestion
    {
        public int TestQuestionId { get; set; }
        public int TestId { get; set; }
        public int QuestionId { get; set; }

        public virtual DateTime CreationDate { get; set; }

        public virtual Test Test { get; set; }
        public virtual Question Question { get; set; }
        public virtual ICollection<Answer> Answers { get; set; }
    }
}