using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraryGeniusIdiot
{
    public static class TestManager
    {
        public static int GetTestResult(Random rnd, List<Question> questions)
        {
            int numberOfTask = 1;
            int counter = 0;

            foreach (var question in questions.OrderBy(t => rnd.Next()))
            {
                ConsoleView.ShowQuestion(question.Problem, numberOfTask);
                numberOfTask++;

                if (ConsoleView.VerifiedUserAnswer() == question.CorrectAnswer) counter++;
            }

            return counter;
        }
    }
}
