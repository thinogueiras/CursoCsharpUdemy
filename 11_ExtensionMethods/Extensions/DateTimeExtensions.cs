using System.Globalization;

namespace System
{
    public static class DateTimeExtensions
    {
        public static string ElapsedTime(this DateTime dateTime)
        {
            var duration = DateTime.Now.Subtract(dateTime);

            if (duration.TotalHours < 24.0)
            {
                return duration.TotalHours.ToString("F1", CultureInfo.InvariantCulture) + " hours";
            }
            else
            {
                return duration.TotalDays.ToString("F1", CultureInfo.InvariantCulture) + " days";
            }
        }
    }
}
