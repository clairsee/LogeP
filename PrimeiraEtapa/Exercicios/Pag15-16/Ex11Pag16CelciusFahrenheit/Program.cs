using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex11Pag16CelciusFahrenheit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double celcius;
            double fahrenheit;
            Console.Write("Qual o valor da temperatura em Celcius: ");
            celcius = double.Parse(Console.ReadLine());
            Console.Clear();
            fahrenheit = celcius * 9 / 5 + 32;
            Console.Write($"O valor em Fahrenheit de {celcius} graus Celcius será: {fahrenheit} graus Fahrenheit");
            Console.ReadKey();
        }
    }
}
