using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Lab_Work
{
    internal class Student
    {
        public int Age { get; set; }
        public string Name { get; set; }

        public Student(string name, int age)
        {
            this.Age = age;
            this.Name = name;
        }
    }
}
