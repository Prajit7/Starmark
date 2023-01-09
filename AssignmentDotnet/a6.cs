using SampleConApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleConApp
{
    class a6DateValid
    {
        static void Main(string[] args)
        {
            int year = Utilities.GetNumber("Enter the year");
            int month = Utilities.GetNumber("Enter the month");
            int day = Utilities.GetNumber("Enter the day");
            if (isValidDate(year, month, day))
            {
                Console.WriteLine("Valid");
            }
            else Console.WriteLine("Invalid");


        }
        static bool checkLeap(int year)
        {
            return ((year % 4 == 0) && (year % 400 == 0));
        }
        static bool isValidDate(int year, int month, int day)
        {
            if (month > 12 || month < 0 || day < 0 || day > 31) return false;

            if (month == 2)
            {
                if (checkLeap(year))
                {
                    return (day <= 29);
                }
                else return (day <= 28);
            }
            if (month == 4 || month == 6 || month == 9 || month == 11) return (day <= 30);

            return true;


        }
    }
}
