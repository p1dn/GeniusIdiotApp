using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    public static class ConsoleView
    {
        public static void ShowUserList(List<User> Users)
        {
            Console.WriteLine("Ура! Вы прошли тест, теперь вы можете посмотреть таблицу с результатами других людей:");

            Console.WriteLine($"{"Имя",-12} {"Ответы",-12} {"Диагноз",-12}");
            foreach (var user in Users)
            {
                Console.WriteLine($"{user.Name,-12} {user.CountOfRightAnswers,-12} {GetDiagnosis(user.CountOfRightAnswers),-12}");
            }
        }

        public static bool UserWantToQuit()
        {
            Console.WriteLine("Хотите пройти тест ещё раз ? да/нет");
            while (true)
            {
                string answer = Console.ReadLine().ToLower();
                if (answer == "нет") return true;
                else if (answer == "да") return false;
                else Console.WriteLine("Вы должны написать ('Да' или 'Нет')");
            }
        }

        public static string GetNameOfUser()
        {
            Console.Write("Введите ваше имя: ");
            string name = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(name)) return "Гость";
            else return name;
        }

        public static void ShowUserResult(User user, List<User> Users)
        {
            Console.WriteLine($"Количество правильных ответов: {user.CountOfRightAnswers}");
            Console.WriteLine($"{user.Name}, вот ваш диагноз: {GetDiagnosis(user.CountOfRightAnswers)}");
            Users.Add(user);
        }

        public static int VerifiedUserAnswer()
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

        public static string GetDiagnosis(int countOfRightAnswers)
        {
            switch (countOfRightAnswers)
            {
                case 0: return ("Идиот");
                case 1: return ("Кретин");
                case 2: return ("Дурак");
                case 3: return ("Нормальный");
                case 4: return ("Талант");
                case 5: return ("Гений");
                default: return ("Эйнштейн");
            }
        }
    }
}
