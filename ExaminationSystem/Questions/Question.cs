using System;
using System.Collections.Generic;
using System.Text;

namespace ExaminationSystem.Questions
{
    public abstract class Question : ICloneable, IComparable<Question>
    {
        public string Header { get; set; }
        public string Body { get; set; }
        public int Mark { get; set; }
        public Answer[] AnswerList { get; set; } 
        public Answer RightAnswer { get; set; }
        protected Question() {
        }

        public Question(string header, string body, int mark, Answer[] answerList, Answer rightAnswer)
        {
            Header = header;
            Body = body;
            Mark = mark;
            AnswerList = answerList;
            RightAnswer = rightAnswer;
        }
        public abstract void Display();
        // ICloneable
        public object Clone() 
        { 
            return MemberwiseClone(); } 
        // IComparable
         public int CompareTo(Question? other)
        { if (other == null) 
                return 1;
            return Mark.CompareTo(other.Mark); }
        public override string ToString() 
        { return $"{Header}: {Body} - Mark: {Mark}"; }
    }
}
