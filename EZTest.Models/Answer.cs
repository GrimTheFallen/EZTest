using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EZTest.Models
{
    public class Answer
    {
        public int AnswerId { get; set; }
        public string AnswerField { get; set; }

        public int TestQuestionId { get; set; }
        public virtual TestQuestion TestQuestion { get; set; }
    }
}