using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProject
{
    internal class Manager : Employee
    {
        public Manager(string firstName, string lastName, int age, string email, int companyID, double hourlyRate, DateTime birthday) : base(firstName, lastName, age, email, companyID, hourlyRate, birthday)
        {
        }

        public void AttendOnMeetings()
        {
            Console.WriteLine("Manager is attending meeting, and is ready to speak.");
            numberOfHoursWorked += 10;
        }
    }
}
