using System.Collections.Generic;

namespace Dependecy.Injection
{
    public interface IEmployeeDAL
    {
        List<Employee> SelectAllEmployees();
    }
}
