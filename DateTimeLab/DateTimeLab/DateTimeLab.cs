using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeLab
{
    class DateTimeLab
    {
        private DateTime currentDateTime;

        public DateTime CurrentDateTime { get => currentDateTime; set => currentDateTime = value; }

        public void PrintCurrentTime()
        {
            Console.WriteLine(DateTime.Now);
        }
        public DateTime NextMonth4thBusinessDay(DateTime thisDate)
        {
            thisDate = thisDate.AddMonths(1);
            return thisDate;
        }
        public void NextMonth4thBusinessDay(ref DateTime thisDate)
        {
            thisDate = thisDate.AddMonths(1);
        }
    }
}
