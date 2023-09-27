using Fitness.Domain.Entities;
using Fitness.Domain.Entities.Carts;
using Microsoft.EntityFrameworkCore;
using Fitness.Domain.Entities.Orders;
using Fitness.Domain.Entities.Products;
using Fitness.Domain.Entities.Messages;
using Attachment = System.Net.Mail.Attachment;

namespace Fitness.DataAccess.Contexts;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    { }
    
    public DbSet<User> Users { get; set; }
    public DbSet<Plan> Plans { get; set; }
    public DbSet<Message> Messages { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<Teacher> Teachers { get; set; }
    public DbSet<Equepment> Equempents { get; set; }
    public DbSet<Attachment> Attachments { get; set; }
    public DbSet<CartProduct> CartProducts { get; set; }
    public DbSet<OrderProduct> OrderProducts { get; set; }
    public DbSet<CartEquepment> CartEquepments { get; set; }
    public DbSet<OrderEquepment> OrderEquepments { get; set; }
    public DbSet<ProductCategory> ProductCategories { get; set; }
    public DbSet<EquepmentCategory> EquepmentCategories { get; set; }
}