namespace Fitness.Service.DTOs;

public class OrderProductUpdateDto
{
    public long Id { get; set; }
    public long UserId { get; set; }
    public long ProductId { get; set; }
    public int Quantity { get; set; }
}