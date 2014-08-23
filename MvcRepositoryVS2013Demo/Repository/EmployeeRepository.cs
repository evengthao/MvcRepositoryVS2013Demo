using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MvcRepositoryVS2013Demo.Dal;

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
            throw new NotImplementedException();
        }

        public Models.Employee GetModelById(int id)
        {
            throw new NotImplementedException();
        }

        public void Insert(Models.Employee employee)
        {
            throw new NotImplementedException();
        }

        public void Delete(Models.Employee employee)
        {
            throw new NotImplementedException();
        }

        public void Update(int id)
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }
    }
}