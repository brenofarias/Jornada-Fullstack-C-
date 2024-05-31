namespace Fina.Core.Commom
{
    // Extension Methods
    public static class DateTimeExtension
    {
        // DateTime.GetFistDay()
        public static DateTime GetFirstDay(this DateTime date, int? year = null, int? month = null)
            => new (year ?? date.Year, month ?? date.Month, day: 1);

        public static DateTime GetLastDay(this DateTime date, int? year = null, int? month = null)
            => new DateTime(
                    year ?? date.Year,
                    month ?? date.Month,
                    day: 1)
                .AddMonths(1)
                .AddDays(-1);
        
    }
}
