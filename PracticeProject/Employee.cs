using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProject
{
    internal class Employee
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public int age { get; set; }
        public string email { get; set; }
        public int companyID { get; set; }

        public int numberOfHoursWorked { get; set; }
        public double wage { get; set; }
        public double hourlyRate { get; set; }
        public DateTime birthday { get; set; }

        
        
        public void PerformWork(int numberOfHours)
        {
            if (numberOfHours == 0) numberOfHours = 1;
            numberOfHoursWorked += numberOfHours;
            Console.WriteLine($"{firstName} {lastName} has worked for {numberOfHoursWorked} hours.");          
        }

        public double ReceiveWage(bool resetHours = true)
        {
            wage = hourlyRate * numberOfHoursWorked;
            Console.WriteLine($"{firstName} {lastName} has received a wage of {wage} for {numberOfHoursWorked} hour(s) of work.");
            if (resetHours)
            {
                numberOfHoursWorked = 0;
            }
            return wage;
        }

        public void DisplayEmployeeDetails()
        {
            Console.WriteLine($"\nFir\nst nasme: \t{firstName}\nLast name: \t{lastName}\nEmail: \t\t{email}\nBirthday: \t{birthday.ToShortDateString()}\n");
        }

        public Employee(string firstName, string lastName, int age, string email, int companyID, double hourlyRate, DateTime birthday)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
            this.email = email;
            this.companyID = companyID;
            this.hourlyRate = hourlyRate;
            this.birthday = birthday;
        }
    }
}
