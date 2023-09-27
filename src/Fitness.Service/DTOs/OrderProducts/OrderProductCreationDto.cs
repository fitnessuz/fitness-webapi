namespace Fitness.Service.DTOs;

public class OrderProductCreationDto
{
    public long UserId { get; set; }
    public long ProductId { get; set; }
    public int Quantity { get; set; }
}