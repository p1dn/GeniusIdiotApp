using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace ConsoleApp3
{
    public class UserManager
    {
        private List<User> Users = new List<User>();

        private string path = Path.Combine(
            Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
            "ConsoleApp3",
            "users.json"
        );

        public void Save()
        {
            Directory.CreateDirectory(Path.GetDirectoryName(path));
            string json = JsonSerializer.Serialize(Users, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(path, json);
        }

        public void Load()
        {
            if (!File.Exists(path)) return;

            string json = File.ReadAllText(path);
            Users = JsonSerializer.Deserialize<List<User>>(json) ?? new List<User>();
        }

        public void ShowUserList()
        {
            Console.WriteLine("Ура! Вы прошли тест, теперь вы можете посмотреть таблицу с результатами других людей:");

            Console.WriteLine($"{"Имя",-12} {"Ответы",-12} {"Диагноз",-12}");
            foreach (var user in Users)
            {
                Console.WriteLine($"{user.Name,-12} {user.CountOfRightAnswers,-12} {user.GetAnswer(),-12}");
            }
        }

        public bool UserWantToQuit()
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

        public string GetNameOfUser()
        {
            Console.Write("Введите ваше имя: ");
            string name = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(name)) return "Гость";
            else return name;
        }

        public void ShowUserResult(User user)
        {
            Console.WriteLine($"Количество правильных ответов: {user.CountOfRightAnswers}");
            Console.WriteLine($"{user.Name}, вот ваш диагноз: {user.GetAnswer()}");
            Users.Add(user);
        }
    }
}
