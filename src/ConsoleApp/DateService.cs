using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class DateService
    {
        public static int GetWeekNo(CultureInfo cultureInfo, DateTime? date = null)
        {
            var givenDate = DateTime.Now;
            if(date.HasValue)
            {
                givenDate = date.Value;
            }
            //CultureInfo norwayCulture = new CultureInfo("nn-NO"); 
            Console.WriteLine(date?.ToLongDateString()); 
            int weekno = cultureInfo.Calendar
                                        .GetWeekOfYear(givenDate, CalendarWeekRule.FirstFullWeek,
                                                       DayOfWeek.Sunday); 
            return weekno;
        }
    }
}
