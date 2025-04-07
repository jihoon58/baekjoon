namespace baekjuntest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[] time_HM = int.Parse(Console.ReadLine().Split());
            //int time_hour = int.Parse(time_HM[0]);
            //int time_minute = int.Parse(time_HM[1]);
            string[] time_HM = Console.ReadLine().Split();
            int time_hour = int.Parse(time_HM[0]);
            int time_minute = int.Parse(time_HM[1]);



            time_minute -= 45;
            if (time_minute < 0)
            {
                time_hour -= 1;
                time_minute = 60 + time_minute;
            }
            if (time_hour == -1)
            {
                time_hour = 23;
            }
            Console.WriteLine(time_hour+" "+time_minute);
        }
    }
}
