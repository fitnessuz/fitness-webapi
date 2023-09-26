using Fitness.Domain.Commons;

namespace Fitness.Domain.Entities;

public class Plan : Auditable
{
    public string Title { get; set; }
    public string Description { get; set; }
    public decimal Price { get; set; }
}