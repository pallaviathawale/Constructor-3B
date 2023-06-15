using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorsDemo
{
    internal class Constructor
    {
        public string Name { get; set; }
        public int Age { get; set; }

        //   // Default Constructor
        public Constructor()
        {
            Name = "Gnaga";
            Age = 25;
        }
    


    // Parameterized constructor
    public Constructor(string name, int age)
        {
            Name = name;
            Age = age;

        }

        public void Display()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}");

        }
    }
    
}
