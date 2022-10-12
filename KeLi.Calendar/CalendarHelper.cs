using System;
using System.Threading;

using static System.DateTime;

namespace KeLi.Calendar
{
    public class CalendarHelper
    {
        private static int year;

        private static int month;

        private static int height;

        public static void ShowCalendar()
        {
            ShowCurrentMonth(true);

            SearchAnyMonth();

            Thread.Sleep(3000);

            for (var i = 0; i < 100000; i++)
            {
                Console.Clear();

                ShowCurrentMonth();

                Console.WriteLine();

                ShowAnyMonth();

                var seek = new Random((int)(Now.Ticks & 0xffffffffL) | (int)(Now.Ticks >> 32)).Next(10) * 100;

                Thread.Sleep(seek);
            }
        }

        private static void SearchAnyMonth()
        {
            while (true)
            {
                Console.SetCursorPosition(0, CalendarUtil.ComputeCurrentMonthLine());

                Console.Write("Inputs Year[1-9999]: ");

                year = Convert.ToInt32(Console.ReadLine());

                if (year > 0 && year < 9999)
                    break;
            }

            while (true)
            {
                Console.SetCursorPosition(0, CalendarUtil.ComputeCurrentMonthLine() + 1);

                Console.Write("Inputs Month[1-12]: ");

                month = Convert.ToInt32(Console.ReadLine());

                if (month > 0 && month < 13)
                    break;
            }

            Console.WriteLine();

            height = CalendarUtil.ComputeCurrentMonthLine() + CalendarUtil.ComputeAnyMonthLine(year, month) + 2;

            // Updates console's window height.
            Console.WindowHeight = height;

            // Updates console's buffer height.
            Console.BufferHeight = height;

            CalendarUtil.ShowAnyMonth(year, month, true);
        }

        private static void ShowCurrentMonth(bool flag = false)
        {
            CalendarUtil.ShowCurrentMonth(flag);
        }

        private static void ShowAnyMonth()
        {
            CalendarUtil.ShowAnyMonth(year, month, false, height);
        }
    }
}