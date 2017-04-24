using System;

namespace WebApiUtilities.Core.Interface
{
    public interface IDateUtilities
    {
        bool IsValidDate(string date);
        DateTime ConvertToDate(string date);
        string FormatToDate(DateTime date);
    }
}
