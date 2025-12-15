using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    internal static class TestManager
    {
        private static Random rnd = new Random();

        public static int GetTestResult(QuestionRepository questionRepository)
        {
            int numberOfTask = 1;
            int counter = 0;

            foreach (var question in questionRepository.Questions.OrderBy(t => rnd.Next()))
            {
                Console.WriteLine($"Вопрос #{numberOfTask++}");
                Console.WriteLine(question.Problem);

                if (ConsoleView.VerifiedUserAnswer() == question.CorrectAnswer) counter++;
            }

            return counter;
        }
    }
}
