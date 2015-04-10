
using KuasCore.Dao.Base;
using KuasCore.Dao.Mapper;
using KuasCore.Models;
using Spring.Data.Common;
using Spring.Data.Generic;
using System.Collections.Generic;
using System.Data;

namespace KuasCore.Dao.Impl
{
    
    public class NewEmployeeDao : IEmployeeDao
    {

        public IList<Employee> GetAllEmployees()
        {
            List<Employee> employees = new List<Employee>();

            Employee employee1 = new Employee();
            employee1.Id = "1101137148";
            employee1.Name = "許祐彰";
            employee1.Age = 20;
            employees.Add(employee1);

            Employee employee2 = new Employee();
            employee2.Id = "KUAS";
            employee2.Name = "高雄應用科技大學";
            employee2.Age = 50;
            employees.Add(employee2);

            return employees;
        }

        public Employee GetEmployeeById(string id)
        {
            Employee employee = new Employee();
            employee.Id = "1101137148";
            employee.Name = "許祐彰";
            employee.Age = 20;

            return employee;
        }

    }
}
