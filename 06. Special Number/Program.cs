using System;

namespace _06._Special_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int startNumber = number;
            
            bool isSpecial = true;

            while (number > 0)
            {
                int lastDigits = number % 10;
                if (startNumber % lastDigits != 0)
                {
                    isSpecial = false;
                    break;
                }
                number = number / 10;
            }
            if (isSpecial == true)
            {
                Console.WriteLine($"{startNumber} is special");
            }
            else
            {
                Console.WriteLine($"{startNumber} is not special");
            }
           
        }
    }
}
