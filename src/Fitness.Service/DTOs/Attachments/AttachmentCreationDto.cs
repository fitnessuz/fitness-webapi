using Microsoft.AspNetCore.Http;

namespace Fitness.Service.DTOs;

public class AttachmentCreationDto
{
    public IFormFile File { get; set; }
}