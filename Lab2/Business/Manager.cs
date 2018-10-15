﻿using System;

namespace NET
{
    public class Manager : Employee
    {
        public Manager(Guid id, string firstName, string lastName, DateTime startDate, DateTime endDate, double salary)
        : base(id, firstName, lastName, startDate, endDate, salary)
        {
        }

        public override string Salutation()
        {
            return "Hello" + "Manager";
        }
    }
}
