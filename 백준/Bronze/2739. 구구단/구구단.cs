namespace 백준2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            for (int i = 1; i < 10; i++)
            {
                Console.WriteLine($"{a} * {i} = {a*i}");
            }
        }
    }
}
