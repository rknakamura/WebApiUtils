using System;

namespace WebApiUtilities.Core.Interface
{
    public interface IDateUtilities
    {
        bool IsValidDate(DateTime date);
        DateTime ConvertToDate(string date);
        string FormatToDate(DateTime date);
    }
}
