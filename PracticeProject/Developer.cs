using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProject
{
    internal class Developer : Employee
    {
        public Developer(string firstName, string lastName, int age, string email, int companyID, double hourlyRate, DateTime birthday) : base(firstName, lastName, age, email, companyID, hourlyRate, birthday)
        {
            
        }
    }
}
