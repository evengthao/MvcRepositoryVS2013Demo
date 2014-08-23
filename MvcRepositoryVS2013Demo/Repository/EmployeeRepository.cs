using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using MvcRepositoryVS2013Demo.Dal;
using MvcRepositoryVS2013Demo.Models;

namespace MvcRepositoryVS2013Demo.Repository
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private MvcRepositoryVs2013DemoContext _mvcDemoContext;

        public EmployeeRepository(MvcRepositoryVs2013DemoContext mvcDemoContext)
        {
            _mvcDemoContext = mvcDemoContext;
        }

        public IEnumerable<Models.Employee> GetEmployees()
        {
            return _mvcDemoContext.Employees.ToList();
        }

        public Models.Employee GetModelById(int? id)
        {
            return _mvcDemoContext.Employees.Find(id);
        }

        public void Insert(Models.Employee employee)
        {
            _mvcDemoContext.Employees.Add(employee);
        }

        public void Delete(int id)
        {
            Employee employee = _mvcDemoContext.Employees.Find(id);
            _mvcDemoContext.Employees.Remove(employee);
        }

        public void Update(Employee employee)
        {
            _mvcDemoContext.Entry(employee).State = EntityState.Modified;
        }

        public void Save()
        {
            _mvcDemoContext.SaveChanges();
        }
    }
}