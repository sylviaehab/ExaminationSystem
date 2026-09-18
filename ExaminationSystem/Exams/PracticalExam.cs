using ExaminationSystem.Questions;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExaminationSystem.Exams
{
    public class PracticalExam : Exam
    {

        public PracticalExam(int time, int numberOfQuestions) : base(time, numberOfQuestions) { }
        public override void ShowExam()
        {
            StartTime = DateTime.Now;
            Console.WriteLine("===== Practical Exam =====");
            Console.WriteLine($"Time Allowed: {Time} minutes");
            Console.WriteLine($"Number Of Questions: {NumberOfQuestions}");
            Console.WriteLine();
           foreach (Question question in Questions)
            {
                question.Display();
                Console.WriteLine("Enter Your Answer : ");
                int userAnswer = int.Parse(Console.ReadLine());
                Console.WriteLine();
            }
            EndTime = DateTime.Now;

            Console.WriteLine("Show Right Answers:");
            foreach (Question question in Questions)
            {
                Console.WriteLine($"Question: {question.Body}");
                Console.WriteLine($"Right Answer: {question.RightAnswer}");
                Console.WriteLine();
            }
            Console.WriteLine($"Time Taken: {TimeTaken.TotalMinutes:F2} minutes");
        }
    
    }
}
