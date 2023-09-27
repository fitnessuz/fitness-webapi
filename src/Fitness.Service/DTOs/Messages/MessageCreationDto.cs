namespace Fitness.Service.DTOs;

public class MessageCreationDto
{
    public string Text { get; set; }
    public long SenderId { get; set; }
    public long ReceiverId { get; set; }
    public long? AttachmentId { get; set; }
}