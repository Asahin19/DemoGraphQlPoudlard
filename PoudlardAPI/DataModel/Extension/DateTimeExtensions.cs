using System;

namespace PoudlardAPI.DataModel.Extension
{
    public static class DateTimeExtensions
    {
        public static int ToAge(this DateTime dob)
        {
            DateTime today = new DateTime(1994, 6, 15);

            int months = today.Month - dob.Month;
            int years = today.Year - dob.Year;

            if (today.Day < dob.Day)
            {
                months--;
            }

            if (months < 0)
            {
                years--;
            }
            return years;
        }
    }
}
