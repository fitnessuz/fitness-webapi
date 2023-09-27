namespace Fitness.Service.DTOs;

public class OrderEquepmentCreationDto
{
    public long UserId { get; set; }
    public long EquepmentId { get; set; }
    public int Quantity { get; set; }
}