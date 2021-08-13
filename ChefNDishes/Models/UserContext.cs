using Microsoft.EntityFrameworkCore;

namespace ChefNDishes.Models
{
    public class ChefNDishesContext : DbContext
    {
    public ChefNDishesContext(DbContextOptions options) : base(options) { }

    public DbSet<User> Users { get; set; }
    public DbSet<Dish> Dishes { get; set; }
    }
}