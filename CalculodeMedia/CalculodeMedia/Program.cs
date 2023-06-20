using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculodeMedia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double nota1;-
            double nota2 = 10;
            double media;

            nota1 = Convert.ToDouble(Console.ReadLine()); 
            nota2 = double.Parse(Console.ReadLine()); 
            
            media = (nota1 + nota2) / 2;
            Console.WriteLine(media.ToString());

        }

    }
}
