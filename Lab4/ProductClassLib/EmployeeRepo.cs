using System;
using System.Collections.Generic;
using System.Linq;

namespace ProductClassLib
{
    public class EmployeeRepo
    {
        protected readonly ApplicationContext Context;

        public EmployeeRepo()
        {
            this.Context = new ApplicationContext();
        }

        public void Create(Employee employee)
        {
            Context.Employees.Add(employee);
            Context.SaveChanges();
        }

        public void Delete(Employee employee)
        {
            Context.Employees.Remove(employee);
            Context.SaveChanges();
        }

        public ICollection<Employee> GetAll()
        {
            return Context.Employees.ToList();
        }

        public void Update(Employee employee)
        {
            var currentEmployee = Context.Employees.First(p => p.Id == employee.Id);
            Context.Employees.Update(currentEmployee);
            Context.SaveChanges();
        }

        Employee GetById(Guid id)
        {
            return Context.Employees.First(p => p.Id == id);
        }

        public ICollection<Employee> GetEmployeesBySalary(double salary)
        {
            return Context.Employees.Where(p => p.Salary == salary).ToList();
        }
    }
}
