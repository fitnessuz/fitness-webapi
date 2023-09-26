using Fitness.Domain.Commons;
using Fitness.Domain.Entities.Products;

namespace Fitness.Domain.Entities.Carts;

public class CartProduct : Auditable
{
    public long UserId { get; set; }
    public User User { get; set; }
    
    public long ProductId { get; set; }
    public Product Product { get; set; }
    
    public int Quantity { get; set; }
}