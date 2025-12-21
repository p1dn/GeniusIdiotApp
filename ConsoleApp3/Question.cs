using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    public partial class Question
    {
        public string Problem { get; set; }
        public int CorrectAnswer { get; set; }

        public Question() { }
        public Question(string problem, int correctAnswer)
        {
            Problem = problem;
            CorrectAnswer = correctAnswer;
        }
    }
}
