using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstConsoleApp
{
    internal class Temperature
    {
        static void Main()
        {
            Console.WriteLine("Enter Temperature in Fahrenheit");
            int fahrenheit = int.Parse(Console.ReadLine());
            //formula: C= (F-32) * 5/9.
            int celsius = (fahrenheit - 32) * 5 / 9;
            Console.WriteLine("Temperature In Celsius is "+ celsius);
        }
    }
}
