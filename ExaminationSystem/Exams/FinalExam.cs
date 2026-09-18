using ExaminationSystem.Questions;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExaminationSystem.Exams
{
    public class FinalExam : Exam

    {
        public FinalExam(int time, int numberOfQuestions)
           : base(time, numberOfQuestions)
        {
        }
        public override void ShowExam()
        {
            StartTime = DateTime.Now;

            Console.WriteLine("===== Final Exam =====");
            Console.WriteLine($"Time Allowed: {Time} minutes");
            Console.WriteLine($"Number Of Questions: {NumberOfQuestions}");
            Console.WriteLine();

            int grade = 0;

            foreach (Question question in Questions)
            {
                question.Display();

                Console.Write("Enter your answer: ");
                int userAnswer = int.Parse(Console.ReadLine());

                if (userAnswer == question.RightAnswer.AnswerId)
                {
                    grade += question.Mark;
                }

                Console.WriteLine();
            }

            EndTime = DateTime.Now;

            Console.WriteLine($"Your Grade: {grade}");
            Console.WriteLine($"Time Taken: {TimeTaken.TotalMinutes:F2} minutes");
        }
    }
}
