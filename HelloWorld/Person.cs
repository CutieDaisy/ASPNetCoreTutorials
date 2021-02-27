using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelloWorld
{
    public class Person
    {
        public Person() { }

        public Person(int age, string name, string gender)
        {
            Age = age;
            Name = name;
            Gender = gender;
        }

        public int Age { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
    }
}
