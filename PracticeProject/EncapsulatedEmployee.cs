using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProject
{
    internal class EncapsulatedEmployee
    {
        public string firstName;
        private int age;
        private double wage;
        
        public double Wage
        {
            get
            {
                return wage;
            }
            private set
            {
                if (wage > 0) wage = value;
            }
        }

        public EncapsulatedEmployee(string firstName, int age)
        {
            this.firstName = firstName;
            this.age = age;
        }

        public int GetAge()
        {
            return age;
        }
        
        public void SetAge(int newAge)
        {
            this.age = newAge;
        }
    }
}
