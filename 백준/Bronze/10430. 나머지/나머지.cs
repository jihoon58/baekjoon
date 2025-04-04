namespace baekjun
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            double A = double.Parse(input[0]);
            double B = double.Parse(input[1]);
            double C = double.Parse(input[2]);
            Console.WriteLine((A + B) % C);
            Console.WriteLine(((A % C) + (B % C)) % C);
            Console.WriteLine((A * B) % C);
            Console.WriteLine(((A%C)*(B%C))%C);

        }
    }
}
