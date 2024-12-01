namespace _03.BiggestNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countN = int.Parse(Console.ReadLine());
            int maxNuber = int.MinValue;
            for (int i = 1; i <= countN; i++)
            {
                int number = int.Parse(Console.ReadLine());

                if (number > maxNuber)
                {
                    maxNuber = number;
                }
            }
            Console.WriteLine(maxNuber);
        }
    }
}
