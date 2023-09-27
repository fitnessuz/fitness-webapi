using Fitness.DataAccess.Contexts;
using Fitness.DataAccess.Repositories;
using Fitness.Domain.Entities;
using Fitness.Domain.Entities.Carts;
using Fitness.Domain.Entities.Messages;
using Fitness.Domain.Entities.Orders;
using Fitness.Domain.Entities.Products;

namespace Fitness.DataAccess.UnitOfWork;

public class UnitOfWork : IUnitOfWork
{
    private readonly AppDbContext dbContext;

    public UnitOfWork(AppDbContext dbContext)
    {
        this.dbContext = dbContext;
        UserRepository = new Repository<User>(dbContext);
        PlanRepository = new Repository<Plan>(dbContext);
        ProductRepository = new Repository<Product>(dbContext);
        TeacherRepository = new Repository<Teacher>(dbContext);
        MessageRepository = new Repository<Message>(dbContext);
        EquempentRepository = new Repository<Equepment>(dbContext);
        AttachmentRepository = new Repository<Attachment>(dbContext);
        CartProductRepository = new Repository<CartProduct>(dbContext);
        OrderProductRepository = new Repository<OrderProduct>(dbContext);
        CartEquepmentRepository = new Repository<CartEquepment>(dbContext);
        OrderEquepmentRepository = new Repository<OrderEquepment>(dbContext);
        ProductCategoryRepository = new Repository<ProductCategory>(dbContext);
        EquepmentCategoryRepository = new Repository<EquepmentCategory>(dbContext);
    }

    public IRepository<User> UserRepository { get; }
    public IRepository<Plan> PlanRepository { get; }
    public IRepository<Product> ProductRepository { get; }
    public IRepository<Teacher> TeacherRepository { get; }
    public IRepository<Message> MessageRepository { get; }
    public IRepository<Equepment> EquempentRepository { get; }
    public IRepository<Attachment> AttachmentRepository { get; }
    public IRepository<CartProduct> CartProductRepository { get; }
    public IRepository<OrderProduct> OrderProductRepository { get; }
    public IRepository<CartEquepment> CartEquepmentRepository { get; }
    public IRepository<OrderEquepment> OrderEquepmentRepository { get; }
    public IRepository<EquepmentCategory> EquepmentCategoryRepository { get; }
    public IRepository<ProductCategory> ProductCategoryRepository { get; }
    
    public void Dispose()
    {
        GC.SuppressFinalize(true);
    }

    public async Task<bool> SaveAsync()
    {
        var saved = await this.dbContext.SaveChangesAsync();
        return saved > 0;
    }
}