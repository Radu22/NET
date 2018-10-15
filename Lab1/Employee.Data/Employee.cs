using System;

namespace Employee.Data
{
    public abstract class Employee
    {
        public Employee(Guid id, string firstName, string lastName, DateTime startDate, DateTime endDate, double salary)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            StartDate = startDate;
            EndDate = endDate;
            Salary = salary;
        }

        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public double Salary { get; set; }

        public string GetFullName()
        {
            return FirstName + LastName;
        }

        public bool IsActive()
        {
            return StartDate < DateTime.Now && EndDate > DateTime.Now;
        }
    }
}
