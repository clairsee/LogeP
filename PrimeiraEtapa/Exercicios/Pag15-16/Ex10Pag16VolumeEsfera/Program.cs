using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex10Pag16VolumeEsfera
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double raio;
            double volume;
            Console.Write("Qual o valor do Raio da Esfera: ");
            raio = double.Parse(Console.ReadLine());
            volume = ((4 * Math.Pow(raio, 3)) * 3.14) /3;
            Console.Clear();
            Console.Write($"O valor do Volume dessa Esfera será de: {volume}");
            Console.ReadKey();

            
        }
    }
}
