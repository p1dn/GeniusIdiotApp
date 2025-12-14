using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public static class QuestionRepository
    {
        private static Dictionary<string, int> GetQuestions()
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

        private static int VerifiedUserAnswer()
        {
            while (true)
            {
                try
                {
                    return Convert.ToInt32(Console.ReadLine());
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Слишком большое число");
                }
                catch
                {
                    Console.WriteLine("Введите число");
                }
            }
        }

        public static int GetTestResult()
        {
            Random rnd = new Random();
            int numberOfTask = 1;
            int counter = 0;

            foreach (var question in GetQuestions().OrderBy(t => rnd.Next()))
            {
                Console.WriteLine($"Вопрос #{numberOfTask++}");
                Console.WriteLine(question.Key);

                if (VerifiedUserAnswer() == question.Value) counter++;
            }

            return counter;
        }
    }
}
