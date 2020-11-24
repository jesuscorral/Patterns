using System;
using System.Linq;

namespace Dependecy.Injection
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var employeeBL = new EmployeeBL(new EmployeeDAL());
            employeeBL.GetAllEmployees().ToList().ForEach(x => {
                Console.WriteLine($"ID = {x.ID}, Name = {x.Name}, Department = {x.Department}");
            });
        }
    }
}
