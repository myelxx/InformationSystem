using System;
using System.Linq;

namespace InformationSystem
{
    class Program
    {
    

        static void Main(string[] args)
        {

            //list
            Person[] people = new[] {
                new Person
                {
                    Id = 1,
                    Name = "Ethos",
                    Age = 19,
                    Gender = "m"
                },
                new Person
                {
                    Id = 2,
                    Name = "Alys",
                    Age = 25,
                    Gender = "f"
                },
                new Person
                {
                    Id = 3,
                    Name = "Zari",
                    Age = 11,
                    Gender = "f"
                }
            };

            Animal[] animals = new[] {
                new Animal
                {
                    Id = 1,
                    Name = "Dog",
                    Age = 19
                },
                new Animal
                {
                    Id = 2,
                    Name = "Cat",
                    Age = 25
                },
                new Animal
                {
                    Id = 3,
                    Name = "Pig",
                    Age = 11
                }
            };

            Person pc = new Person();
            Program program = new Program();


            while (true)
            {
                Console.WriteLine("Person o Animal?");
                string input = Console.ReadLine();
                input.ToLower();

                if (input.ToLower() != "person" && input.ToLower() != "animal")
                {
                    Console.WriteLine("Invalid");
                    Console.WriteLine("Do you want to enter again? (Y/N)");
                    string q = Console.ReadLine();
                    if (q.ToLower() == "y")
                    {
                        continue;
                    }
                    else
                    {
                        Environment.Exit(0);
                    }
                }

                Console.WriteLine("What do you want to do? \n" +
                    "*Get All <type a>  \n" +
                    "*Search <type s>  \n");
                string input2 = Console.ReadLine();
                input2.ToLower();

                if (input2 == "a")
                {
                    if(input is "person")
                    {
                        var queryGetAll = from person in people select person;

                        Console.WriteLine("List of person:");
                        foreach (var q in queryGetAll)
                        {
                            Console.WriteLine("Name: {0}, Age: {1}, Gender: {2}", q.Name, q.Age, q.Gender);
                        }
                    } 

                    if(input is "animal")
                    {
                        var queryGetAll = from animal in animals select animal;

                        Console.WriteLine("List of animal:");
                        foreach (var q in queryGetAll)
                        {
                            Console.WriteLine("Name: {0}, Age: {1},", q.Name, q.Age);
                        }
                    }

                }
                else if (input2 == "s")
                {
                    Console.WriteLine("Search by: ");
                    string input3 = Console.ReadLine();

                    if (input is "person")
                    {
                        var search = from p in people
                                     where p.Name == input3 || p.Gender == input3 || p.Age == Convert.ToInt32(input3)
                                     select p;

                        Console.WriteLine("List of person with the same value you entered: ", input3);
                        foreach (var sa in search)
                        {
                            Console.WriteLine("Name: {0}, Age: {1}, Gender: {2}", sa.Name, sa.Age, sa.Gender);
                        }
                    }

                    if (input is "animal")
                    {
                        var search = from a in animals
                                     where a.Name == input3 || a.Gender == input3 || p.Age == Convert.ToInt32(input3)
                                     select a;

                        Console.WriteLine("List of person with a of {0}:", input3);
                        foreach (var sa in search)
                        {
                            Console.WriteLine("Name: {0}, Age: {1}, Gender: {2}", sa.Name, sa.Age, sa.Gender);
                        }
                    }

                }
                else
                {
                    Console.WriteLine("Invalid");
                    Console.WriteLine("Do you want to enter again? (Y/N)");
                    string q = Console.ReadLine();
                    if (q.ToLower() == "y")
                    {
                        continue;
                    }
                    else
                    {
                        Environment.Exit(0);
                    }
                }

            }
        }

       
    }
}
