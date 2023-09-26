using Fitness.Domain.Commons;

namespace Fitness.Domain.Entities.Orders;

public class OrderEquepment : Auditable
{
    public long UserId { get; set; }
    public User User { get; set; }
    
    public long EquepmentId { get; set; }
    public Equempent Equepment { get; set; }
    
    public int Quantity { get; set; }
}