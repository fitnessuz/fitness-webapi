namespace Fitness.Service.DTOs;

public class CartEquepmentUpdateDto
{
    public long Id { get; set; }
    public UserResultDto User { get; set; }
    public EquepmentResultDto Equepment { get; set; }
    public int Quantity { get; set; }
}