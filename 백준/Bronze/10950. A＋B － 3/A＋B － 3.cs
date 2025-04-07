namespace 백준2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            for (int i = 0; i < count; i++)
            {
                string[] numbers = Console.ReadLine().Split();
                int num1 = int.Parse(numbers[0]);
                int num2 = int.Parse(numbers[1]);
                Console.WriteLine(num1 + num2);
            }
        }
    }
}
