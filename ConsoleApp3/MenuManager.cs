using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    public static class MenuManager
    {

        public static void AddQuestion()
        {
            ConsoleView.ShowAllQuestions();
            ConsoleView.AddNewQuestion();
        }

        public static void RemoveQuestion()
        {
            ConsoleView.ShowAllQuestions();
            ConsoleView.AskQuestionIndex();
        }

        public static void StartTest(User user)
        {
            user.CountOfRightAnswers = TestManager.GetTestResult();
            ConsoleView.ShowUserResult(user);
            UserManager.Users.Add(user);
        }
    }
}
