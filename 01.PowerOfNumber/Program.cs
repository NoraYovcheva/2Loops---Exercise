namespace _01.PowerOfNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int power = int.Parse(Console.ReadLine());

            //Console.WriteLine(Math.Pow(n, power));
            int result = 1;
            for (int time = 1; time <= power; time++)
            {
                result = result * n;
            }
            Console.WriteLine(result);
        }
    }
}
