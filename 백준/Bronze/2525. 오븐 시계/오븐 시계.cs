namespace 백준2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] time_now = Console.ReadLine().Split();
            int time_hour = int.Parse(time_now[0]);
            int time_minute = int.Parse(time_now[1]);
            int cook_time = int.Parse(Console.ReadLine());

            time_minute += cook_time;
            if (time_minute >= 60)
            {
                time_hour += time_minute / 60;
                time_minute = time_minute % 60;
            }
            if (time_hour >= 24)
            {
                time_hour = time_hour % 24;
            }
            Console.WriteLine($"{time_hour} { time_minute}");
        }
    }
}
