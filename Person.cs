using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26
{
    internal class Person
    {
        int age;

        static int retirementAge = 60;

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public static int RetirementAge
        {
            get { return retirementAge; }
            set
            {
                if(value > 100)
                {
                    retirementAge = 100;
                }
                else if(value < 1)
                {
                    retirementAge = 1;
                }
                else
                {
                    retirementAge = value;
                }
            }
        }

        public Person() { }

        public Person(int age)
        {
            Age = age;
        }

        public void CheckAge()
        {
            if(Age >= retirementAge)
            {
                Console.WriteLine("Уже на пенсии");
            }
            else
            {
                Console.WriteLine($"До пенсии осталось {retirementAge - Age}");
            }
        }

        public static void CheckRetirementStatus(Person person)
        {
            if (person.Age >= retirementAge)
            {
                Console.WriteLine("Уже на пенсии");
            }
            else
            {
                Console.WriteLine($"До пенсии осталось {retirementAge - person.Age} года(лет)");
            }
        }

        public override string ToString()
        {
            return $"Возраст: {Age}";
        }
    }
}
