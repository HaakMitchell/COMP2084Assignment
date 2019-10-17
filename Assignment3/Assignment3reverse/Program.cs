using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3reverse
{
    class Program
    {
        static void Main(string[] args)
        {
             sl = new StringLab();
            sl.OriginalString = "good string";
            Console.WriteLine(sl.OriginalString);

            sl.OriginalString = "shit string";
            Console.WriteLine(sl.OriginalString);

            //set the property value
            sl.OriginalString = "good value";
            //get the property value and print 
            Console.WriteLine(sl.OriginalString);
            sl.OriginalString = "Call me and save big.";
            Console.WriteLine(sl.OriginalString);

            //the following can be your sample codes for the assignment
            Console.WriteLine("Please input a string to test:");
            sl = new StringLab(Console.ReadLine());
            string resultString = sl.StringReverse();
            Console.WriteLine(resultString);
            Console.Read();
        }
    }
}
