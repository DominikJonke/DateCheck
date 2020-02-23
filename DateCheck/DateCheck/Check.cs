using System;

namespace DateCheck
{
    public static class Check
    {
        private static string input;
        private static int day, month, year = 0;
        private static string ddmmyyyy;
        public static void ShowTitle()
        {
            Console.WriteLine("*******************************************************");
            Console.WriteLine("*                     Datecheck                       *");
            Console.WriteLine("*******************************************************");
            Console.WriteLine("");
            Console.WriteLine("");
        }
        public static void SetandCheckDate()
        {
            bool ok = false;

            do
            {
                Console.WriteLine("Enter the date:");
                Console.WriteLine("");

                Console.Write("Day: ");
                input = Console.ReadLine();
                day = Convert.ToInt32(input);

                Console.Write("Month: ");
                input = Console.ReadLine();
                month = Convert.ToInt32(input);

                Console.Write("Year: ");
                input = Console.ReadLine();
                year = Convert.ToInt32(input);

                if (year > 0)
                {
                    if (month > 0 && month <= 12)
                    {
                        if (day > 0 && day <= 31)
                        {
                            if (month == 2 && day <= 28)
                            {
                                ok = true;
                            }
                            else if (month == 1 || month == 3 || month == 5 || month == 7 ||
                                month == 8 || month == 10 || month == 12 && month <= 31)
                            {
                                ok = true;
                            }

                            else if (month == 4 || month == 6 || month == 9 || month == 11 && month <= 30)
                            {
                                ok = true;
                            }
                        }
                    }
                }

            } while (!ok);

            ddmmyyyy = $"{day}.{month}.{year}";
        }
        public static void LeapYear()
        {
            if(year % 4 == 0 || year % 400 == 0)
            {
                Console.WriteLine($"\n{ddmmyyyy} is a leap-year");
            }
            
            else
            {
                Console.WriteLine($"\n{ddmmyyyy} is not a leap-year");
            }
        }
    }
}
