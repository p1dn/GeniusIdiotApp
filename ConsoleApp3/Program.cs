using System.Xml.Linq;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> tasks = GetQuestions();
            UserManager userManager = new UserManager();
            userManager.Load();

            while (true)
            {
                User user = new User();

                Console.Write("Введите ваше имя: ");
                user.Name = Console.ReadLine();

                Random rnd = new Random();
                int numberOfTask = 1;

                foreach (var task in tasks.OrderBy(t => rnd.Next()))
                {
                    Console.WriteLine($"Вопрос #{numberOfTask++}");
                    Console.WriteLine(task.Key);

                    if (VerifiedUserAnswer() == task.Value) user.CountOfRightAnswers++;
                }

                Console.WriteLine($"Количество правильных ответов: {user.CountOfRightAnswers}");
                Console.WriteLine($"{user.Name}, вот ваш диагноз: {user.GetAnswer()}");
                userManager.AddUser(user);

                if (UserWantToQuit()) break;
            }

            Console.WriteLine("Ура! Вы прошли тест, теперь вы можете посмотреть таблицу с результатами других людей:");

            Console.WriteLine($"{"Имя",-12} {"Ответы",-12} {"Диагноз",-12}");
            foreach (var u in userManager.Users)
            {
                Console.WriteLine($"{u.Name,-12} {u.CountOfRightAnswers,-12} {u.GetAnswer(),-12}");
            }

            userManager.Save();
        }

        public static int VerifiedUserAnswer()
        {
            while (true)
            {
                try
                {
                    return Convert.ToInt32(Console.ReadLine());
                }
                catch(OverflowException)
                {
                    Console.WriteLine("Слишком большое число");
                }
                catch
                {
                    Console.WriteLine("Введите число");
                }
            }
        }

        public static bool UserWantToQuit()
        {
            Console.WriteLine("Хотите пройти тест ещё раз ? да/нет");
            while (true)
            {
                string answer = Console.ReadLine().ToLower();
                if (answer == "нет") return true;
                else if (answer == "да") break;
                else Console.WriteLine("Вы должны написать ('Да' или 'Нет')");
            }
            return false;
        }

        public static Dictionary<string, int> GetQuestions()
        {
            return new Dictionary<string, int>()
            {
                {"Сколько будет два плюс два умноженное на два?", 6},
                {"Бревно нужно распилить на 10 частей. Сколько распилов нужно сделать?", 9},
                {"На двух руках 10 пальцев. Сколько пальцев на 5 руках?", 25},
                {"Укол делают каждые полчаса. Сколько нужно минут, чтобы сделать три укола?", 60},
                {"Пять свечей горело, две потухли. Сколько свечей осталось?", 2}
            };
        }
    }
}
