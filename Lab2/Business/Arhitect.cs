using System;

namespace NET
{
    public class Arhitect : Employee
    {
        public Arhitect(Guid id, string firstName, string lastName, DateTime startDate, DateTime endDate, double salary)
        : base(id, firstName, lastName, startDate, endDate, salary)
        {
        }

        public override string Salutation()
        {
            return "Hello" + "Arhitect";
        }
    }
}
