namespace Fitness.Service.Helpers;

public class TimeHelper
{
    public const int TimeConstans=5;

    public static DateTime GetDateTime()
    {
        var dtTime = DateTime.UtcNow;
        dtTime.AddHours(TimeConstans);
        return dtTime;
    }
}
