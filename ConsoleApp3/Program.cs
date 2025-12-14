using System.Xml.Linq;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            UserManager userManager = new UserManager();
            userManager.Load();

            while (true)
            {
                User user = new User();
                user.Name = userManager.GetNameOfUser();
                user.CountOfRightAnswers = QuestionRepository.GetTestResult();

                userManager.ShowUserResult(user);

                if (userManager.UserWantToQuit()) break;
            }

            userManager.ShowUserList();
            userManager.Save();
        }
    }
}
