using Fitness.Domain.Commons;
using Fitness.Domain.Enums;

namespace Fitness.Domain.Entities;

public class User : Auditable
{
    public string Firtsname { get; set; }
    public string Lastname { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public Role Role { get; set; }
    public DateTime DateOfBirth { get; set; }
    public Gender Gender { get; set; }
    
    public long PlanId { get; set; }
    public Plan Plan { get; set; }
    
    public long TeacherId { get; set; }
    public Teacher Teacher { get; set; }
    
    public long? AttachmentId { get; set; }
    public Attachment Attachment { get; set; }
}