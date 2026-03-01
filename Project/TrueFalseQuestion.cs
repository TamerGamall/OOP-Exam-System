using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    internal class TrueFalseQuestion : Question
    {
        
        public TrueFalseQuestion(string h, string b, double m, string a) :base(h, b,m,a)
        {
            
        }
        public override object ShowCorrectAnswer()
        {
            return Answer;
        }
        public override double CalcDegree()
        {
            if(UserAnswer.Trim().ToLower() == Answer.ToLower())
            {
                return Marks;
            }
            return 0;
        }
        public override void Show()
        {
            Console.WriteLine(Header);
            Console.WriteLine(Body);
            Console.WriteLine("1) True");
            Console.WriteLine("2) False");
        }
        public override void TakeAnswer()
        {
            Console.Write("Enter True or False: ");
            UserAnswer = Console.ReadLine();
        }
    }

}
