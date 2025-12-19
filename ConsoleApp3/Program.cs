using System.Xml.Linq;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            UserManager.Load();
            QuestionRepository.Load();

            while (true)
            {
                User user = new User();
                user.Name = ConsoleView.GetNameOfUser();

                ConsoleView.ShowMenu(user.Name);

                switch (ConsoleView.VerifiedUserAnswer())
                {
                    case 1: MenuManager.StartTest(user); break;
                    case 2: MenuManager.AddQuestion(); break;
                    case 3: MenuManager.RemoveQuestion(); break;
                    default: ConsoleView.DontHaveYourNumber(); break;
                }

                if (ConsoleView.UserWantToQuit()) break;
            }

            ConsoleView.ShowUserList(UserManager.Users);
            UserManager.Save();
            QuestionRepository.Save();
        }
    }
}
