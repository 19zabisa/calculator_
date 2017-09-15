using System;

namespace Calculator_
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {

                Console.WriteLine("Welcome to my calculator!");
                Console.Write("Enter your first number or type 'quit' to exit: ");

                var entry1 = Console.ReadLine();

                if (entry1.ToLower() == "quit")
                {
                    break;
                }

                Console.WriteLine("Choose /,*,-, or +: ");
                var choice = Console.ReadLine();

                Console.WriteLine("Enter your second number: ");
                var entry2 = Console.ReadLine();

                try
                {
                    var firstEntry = double.Parse(entry1);
                    var secondEntry = double.Parse(entry2);

                    if (choice == "/")
                    {
                        Console.WriteLine(firstEntry / secondEntry);
                    }

                    else if (choice == "*")
                    {
                        Console.WriteLine(firstEntry * secondEntry);
                    }

                    else if (choice == "-")
                    {
                        Console.WriteLine(firstEntry - secondEntry);
                    }

                    else if (choice == "+")
                    {
                        Console.WriteLine(firstEntry + secondEntry);
                    }

                    else
                    {
                        Console.WriteLine("That is not a valid input");
                    }

                }

                catch (FormatException)
                {
                    Console.WriteLine("That is not a valid input");
                    continue;
                }



            }
        }
    }
}
