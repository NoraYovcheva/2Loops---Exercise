namespace _07._Special_Bonus
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int stopNumber = int.Parse(Console.ReadLine());
            double prevNumber = 0.0;

            while (true)
            {
                double number = int.Parse(Console.ReadLine());
              
                if (number == stopNumber)
                {
                    prevNumber = prevNumber + prevNumber * 0.20;
                    Console.WriteLine(prevNumber);
                    break;
                }
                prevNumber = number;

            }
                
        }
    }
}
