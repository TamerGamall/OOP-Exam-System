using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    internal abstract class Exam
    {
        protected int Time { get; set; }
        protected double Total { set; get; }
        protected int NumberOfQuestions { get; set; }

        protected List<Question> Questions;
        protected Subject subject;
        public Exam(int t , int n , Subject s)
        {
            Time = t;
            NumberOfQuestions = n;
            Questions = new List<Question>(n);
            subject = s;
        }
        public void AddQuestion(Question question)
        {
            Questions.Add(question);
        }
        protected abstract void ShowQuestions();
        protected abstract void TakeAnswers();
        protected abstract void ShowResult();
        public void StartExam()
        {
            ShowQuestions();
            TakeAnswers();
            ShowResult();
        }


    }
}
