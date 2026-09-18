using ExaminationSystem.Questions;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExaminationSystem.Exams
{
    public abstract class Exam
    {
        public int Time { get; set; }

        public int NumberOfQuestions { get; set; }

        public Question[] Questions { get; set; }

        public DateTime StartTime { get; set; }

        public DateTime EndTime { get; set; }

        public TimeSpan TimeTaken
        {
            get
            {
                return EndTime - StartTime;
            }
        }

        protected Exam()
        {
        }

        protected Exam(int time, int numberOfQuestions)
        {
            Time = time;
            NumberOfQuestions = numberOfQuestions;

            Questions = new Question[numberOfQuestions];
        }

        public abstract void ShowExam();

        public override string ToString()
        {
            return $"Time Allowed: {Time} minutes, Number Of Questions: {NumberOfQuestions}";
        }
    }
}