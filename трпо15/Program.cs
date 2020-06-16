using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace трпо15
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();
            try
            {
                people.Add(new Person("Adam", 19));
                people.Add(new Person("Marry", 23));
                people.Add(new Person("Daniel", 25));
                people.Add(new Person("Edward", 18));
                people.Add(new Person("Meredyt", 155));
                foreach (Person peop in people)
                {
                    Console.WriteLine(peop.ToString());               
                }
            }
            catch (AgeOverSizeException ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
                Console.WriteLine($"Некорректное значение: {ex.Value}");
            }
            Console.ReadKey();
        }
    }
}
