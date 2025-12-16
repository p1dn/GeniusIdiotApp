using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    public static class TestManager
    {
        private static Random rnd = new Random();

        public static int GetTestResult()
        {
            int numberOfTask = 1;
            int counter = 0;

            foreach (var question in QuestionRepository.Questions.OrderBy(t => rnd.Next()))
            {
                ConsoleView.ShowQuestion(question.Problem, numberOfTask);

                if (ConsoleView.VerifiedUserAnswer() == question.CorrectAnswer) counter++;
            }

            return counter;
        }
    }
}
