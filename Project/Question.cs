using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
   
    internal abstract class Question
    {
        public string Header { get; set; }
        public string Body { get; set; }
        public double Marks { get; set; }
        protected string Answer { get; set; }
        public string UserAnswer { get; set; }
 

        public Question(string header , string body , double marks, string answer)
        {
            Header = header;
            Body = body;
            Marks = marks;
            Answer = answer;
        }
        public abstract double CalcDegree();
        public abstract void Show();
        public abstract void TakeAnswer();
        public abstract object ShowCorrectAnswer();
    }
}
