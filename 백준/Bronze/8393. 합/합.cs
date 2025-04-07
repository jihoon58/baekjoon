namespace 백준2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            long sum = 0;
            for (int i = 1; i < n+1; i++)
            {
                sum += i;
            }
            Console.WriteLine(sum);
        }
    }
}
