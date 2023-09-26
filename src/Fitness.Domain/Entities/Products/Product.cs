using Fitness.Domain.Commons;

namespace Fitness.Domain.Entities.Products;

public class Product : Auditable
{
    public string Title { get; set; }
    public string Description { get; set; }
    public string Brand { get; set; }
    public int  Quantity { get; set; }
    public decimal Price { get; set; }
    public ProductCategory Category { get; set; }
    
    public long? AttachmentId { get; set; }
    public Attachment Attachment { get; set; }
}