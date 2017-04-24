using System;
using WebApiUtilities.Core.Interface;

namespace WebApiUtilities.Core
{
    public class DateUtilities : IDateUtilities
    {
        public DateTime ConvertToDate(string date)
        {
            try
            {
                var day = int.Parse(date.Substring(0, 2));
                var month = int.Parse(date.Substring(2, 2));
                var year = int.Parse(date.Substring(4, 4));

                return new DateTime(year, month, day);
            }
            catch
            {
                return DateTime.MinValue;
            } 
        }

        public string FormatToDate(DateTime date)
        {
            return date.ToShortDateString();
        }

        public bool IsValidDate(string date)
        {
            var defaultDate = DateTime.MinValue;
            return DateTime.TryParse(date, out defaultDate);
        }
    }
}
