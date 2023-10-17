namespace AeroflotAPI;

public static class StaticMethods
{
    public static long ConvertToTimestamp(DateTime value)
    {
        var epoch = (value.Ticks - 621355968000000000) / 10000000;
        return epoch;
    }

    public static DateTime UnixTimeStampToDateTime(double unixTimeStamp)
    {
        // Unix timestamp is seconds past epoch
        var dateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
        dateTime = dateTime.AddSeconds(unixTimeStamp).ToLocalTime();
        return dateTime;
    }
}