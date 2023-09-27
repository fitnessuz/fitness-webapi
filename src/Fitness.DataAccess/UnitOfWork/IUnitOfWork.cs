using Fitness.Domain.Entities;
using Fitness.Domain.Entities.Carts;
using Fitness.Domain.Entities.Orders;
using Fitness.DataAccess.Repositories;
using Fitness.Domain.Entities.Messages;
using Fitness.Domain.Entities.Products;

namespace Fitness.DataAccess.UnitOfWork;


public interface IUnitOfWork : IDisposable
{
    IRepository<Plan> PlanRepository { get; }
    IRepository<User> UserRepository { get; }
    IRepository<Product> ProductRepository { get; }
    IRepository<Teacher> TeacherRepository { get; }
    IRepository<Message> MessageRepository { get; }
    IRepository<Equempent> EquempentRepository { get; }
    IRepository<Attachment> AttachmentRepository { get; }
    IRepository<CartProduct> CartProductRepository { get; }
    IRepository<OrderProduct> OrderProductRepository { get; }
    IRepository<CartEquepment> CartEquepmentRepository { get; }
    IRepository<OrderEquepment> OrderEquepmentRepository { get; }
    IRepository<EquepmentCategory> EquepmentCategoryRepository { get; }
    IRepository<ProductCategory> ProductCategoryRepository { get; }
    
    Task<bool> SaveAsync();
}