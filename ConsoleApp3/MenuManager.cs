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
        }

        public static void RemoveQuestion()
        {
            ConsoleView.ShowAllQuestions();
            ConsoleView.AskQuestionIndex();
            QuestionRepository.Questions.RemoveAt(ConsoleView.VerifiedUserAnswer());
            ConsoleView.DeletedQuestion();
        }

        public static void StartTest(User user)
        {
            user.CountOfRightAnswers = TestManager.GetTestResult();
            ConsoleView.ShowUserResult(user);
            UserManager.Users.Add(user);
        }
    }
}
