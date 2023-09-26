using Fitness.Domain.Commons;

namespace Fitness.Domain.Entities;

public class Attachment : Auditable
{
    public string FileName { get; set; }
    public string FilePath { get; set; }
}