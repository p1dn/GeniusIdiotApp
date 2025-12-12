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
                string userAnswer = null;

                Console.Write("Введите ваше имя: ");
                user.Name = Console.ReadLine();

                Random rnd = new Random();
                int numberOfTask = 1;

                foreach (var task in tasks.OrderBy(t => rnd.Next()))
                {
                    Console.WriteLine($"Вопрос #{numberOfTask++}");
                    Console.WriteLine(task.Key);

                    if (VerifiedUserAnswer(userAnswer) == task.Value) user.CountOfRightAnswers++;
                }

                GetAnswer(user.Name, user.CountOfRightAnswers);
                userManager.AddUser(user);

                if (UserWantToQuit()) break;
            }

            Console.WriteLine("Ура! Вы прошли тест, теперь вы можете посмотреть таблицу с результатами других людей:");

            foreach (var u in userManager.Users)
            {
                Console.WriteLine($"{u.Name} | {u.CountOfRightAnswers}");
            }

            userManager.Save();
        }

        public static int VerifiedUserAnswer(string userAnswer)
        {
            while (true)
            {
                userAnswer = Console.ReadLine();

                if (userAnswer.All(char.IsDigit)) return Convert.ToInt32(userAnswer);
                else Console.WriteLine("Введите число - '123'");
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

        public static void GetAnswer(string name, int countOfRightAnswers)
        {
            Console.WriteLine($"Количество правильных ответов: {countOfRightAnswers}");
            Console.Write($"{name}, вот ваш диагноз: ");
            switch (countOfRightAnswers)
            {
                case 0: Console.WriteLine("Идиот"); break;
                case 1: Console.WriteLine("Кретин"); break;
                case 2: Console.WriteLine("Дурак"); break;
                case 3: Console.WriteLine("Нормальный"); break;
                case 4: Console.WriteLine("Талант"); break;
                case 5: Console.WriteLine("Гений"); break;
                default: Console.WriteLine("Эйнштейн"); break;
            }
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
