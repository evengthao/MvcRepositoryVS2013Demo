using System.Data.Entity;

namespace MvcRepositoryVS2013Demo.Dal
{
    public class MvcRepositoryVs2013DemoContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public MvcRepositoryVs2013DemoContext() : base("name=MvcRepositoryVS2013DemoContext")
        {
        }

        public System.Data.Entity.DbSet<MvcRepositoryVS2013Demo.Models.Employee> Employees { get; set; }
    
    }
}
