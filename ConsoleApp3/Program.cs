using System.Xml.Linq;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            QuestionRepository questionRepository = new QuestionRepository();
            UserManager userManager = new UserManager();
            userManager.Load();

            while (true)
            {
                User user = new User();
                user.Name = ConsoleView.GetNameOfUser();
                user.CountOfRightAnswers = TestManager.GetTestResult(questionRepository);

                ConsoleView.ShowUserResult(user, userManager.Users);

                if (ConsoleView.UserWantToQuit()) break;
            }

            ConsoleView.ShowUserList(userManager.Users);
            userManager.Save();
        }
    }
}
