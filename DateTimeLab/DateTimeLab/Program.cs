using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeLab
{
    class Program
    {

        static void Main(string[] args)
        {

            DateTimeLab dateTimeLab = new DateTimeLab();
            //testing assiging and reading properties
            dateTimeLab.CurrentDateTime = DateTime.Now;
            DateTime p = dateTimeLab.CurrentDateTime;

            //dateTimeLab.PrintCurrentTime();

            //testing passing a value type with/without ref
            DateTime currentDate = DateTime.Now;
            DateTime nextBusDay;
            nextBusDay = dateTimeLab.NextMonth4thBusinessDay(currentDate);
            dateTimeLab.NextMonth4thBusinessDay(ref currentDate);
            Console.Read();




        }
    }
}
