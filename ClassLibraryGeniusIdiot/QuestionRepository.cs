using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace ConsoleApp3
{
    public class QuestionRepository
    {
        public static List<Question> Questions { get; set; } = new List<Question>();

        private string path = Path.Combine(
            Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
            "ConsoleApp3",
            "questions.json"
        );

        public void Save()
        {
            Directory.CreateDirectory(Path.GetDirectoryName(path));
            string json = JsonSerializer.Serialize(Questions, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(path, json);
        }

        public void Load()
        {
            if (!File.Exists(path))
            {
                Questions = GetDefaultQuestions();
                return;
            }

            string json = File.ReadAllText(path);
            Questions = JsonSerializer.Deserialize<List<Question>>(json) ?? new List<Question>();

            if (Questions == null || Questions.Count == 0) Questions = GetDefaultQuestions();
        }

        public static List<Question> GetDefaultQuestions()
        {
            return new List<Question>
            {
                new Question("Сколько будет два плюс два умноженное на два?", 6),
                new Question("Бревно нужно распилить на 10 частей. Сколько распилов нужно сделать?", 9),
                new Question("На двух руках 10 пальцев. Сколько пальцев на 5 руках?", 25),
                new Question("Укол делают каждые полчаса. Сколько нужно минут, чтобы сделать три укола?", 60),
                new Question("Пять свечей горело, две потухли. Сколько свечей осталось?", 2)
            };
        }
    }
}
