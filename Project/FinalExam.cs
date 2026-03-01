using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    internal class FinalExam :Exam
    {
        public FinalExam(int t, int n, Subject s) : base(t, n, s)
        {
        }
        protected override void ShowQuestions()
        {
            for (int i = 0; i < Questions.Count; i++)
            {
                Questions[i].Show();
            }
        }
        protected override void TakeAnswers()
        {
            for (int i = 0; i < Questions.Count; i++)
            {
                Questions[i].TakeAnswer();
            }
        }
        protected override void ShowResult()
        {
            Total = 0;
            Console.WriteLine("===== Results =====");
            for (int i = 0; i < Questions.Count; i++)
            {
                double degree = Questions[i].CalcDegree();

                Total += degree;
                Console.WriteLine($"Marks: {degree}/{Questions[i].Marks}");
                Console.WriteLine("-------------------");
            }
            Console.WriteLine($"Final Grade: {Total}");
        }
    }
}
