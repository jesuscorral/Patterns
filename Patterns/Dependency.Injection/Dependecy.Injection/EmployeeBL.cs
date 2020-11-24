using System.Collections.Generic;

namespace Dependecy.Injection
{
    public class EmployeeBL
    {
        public IEmployeeDAL employeeDal;

        public EmployeeBL(IEmployeeDAL employeeDal)
        {
            this.employeeDal = employeeDal;
        }
        public List<Employee> GetAllEmployees()
        {
            return this.employeeDal.SelectAllEmployees();
        }
    }
}
