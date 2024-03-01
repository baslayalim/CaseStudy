using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudy.Training.DesignPatterns.Creational.Prototype
{
    class Employee : IClonablePrototype<Employee>
    {
        string firstName;
        string lastName;

        public Employee(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }

        public Employee Clone()
        {
            return base.MemberwiseClone() as Employee;
        }
    }
}
