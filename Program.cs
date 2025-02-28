using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person(90);
            Console.WriteLine(person1);
            person1.CheckAge();
            Console.WriteLine();

            Person person2 = new Person(18);
            Console.WriteLine(person2);
            Person.CheckRetirementStatus(person2);

            Console.ReadKey(true);
        }
    }
}
