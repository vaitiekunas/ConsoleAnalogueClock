using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAnalogueClock
{
    class Program
    {
        public static int Hours { get; set; }
        public static int Minutes { get; set; }
        public static int HoursDeg { get; set; }
        public static int MinutesDeg { get; set; }
        public static int AngleDiff { get; set; }
        public static int LesserAngle { get; set; }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello. This app calculates lesser angle in degrees between the analogue clock hours arrow and minutes arrow");

            GetHours();

            GetMinutes();

            ConvertToDeg();

            CalcLesserAngle();

            Console.WriteLine($"\nLesser angle is {LesserAngle} degrees");

            Console.ReadLine();
        }

        private static void GetHours()
        {
            Console.WriteLine("\nPlease enter number of hours (whole number 1-12)");

            int hours;

            while (!int.TryParse(Console.ReadLine(), out hours) || hours < 1 || hours > 12)
            {
                Console.WriteLine("Wrong hours number. It must be the whole number 1-12");
            }

            Console.WriteLine($"{hours} is correct hours number");

            Hours = hours;
        }

        private static void GetMinutes()
        {
            Console.WriteLine("\nPlease enter number of minutes (whole number 0-59)");

            int minutes;

            while (!int.TryParse(Console.ReadLine(), out minutes) || minutes < 0 || minutes > 59)
            {
                Console.WriteLine("Wrong minutes number. It must be the whole number 0-59");
            }

            Console.WriteLine($"{minutes} is correct minutes number");

            Minutes = minutes;
        }

        private static void ConvertToDeg()
        {
            if (Hours == 12)
            {
                int hDeg = Minutes / 2;

                HoursDeg = hDeg;
            }
            else
            {
                int hDeg = Hours * 30 + Minutes / 2;

                HoursDeg = hDeg;
            }

            int mDeg = Minutes * 6;

            MinutesDeg = mDeg;
        }

        private static void CalcLesserAngle()
        {
            if (HoursDeg > MinutesDeg)
            {
                AngleDiff = HoursDeg - MinutesDeg;
            }
            else
            {
                AngleDiff = MinutesDeg - HoursDeg;
            }

            if (AngleDiff < 180)
            {
                int lesserAngle = AngleDiff;

                LesserAngle = lesserAngle;
            }
            else
            {
                int lesserAngle = 360 - AngleDiff;

                LesserAngle = lesserAngle;
            }
        }
    }
}
