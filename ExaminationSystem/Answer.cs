using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Security.Principal;
using System.Text;

namespace ExaminationSystem
{
    public class Answer
    {
        public int AnswerId { get; set; }
        public string AnswerText { get; set; }

        public Answer() { }

        public Answer(int answerId, string answerText)
        {
            this.AnswerId = answerId;
            this.AnswerText = answerText;
        }

        public override string ToString()
        {
            return $"{AnswerId}. {AnswerText}";
        }
    }
}
