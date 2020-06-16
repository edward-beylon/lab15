using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace трпо15
{
    class Person
    {
        public string Name { get; set; }
        int age;
        public int Age
        {
            get { return age; }
            set
            {
                if ((value < 18) || (value > 100))
                    throw new AgeOverSizeException("Ошибочное значение возраста", value);
                else
                    age = value;
            }
        }
        public Person(string n, int a)
        {
            Name = n;
            Age = a;
        }
        public override string ToString()
        {
            return "Name: " + Name + ", age: " + Age;
        }
    }
}
