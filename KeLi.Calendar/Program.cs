﻿using System;

namespace KeLi.Calendar
{
    public class Program
    {
        public static void Main()
        {
            Console.Title = "Calendar";
            Console.WindowWidth = 26;
            Console.WindowHeight = 29;
            Console.BufferWidth = 26;
            Console.BufferHeight = 29;

            try
            {
                CalendarHelper.ShowCalendar();
            }

            catch (Exception ex)
            {
                Console.WriteLine("Error: {0}", ex.Message);
            }

            Console.ReadKey();
        }
    }
}