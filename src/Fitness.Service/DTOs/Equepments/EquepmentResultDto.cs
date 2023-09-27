namespace Fitness.Service.DTOs;

public class EquepmentResultDto
{
    public long Id { get; set; }
    public string Title { get; set; }    
    public string Description { get; set; }
    public string Brand { get; set; }
    public int  Quantity { get; set; }
    public decimal Price { get; set; }
    public EquepmentCategoryResultDto EquepmentCategory { get; set; }
    public AttachmentResultDto Attachment { get; set; }
}