using Fitness.Domain.Enums;

namespace Fitness.Service.DTOs;

public class UserResultDto
{
    public long Id { get; set; }
    public string Firtsname { get; set; }
    public string Lastname { get; set; }
    public string Password { get; set; }
    public string Phone { get; set; }
    public DateTime DateOfBirth { get; set; }
    public Gender Gender { get; set; }
    public PlanResultDto Plan { get; set; }
    public TeacherResultDto Teacher { get; set; }
    public AttachmentResultDto Attachment { get; set; }
}