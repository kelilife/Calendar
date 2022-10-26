using System;

namespace KeLi.Calendar
{
    internal class Program
    {
        internal static void Main()
        {
            Console.Title = nameof(Calendar);
            Console.WindowWidth = 26;
            Console.WindowHeight = 29;
            Console.BufferWidth = 26;
            Console.BufferHeight = 29;

            try
            {
                CalendarBuilder.ShowCalendar();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadKey();
        }
    }
}