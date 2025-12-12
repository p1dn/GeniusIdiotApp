using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace ConsoleApp3
{
    public class UserManager
    {
        public List<User> Users { get; set; } = new List<User>();

        public static string path = Path.Combine(
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

        public void AddUser(User user) => Users.Add(user);
    }
}
