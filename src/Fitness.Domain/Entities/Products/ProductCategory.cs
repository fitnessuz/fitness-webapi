using Fitness.Domain.Commons;

namespace Fitness.Domain.Entities;

public class ProductCategory : Auditable
{
    public string Title { get; set; }
    public string Description { get; set; }
}