using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    internal class ChooseQuestion :Question
    {
        string[] choices = new string[4];
        public ChooseQuestion(string header, string body, double marks, string answer, string[] choices) : base(header, body, marks, answer)
        {
            this.choices = choices;
        }
        public override object ShowCorrectAnswer()
        {
            return Answer;
        }
        public override double CalcDegree()
        {
            if (UserAnswer == Answer)
            {
                return Marks;
            }
            return 0;
        }
        public override void Show()
        {
            Console.WriteLine(Header);
            Console.WriteLine(Body);
            for (int i = 0; i < choices.Length; i++)
            {
                Console.WriteLine($"{i}) {choices[i]}");
            }

        }
        public override void TakeAnswer()
        {
            Console.Write("Enter  : ");
            UserAnswer =Console.ReadLine();
        }
    }
}
