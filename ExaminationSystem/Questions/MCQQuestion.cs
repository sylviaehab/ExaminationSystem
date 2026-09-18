using System;
using System.Collections.Generic;
using System.Text;

namespace ExaminationSystem.Questions
{
    public class MCQQuestion : Question
    {
        public MCQQuestion(string header, string body, int mark, Answer[] answerList, Answer rightAnswer) : base(header, body, mark, answerList, rightAnswer)
        {
        }
        public override void Display()
        {
            Console.WriteLine(Header);
            Console.WriteLine(Body);
            foreach (Answer answer in AnswerList)
            {
                Console.WriteLine(answer);
            }
        }
    }
}
