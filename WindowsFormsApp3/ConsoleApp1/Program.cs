using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp3;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Which city would you like to go? ");
            Console.WriteLine("1. Barrie; 2. Toronto; 3. New York");
            var city = Console.ReadKey().KeyChar;
            Form1 formCity = new Form1(Convert.ToInt32(city.ToString()));
            formCity.ShowDialog();

        }
    }
}
