using Fitness.Domain.Commons;

namespace Fitness.Domain.Entities;

public class EquepmentCategory : Auditable
{
    public string Title { get; set; }
    public string Description { get; set; }
}