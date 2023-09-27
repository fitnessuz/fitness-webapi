using Fitness.Domain.Enums;

namespace Fitness.Service.DTOs;

public class TeacherUpdateDto
{
    public long Id { get; set; }
    public string Firtsname { get; set; }
    public string Lastname { get; set; }
    public string Email { get; set; }
    public string Bio { get; set; }
    public string Phone { get; set; }
    public TeacherCategory Category { get; set; }
    public DateTime DateOfBirth { get; set; }
    public Gender Gender { get; set; }
    public long? AttachmentId { get; set; }
}