using System;
using System.IO;
using System.Linq;

namespace SeleniumPizza
{
    public class PersonalInfo
    {
        public PersonalInfo(string textFile)
        {
            string[] lines = File.ReadLines(textFile).ToArray();
            Name = lines[0];
            LastName = lines[1];
            Phone = lines[2];
            Email = lines[3];

        }

        public string Name { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }

    }
}
