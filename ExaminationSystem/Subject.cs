using ExaminationSystem.Exams;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExaminationSystem
{
    public class Subject
    {
        public int SubjectId { get; set; }
        public string SubjectName { get; set; }
        public Exam Exam { get; set; }
        public Subject() { }
        public Subject(int id, string name)
        {
            this.SubjectId = id;
            this.SubjectName = name;
            
        }
        public void CreateExam(Exam exam)
        {
            this.Exam = exam;
        }

        public override string ToString()
        {
            return $"Subject ID: {SubjectId}, Subject Name: {SubjectName}";
        }
    }
}
