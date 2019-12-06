using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EZTest.Models
{
    public class Question
    {
        public int QuestionId { get; set; }
        public string Title { get; set; }
        public short DifficultyLevel { get; set; }
        public DateTime CreationDate { get; set; }

        public virtual ICollection<Answer> Anwsers { get; set; }
        public virtual ICollection<TestQuestion> TestQuestions { get; set; }
        public virtual ICollection<SubjectQuestion> SubjectQuestions { get; set; }
    }
}