using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    internal class Question
    {
        public string Problem { get; }
        public int CorrectAnswer { get; }

        public Question(string problem, int correctAnswer)
        {
            Problem = problem;
            CorrectAnswer = correctAnswer;
        }
    }
}
