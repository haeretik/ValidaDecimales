using System;
using System.Collections.Generic;

namespace ValidaDecimales
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<double>() { 8.32, 433.000, 2.232, 2.0, 54.00, 1.00 };
            int count = 0;
            foreach (double Value in list)
            {
                count++;
                String.Format("{0:0.##}", Value);
                Console.WriteLine($"Element{count }:{Value}");
            }
            Console.WriteLine("Numero de elementos: " + count);
        }
    }
}
