using Microsoft.AspNetCore.Http;

namespace Fitness.Service.Extensions;

/// <summary>
/// Converts file to byte array and make you able to copy to other directory
/// </summary>
public static class Converter
{
    public static byte[] ToByte(this IFormFile formFile)
    {
        using var memoryStream = new MemoryStream();
        formFile.CopyTo(memoryStream);
        return memoryStream.ToArray();
    }
}