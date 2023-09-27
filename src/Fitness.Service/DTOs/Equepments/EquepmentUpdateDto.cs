using Fitness.Domain.Entities;

namespace Fitness.Service.DTOs;

public class EquepmentUpdateDto
{
    public long Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public string Brand { get; set; }
    public int  Quantity { get; set; }
    public decimal Price { get; set; }
    public long EquepmentCategoryId { get; set; }
    public long? AttachmentId { get; set; }
}