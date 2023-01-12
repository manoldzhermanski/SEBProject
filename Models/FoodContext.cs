using System.Data.Entity;

namespace SEBProject.Models
{
    public class FoodContext : DbContext
    {
        public FoodContext() : base("Foodie")
        {
        }

        public DbSet<Food> Foods { get; set; }
    }
}