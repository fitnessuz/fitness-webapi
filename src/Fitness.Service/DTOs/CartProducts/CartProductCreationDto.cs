namespace Fitness.Service.DTOs;

public class CartProductCreationDto
{
    public long UserId { get; set; }
    public long ProductId { get; set; }
    public int Quantity { get; set; }
}