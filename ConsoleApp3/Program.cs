using ClassLibraryGeniusIdiot;
using System.Xml.Linq;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            UserManager userManager = new UserManager();
            QuestionRepository questionRepository = new QuestionRepository();
            bool userDontWantToQuit = true;

            userManager.Load();
            questionRepository.Load();

            while (userDontWantToQuit)
            {
                User user = new User(ConsoleView.GetNameOfUser());

                ConsoleView.ShowMenu(user.Name);

                switch (ConsoleView.VerifiedUserAnswer())
                {
                    case 1: MenuManager.StartTest(user); break;
                    case 2: MenuManager.AddQuestion(); break;
                    case 3: MenuManager.RemoveQuestion(); break;
                    case 4: userDontWantToQuit = ConsoleView.UserWantToQuit(); break;
                    default: ConsoleView.DontHaveYourNumber(); break;
                }
            }

            userManager.Save();
            questionRepository.Save();
        }
    }
}
