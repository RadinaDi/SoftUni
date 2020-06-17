using System;
using System.Collections.Generic;
using System.Linq;

namespace ListOfPersons
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> persons = new List<Person>();
            string input = string.Empty;
            do
            {
                input = Console.ReadLine();

                if(input.ToLower() != "end")
                {
                    string[] personData = input.Split();

                    Person person = new Person()
                    {
                        FirstName = personData[0],
                        LastName = personData[1],
                    };

                    persons.Add(person);
                }

            } while (input.ToLower() != "end");

            foreach(Person item in persons.OrderBy(x => x.LastName))
            {
                Console.WriteLine($"{item.LastName.ToUpper()} {item.FirstName}");
            }
            
        }
    }
}
