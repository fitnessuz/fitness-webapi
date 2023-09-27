namespace Fitness.Service.DTOs;

public class MessageUpdateDto
{
    public long Id { get; set; }
    public string Text { get; set; }
    public long SenderId { get; set; }
    public long ReceiverId { get; set; }
    public long? AttachmentId { get; set; }
}