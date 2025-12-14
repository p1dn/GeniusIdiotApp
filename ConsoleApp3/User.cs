using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    public class User
    {
        public string Name { get; set; } = null;
        public int CountOfRightAnswers { get; set; } = 0;

        public string GetAnswer()
        {
            switch (CountOfRightAnswers)
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
