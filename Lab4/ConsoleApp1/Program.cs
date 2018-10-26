using ProductClassLib;
using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var customerRepository = new CustomerRepo();

            var employee = new Employee("John", "Doe", DateTime.Now, null, 2500);
            var employeeRepository = new EmployeeRepo();


            employeeRepository.Create(employee);
        }
    }
}
