using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    public static class MenuManager
    {

        public static void AddQuestion()
        {
            ConsoleView.ShowAllQuestions(QuestionRepository.Questions);
            QuestionRepository.Questions.Add(ConsoleView.AddNewQuestion());
            ConsoleView.SuccessfullyCompleted();
        }

        public static void RemoveQuestion()
        {
            ConsoleView.ShowAllQuestions(QuestionRepository.Questions);
            QuestionRepository.Questions.RemoveAt(ConsoleView.AskQuestionIndex(QuestionRepository.Questions.Count));
            ConsoleView.SuccessfullyCompleted();
        }

        public static void StartTest(User user)
        {
            Random rnd = new Random();
            user.CountOfRightAnswers = TestManager.GetTestResult(rnd, QuestionRepository.Questions);
            ConsoleView.ShowUserResult(user);
            UserManager.Users.Add(user);
            ConsoleView.ShowUserList(UserManager.Users);
        }
    }
}
