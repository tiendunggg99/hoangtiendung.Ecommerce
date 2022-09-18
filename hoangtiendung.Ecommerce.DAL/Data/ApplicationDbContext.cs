using hoangtiendung.Ecommerce.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace hoangtiendung.Ecommerce.DAL.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        DbSet<Category> Categories { get; set; }
        DbSet<Promotion> Promotion { get; set; }
        DbSet<Product> Products { get; set; }
        DbSet<OrderDetail> OrderDetails { get; set; }
        DbSet<Order> Orders { get; set; }
        DbSet<Photo> Photos { get; set; }
    }
}
