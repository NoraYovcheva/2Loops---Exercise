namespace _08._Account_Balance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double accountBalans = 0;
           
            string input = Console.ReadLine();

            while (input != "End")
            {
                double money = double.Parse(input);
                if (money >= 0)
                {
                    accountBalans += money;
                    Console.WriteLine($"Increase: {money:f2}");
                }
                else
                { 
                    accountBalans -= Math.Abs(money);
                    Console.WriteLine($"Decrease: {Math.Abs(money):f2}");
                }
                input = Console.ReadLine();
            }
            
            Console.WriteLine($"Balance: {accountBalans:f2}");
        }
    }
}
