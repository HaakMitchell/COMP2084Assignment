using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MitchJson
{
    class Program
    {
        static void Main(string[] args)
        {
            JsonMitch myJsonLab = new JsonMitch();
            string filename = @"C:\Users\Mitchell\Desktop\jsondata1.json";
            myJsonLab.ReadJsonFile(filename);
            Student s = myJsonLab.JsonWorker();

            Console.WriteLine("Email: " + s.email);
            Console.WriteLine(string.Format("First name: {0}", s.firstName));
            Console.WriteLine(string.Format("Last name: {0}", s.lastName));

            Console.Read();

        }
    }
}
