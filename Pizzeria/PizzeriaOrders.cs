//Class responsible for creating Entity Framework Contexts for all pizzas in Database
using System.Data.Entity;

namespace Pizzeria
{
    class PizzeriaOrders : DbContext
    {
      
        public PizzeriaOrders() : base()
        {

        }
        public DbSet<Order> Orders { get; set; }
    }
}
