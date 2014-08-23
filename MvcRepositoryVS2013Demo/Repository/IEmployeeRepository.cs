using System.Collections.Generic;
using MvcRepositoryVS2013Demo.Models;

namespace MvcRepositoryVS2013Demo.Repository
{
    public interface IEmployeeRepository
    {
        IEnumerable<Employee> GetEmployees();
        Employee GetModelById(int? id);
        void Insert(Employee employee);
        void Delete(int id);
        void Update(Employee employee);
        void Save();

    }
}
