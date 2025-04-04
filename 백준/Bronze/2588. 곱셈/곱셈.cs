namespace baekjun
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int A = int.Parse(Console.ReadLine());
            int B = int.Parse(Console.ReadLine());
            int first = B / 100;
            int second = (B / 10) % 10;
            int third = B % 10;
            Console.WriteLine(A * third);
            Console.WriteLine(A * second);
            Console.WriteLine(A * first);
            Console.WriteLine(A*B);

        }
    }
}
