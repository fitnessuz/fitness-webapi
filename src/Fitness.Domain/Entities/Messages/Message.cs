using Fitness.Domain.Commons;

namespace Fitness.Domain.Entities.Messages;

public class Message : Auditable
{
    public string Text { get; set; }
    
    public long SenderId { get; set; }
    public User SenderUser { get; set; }
    
    public long ReceiverId { get; set; }
    public User ReceiverUser { get; set; }
    
    public long? AttachmentId { get; set; }
    public Attachment Attachment { get; set; }
}