namespace Fitness.Service.DTOs;

public class OrderProductResultDto
{
    public long Id { get; set; }
    public UserResultDto User { get; set; }
    public ProductResultDto Product { get; set; }
    public int Quantity { get; set; }
}