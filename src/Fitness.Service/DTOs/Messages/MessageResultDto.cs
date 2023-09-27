namespace Fitness.Service.DTOs;

public class MessageResultDto
{
    public long Id { get; set; }
    public string Text { get; set; }
    public UserResultDto Sender { get; set; }
    public UserResultDto Receiver { get; set; }
    public AttachmentResultDto Attachment { get; set; }
}
