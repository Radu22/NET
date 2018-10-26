using System;
using System.ComponentModel.DataAnnotations;

namespace ProductClassLib
{
    public class Employee
    {
        private Employee()
        {

        }

        public Employee(string firstName, string lastName, DateTime startDate, DateTime? endDate, double salary)
        {
            Id = Guid.NewGuid();
            FirstName = firstName;
            LastName = lastName;
            StartDate = startDate;
            EndDate = endDate;
            Salary = salary;
        }

        public Guid Id { get; private set; }

        [Required]
        [StringLength(50)]
        public string FirstName { get; private set; }

        [Required]
        [StringLength(70)]
        public string LastName { get; private set; }

        [Required]
        public DateTime StartDate { get; private set; }

        public DateTime? EndDate { get; private set; }

        public double Salary { get; private set; }

        public bool IsActive()
        {
            return StartDate < DateTime.Now && EndDate > DateTime.Now;
        }
    }
}
