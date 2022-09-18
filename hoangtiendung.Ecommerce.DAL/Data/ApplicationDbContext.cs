using hoangtiendung.Ecommerce.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace hoangtiendung.Ecommerce.DAL.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        DbSet<Category> Categories;
        DbSet<Promotion> Promotion;
        DbSet<Product> Products;
        DbSet<OrderDetail> OrderDetails;
        DbSet<Order> Orders;
        DbSet<Photo> Photos;
    }
}
