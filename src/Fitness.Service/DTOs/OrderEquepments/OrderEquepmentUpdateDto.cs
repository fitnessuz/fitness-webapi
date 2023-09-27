namespace Fitness.Service.DTOs;

public class OrderEquepmentUpdateDto
{
    public long Id { get; set; }
    public long UserId { get; set; }
    public long EquepmentId { get; set; }
    public int Quantity { get; set; }
}