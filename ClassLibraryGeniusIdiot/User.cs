using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraryGeniusIdiot
{
    public class User
    {
        public string Name { get; set; } = null;
        public int CountOfRightAnswers { get; set; } = 0;

        public User(string name)
        {
            Name = name;
        }
    }
}
