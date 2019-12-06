using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EZTest.Models
{
    public class Answer
    {
        public int AnswerId { get; set; }
        public int QuestionId { get; set; }
        public string AnswerField { get; set; }
        public bool isCorrect { get; set; }


        public virtual Question Question { get; set; }
    }
}