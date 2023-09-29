using System.Net;

namespace Fitness.Service.Exceptions;

public class BadRequestException:Exception
{
    public HttpStatusCode StatusCode { get; set; } = HttpStatusCode.BadRequest;
    public string TitleMessage { get; set; } = String.Empty;
}
