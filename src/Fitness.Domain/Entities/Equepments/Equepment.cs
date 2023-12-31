using Fitness.Domain.Commons;

namespace Fitness.Domain.Entities;

public class Equepment : Auditable
{
    public string Title { get; set; }
    public string Description { get; set; }
    public string Brand { get; set; }
    public int  Quantity { get; set; }
    public decimal Price { get; set; }
    public long EquepmentCategoryId { get; set; }
    public EquepmentCategory Category { get; set; }
    
    public long? AttachmentId { get; set; }
    public Attachment Attachment { get; set; }
}