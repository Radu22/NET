using System;

namespace Manager.Data
{
    public class Manager : Employee.Data.Employee
    {
        public Manager(Guid id, string firstName, string lastName, DateTime startDate, DateTime endDate, double salary) : base(id, firstName, lastName, startDate, endDate, salary)
        {

        }
    }
}
