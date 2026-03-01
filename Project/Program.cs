namespace Project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Exam Exam1 = new PracticeExam(60,3,new("math"));
            Question q1 = new TrueFalseQuestion("Q1", "C# is an OOP language?", 5, "true");
            Question q2 = new ChooseQuestion("Q2", "2 + 2 = ?", 3, "1", ["2","4","6","8"]);
            Question q3 = new TrueFalseQuestion("Q3", "in c# Class is value Type", 5, "false");

            Exam1.AddQuestion(q1);
            Exam1.AddQuestion(q2);
            Exam1.AddQuestion(q3);
            Exam1.StartExam();
            

        }
    }
}
