namespace Tic_Tac_Toe
{
    struct Clock {
        public int Hours;
        public int Minutes;

        public Clock(int h, int m)
        {
            Hours = h;
            Minutes = m;
        }

        public static Clock operator ++(Clock clock)
        {
            int minutes = clock.Minutes + 1;
            int hours = clock.Hours;
            if (minutes == 60)
            {
                hours++;
                minutes = 0;
            }
            return new Clock(hours, minutes);
        }

        public void operator +=(int min)
        {
            int minutes = this.Minutes + min;
            int hours = this.Hours;
            if (minutes == 60)
            {
                hours++;
                minutes = 0;
            }

            this.Minutes = minutes;
            this.Hours = hours;
            //return new Clock(hours, minutes);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Clock c = new Clock(6, 59);
            Console.WriteLine("Clock: " + $"{c.Hours}" + ":" + $"{c.Minutes}");
            c++;
            Console.WriteLine("Clock after ++: " + $"{c.Hours}" + ":" + $"{c.Minutes}");
            c += 20;
            Console.WriteLine("Clock after +=20: " + $"{c.Hours}" + ":" + $"{c.Minutes}");

        }
    }
}
