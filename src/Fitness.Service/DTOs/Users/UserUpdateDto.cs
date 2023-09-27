using Fitness.Domain.Enums;

namespace Fitness.Service.DTOs;

public class UserUpdateDto
{
    public long Id { get; set; }
    public string Firtsname { get; set; }
    public string Lastname { get; set; }
    public string Password { get; set; }
    public string Phone { get; set; }
    public DateTime DateOfBirth { get; set; }
    public Gender Gender { get; set; }
    public long PlanId { get; set; }
    public long TeacherId { get; set; }
    public long? AttachmentId { get; set; }
}