using System;

namespace HomeWork6
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isContinue = true;
            do
            {
                string[] firstNames = new string[] {"Joel" , "Nicko", "Selwyn"};
                Console.WriteLine("Type \"exit\" to end the program");
                Console.Write("Select a number between 1-3: ");
                string numberText = Console.ReadLine();

                if (numberText.ToLower() == "exit")
                {
                    break;
                }

                bool isValidText = int.TryParse(numberText, out int number);
               
                if (!isValidText)
                {
                    Console.WriteLine("\"Please input a valid number\"");
                    
                }
                else
                {
                    if (number == 1)
                    {
                        Console.WriteLine($"You choose number {number}, the name is {firstNames[0]}");
                    }
                    else if (number == 2)
                    {
                        Console.WriteLine($"You choose number {number}, the name is {firstNames[1]}");
                    }
                    else if (number == 3)
                    {
                        Console.WriteLine($"You choose number {number}, the name is {firstNames[2]}");
                    }
                    else
                    {
                        Console.WriteLine("\"The number you choose is out of bounds\"");
                    }
                }
            } while (isContinue);
        }
    }
}
