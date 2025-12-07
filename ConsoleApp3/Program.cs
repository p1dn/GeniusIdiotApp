using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> tasks = new Dictionary<string, int>()
            {
                {"Сколько будет два плюс два умноженное на два?", 6},
                {"Бревно нужно распилить на 10 частей. Сколько распилов нужно сделать?", 9},
                {"На двух руках 10 пальцев. Сколько пальцев на 5 руках?", 25},
                {"Укол делают каждые полчаса. Сколько нужно минут, чтобы сделать три укола?", 60},
                {"Пять свечей горело, две потухли. Сколько свечей осталось?", 2}
            };

            int countOfRightAnswers = 0;
            int numberOfTask = 1;

            foreach (var task in tasks)
            {
                Console.WriteLine($"Вопрос #{numberOfTask++}");
                Console.WriteLine(task.Key);

                int usersAnswer = int.Parse(Console.ReadLine());
                if (usersAnswer == task.Value) countOfRightAnswers++;
            }
        }
    }
}
