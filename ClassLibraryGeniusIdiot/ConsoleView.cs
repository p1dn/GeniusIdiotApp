using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraryGeniusIdiot
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
            Console.WriteLine("Вы уверены что хотите выйти ? да/нет");
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

        public static void ShowUserResult(User user)
        {
            Console.WriteLine($"Количество правильных ответов: {user.CountOfRightAnswers}");
            Console.WriteLine($"{user.Name}, вот ваш диагноз: {GetDiagnosis(user.CountOfRightAnswers)}");
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

        public static void ShowMenu(string name)
        {
            Console.WriteLine($"Добро пожаловать {name}");
            Console.WriteLine("1. Пройти тест");
            Console.WriteLine("2. Добавить вопрос");
            Console.WriteLine("3. Удалить вопрос");
            Console.WriteLine("4. Выйти");

            Console.Write("Введите число: ");
        }

        public static void ShowQuestion(string problem, int numberOfTask)
        {
            Console.WriteLine($"Вопрос #{numberOfTask}");
            Console.WriteLine(problem);
        }

        public static void ShowAllQuestions(List<Question> questions)
        {
            for (int i = 0; i < questions.Count; i++)
            {
                Console.WriteLine($"{i + 1}. Вопрос: {questions[i].Problem} Ответ: {questions[i].CorrectAnswer}");
            }
        }

        public static int AskQuestionIndex(int questionsCount)
        {
            Console.Write("Введите номер вопроса, который хотите удалить: ");

            while (true)
            {
                int answer = VerifiedUserAnswer() - 1;
                if (answer < questionsCount && answer >= 0) return answer;
                else DontHaveYourNumber();
            }
        }
        
        public static void SuccessfullyCompleted() => Console.WriteLine("Успешно выполнено");
        public static void DontHaveYourNumber() => Console.WriteLine("Такого номера не существует");
        public static Question AddNewQuestion()
        {
            Question question = new Question();

            Console.WriteLine("Введите новый вопрос:");
            question.Problem = Console.ReadLine();

            Console.WriteLine("Введите ответ для нового вопроса:");
            question.CorrectAnswer = VerifiedUserAnswer();

            return question;
        }
    }
}
