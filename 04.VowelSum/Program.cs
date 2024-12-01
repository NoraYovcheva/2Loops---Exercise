namespace _04.VowelSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countChar = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = 1; i <= countChar; i++)
            {
                char symbol = char.Parse(Console.ReadLine());

                //switch (symbol)
                //{
                //    case 'a':
                //        sum += 1;
                //        break;
                //    case 'e':
                //        sum += 2;
                //        break;
                //    case 'i':
                //        sum += 3;
                //        break;
                //    case 'o':
                //        sum += 4;
                //        break;
                //    case 'u':
                //        sum += 5;
                //        break;

                //}

                if (symbol == 'a')
                {
                    sum += 1;
                }
                else if (symbol == 'e')
                {
                    sum += 2;
                }
                else if (symbol == 'i')
                {
                    sum += 3;
                }
                else if (symbol == 'o')
                {
                    sum += 4;
                }
                else if (symbol == 'u')
                {
                    sum += 5;
                }
            }
             Console.WriteLine(sum);
        }
    }
}
