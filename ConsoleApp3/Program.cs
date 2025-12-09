using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> tasks = GetQuestions();

            Console.Write("Введите ваше имя: ");
            string name = Console.ReadLine();
            string usersAnswer = null;

            while (true)
            {
                Random rnd = new Random();
                int countOfRightAnswers = 0;
                int numberOfTask = 1;

                foreach (var task in tasks.OrderBy(t => rnd.Next()))
                {
                    Console.WriteLine($"Вопрос #{numberOfTask++}");
                    Console.WriteLine(task.Key);

                    while (true)
                    {
                        usersAnswer = Console.ReadLine();
                        if (usersAnswer.All(char.IsDigit)) break;
                        else Console.WriteLine("Введите число - '123'");
                    }

                    if (Convert.ToInt32(usersAnswer) == task.Value) countOfRightAnswers++;
                }

                GetAnswer(name, countOfRightAnswers);

                if (UserWantToQuit()) break;
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
