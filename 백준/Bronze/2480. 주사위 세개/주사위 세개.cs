namespace 백준2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] numbers = Console.ReadLine().Split();
            int first = int.Parse(numbers[0]);
            int second = int.Parse(numbers[1]);
            int third = int.Parse(numbers[2]);

            if (first == second && first == third)
            {
                Console.WriteLine(10000+first*1000);
            }
            else if (first == second || first == third)
            {
                Console.WriteLine(1000+first*100);
            }
            else if (second == third)
            {
                Console.WriteLine(1000 + second * 100);
            }
            else //다 다름
            {
              if (first > second && first > third)
                {
                    Console.WriteLine(first * 100);
                }
                else if (second > first && second > third)
                {
                    Console.WriteLine(second * 100);
                }
                else
                {
                    Console.WriteLine(third * 100);
                }
            }
        }
    }
}
