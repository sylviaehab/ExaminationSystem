using ExaminationSystem.Exams;
using ExaminationSystem.Questions;

namespace ExaminationSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Subject ID: ");
            int subjectId = int.Parse(Console.ReadLine());

            Console.Write("Enter Subject Name: ");
            string subjectName = Console.ReadLine();

            Subject subject = new Subject(
                subjectId,
                subjectName
            );

            ExamType examType;
            int examChoice;

            do
            {
                Console.WriteLine();
                Console.WriteLine("Choose Exam Type:");
                Console.WriteLine("1. Final");
                Console.WriteLine("2. Practical");

                Console.Write("Enter your choice: ");
                examChoice = int.Parse(Console.ReadLine());

                if (examChoice != 1 && examChoice != 2)
                {
                    Console.WriteLine(
                        "Invalid choice. Please enter 1 or 2."
                    );
                }

            } while (examChoice != 1 && examChoice != 2);

            examType = (ExamType)examChoice;


            Console.WriteLine();

            Console.Write("Enter Exam Time in minutes: ");
            int time = int.Parse(Console.ReadLine());

            Console.Write("Enter Number Of Questions: ");
            int numberOfQuestions =
                int.Parse(Console.ReadLine());


            Exam exam;

            if (examType == ExamType.Final)
            {
                exam = new FinalExam(
                    time,
                    numberOfQuestions
                );
            }
            else
            {
                exam = new PracticalExam(
                    time,
                    numberOfQuestions
                );
            }


            for (int i = 0; i < numberOfQuestions; i++)
            {
                Console.WriteLine();
                Console.WriteLine(
                    $"========== Question {i + 1} =========="
                );

                Console.Write("Enter Question Header: ");
                string header = Console.ReadLine();

                Console.Write("Enter Question Body: ");
                string body = Console.ReadLine();

                Console.Write("Enter Question Mark: ");
                int mark = int.Parse(Console.ReadLine());


                if (examType == ExamType.Final)
                {
                    QuestionType questionType;
                    int questionChoice;

                    do
                    {
                        Console.WriteLine();
                        Console.WriteLine("Choose Question Type:");
                        Console.WriteLine("1. True / False");
                        Console.WriteLine("2. MCQ");

                        Console.Write("Enter your choice: ");
                        questionChoice =
                            int.Parse(Console.ReadLine());

                        if (questionChoice != 1 &&
                            questionChoice != 2)
                        {
                            Console.WriteLine(
                                "Invalid choice. Please enter 1 or 2."
                            );
                        }

                    } while (questionChoice != 1 &&
                             questionChoice != 2);

                    questionType =
                        (QuestionType)questionChoice;


                    if (questionType ==
                        QuestionType.TrueFalse)
                    {
                        Answer trueAnswer =
                            new Answer(1, "True");

                        Answer falseAnswer =
                            new Answer(2, "False");

                        Answer[] answers =
                        {
                            trueAnswer,
                            falseAnswer
                        };


                        int rightAnswerId;

                        do
                        {
                            Console.WriteLine();
                            Console.WriteLine(
                                "Choose Right Answer:"
                            );

                            Console.WriteLine("1. True");
                            Console.WriteLine("2. False");

                            Console.Write("Enter your choice: ");

                            rightAnswerId =
                                int.Parse(Console.ReadLine());

                            if (rightAnswerId != 1 &&
                                rightAnswerId != 2)
                            {
                                Console.WriteLine(
                                    "Invalid choice. Please enter 1 or 2."
                                );
                            }

                        } while (rightAnswerId != 1 &&
                                 rightAnswerId != 2);


                        Answer rightAnswer;

                        if (rightAnswerId == 1)
                        {
                            rightAnswer = trueAnswer;
                        }
                        else
                        {
                            rightAnswer = falseAnswer;
                        }


                        exam.Questions[i] =
                            new TrueOrFalseQuestion(
                                header,
                                body,
                                mark,
                                answers,
                                rightAnswer
                            );
                    }


                    else
                    {
                        Answer[] answers =
                            new Answer[4];

                        for (int j = 0;
                             j < answers.Length;
                             j++)
                        {
                            Console.Write(
                                $"Enter Answer {j + 1}: "
                            );

                            string answerText =
                                Console.ReadLine();

                            answers[j] =
                                new Answer(
                                    j + 1,
                                    answerText
                                );
                        }


                        int rightAnswerId;

                        do
                        {
                            Console.Write(
                                "Enter Right Answer ID (1-4): "
                            );

                            rightAnswerId =
                                int.Parse(Console.ReadLine());

                            if (rightAnswerId < 1 ||
                                rightAnswerId > 4)
                            {
                                Console.WriteLine(
                                    "Invalid choice. Please enter 1-4."
                                );
                            }

                        } while (rightAnswerId < 1 ||
                                 rightAnswerId > 4);


                        Answer rightAnswer =
                            answers[rightAnswerId - 1];


                        exam.Questions[i] =
                            new MCQQuestion(
                                header,
                                body,
                                mark,
                                answers,
                                rightAnswer
                            );
                    }
                }



                else
                {
                   

                    Answer[] answers =
                        new Answer[4];

                    for (int j = 0;
                         j < answers.Length;
                         j++)
                    {
                        Console.Write(
                            $"Enter Answer {j + 1}: "
                        );

                        string answerText =
                            Console.ReadLine();

                        answers[j] =
                            new Answer(
                                j + 1,
                                answerText
                            );
                    }


                    int rightAnswerId;

                    do
                    {
                        Console.Write(
                            "Enter Right Answer ID (1-4): "
                        );

                        rightAnswerId =
                            int.Parse(Console.ReadLine());

                        if (rightAnswerId < 1 ||
                            rightAnswerId > 4)
                        {
                            Console.WriteLine(
                                "Invalid choice. Please enter 1-4."
                            );
                        }

                    } while (rightAnswerId < 1 ||
                             rightAnswerId > 4);


                    Answer rightAnswer =
                        answers[rightAnswerId - 1];


                    exam.Questions[i] =
                        new MCQQuestion(
                            header,
                            body,
                            mark,
                            answers,
                            rightAnswer
                        );
                }
            }

            subject.CreateExam(exam);
            Console.WriteLine();
            Console.WriteLine("================================");
            Console.WriteLine(subject);
            Console.WriteLine("================================");
            Console.WriteLine();

            subject.Exam.ShowExam();
        }
    }
}