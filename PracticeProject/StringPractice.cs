using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProject
{
    internal class StringPractice
    {
        internal static void ModifyString(string inputString)
        {
            Console.WriteLine(inputString.ToUpper());
            Console.WriteLine(inputString.ToLower());
            Console.WriteLine(inputString.Replace("a", "b"));
            Console.WriteLine(inputString.Length);
            Console.WriteLine(inputString.Substring(0, 4));
        }

        internal static void CreateUserName(string firstName, string lastName)
        {
            string userName = firstName.Substring(0, 1) + lastName;
            Console.WriteLine($"The user name is {userName}");
        }
    }
}
