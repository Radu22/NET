using System;

namespace Architect.Data
{
    public class Architect : Employee.Data.Employee
    {
        public Architect(Guid id, string firstName, string lastName, DateTime startDate, DateTime endDate, double salary) : base(id, firstName, lastName, startDate, endDate, salary)
        {

        }
    }
}
