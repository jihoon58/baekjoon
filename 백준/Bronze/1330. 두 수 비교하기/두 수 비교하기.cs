namespace baekjuntest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            if (array[0] < array[1])
            {
                Console.WriteLine("<");
            }
            else if (array[0] > array[1])
            {
                Console.WriteLine(">");
            }
            else
            {
                Console.WriteLine("==");
            }
        }
    }
}
