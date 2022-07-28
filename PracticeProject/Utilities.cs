using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProject
{
    internal class Utilities
    {
        internal static void CalculateAnnualWage(double hourlyWage, double numberOfWorkHours)
        {
            Console.WriteLine($"The employee's annual wage is {hourlyWage * numberOfWorkHours * 52:C}");
            Console.WriteLine($"The employee's montly wage is {hourlyWage * numberOfWorkHours * 52 / 12:C}");
        }
    }
}
