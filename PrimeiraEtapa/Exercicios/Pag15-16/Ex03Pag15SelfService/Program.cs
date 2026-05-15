using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03Pag15SelfService
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double kg;
            double precofinal;
            Console.Write("Quantos quilos possui sua refeição: ");
            kg = double.Parse(Console.ReadLine());
            Console.Clear();
            precofinal = 58 * kg;
            Console.Write($"O valor do seu prato atual será de: R${precofinal}");
            Console.ReadKey();
        }
    }
}
