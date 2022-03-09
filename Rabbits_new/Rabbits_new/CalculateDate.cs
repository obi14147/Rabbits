using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Rabbits_new
{
    public class CalculateDate
    {
        private Calendar calendar = CultureInfo.InvariantCulture.Calendar;
        public DateTime[] getDates(DateTime startDate)
        {

            List<DateTime> arrayDate = new List<DateTime>();
            DateTime dateBirth = calendar.AddDays(startDate, 31);
            DateTime dateParaMum = calendar.AddDays(startDate, 56);
            DateTime dateSplit = calendar.AddMonths(startDate, 4);

            arrayDate.Add(dateBirth);
            arrayDate.Add(dateParaMum);
            arrayDate.Add(dateSplit);

            return arrayDate.ToArray();
        }
    }
}
