namespace Fitness.Service.DTOs;

public class CartProductUpdateDto
{
    public long UserId { get; set; }
    public long ProductId { get; set; }
    public int Quantity { get; set; }
}