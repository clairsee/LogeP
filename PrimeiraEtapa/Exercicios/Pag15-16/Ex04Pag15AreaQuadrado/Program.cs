using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaQuadrado
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double lado;
            double area;
            Console.Write("Qual o lado do quadrado: ");
            lado = double.Parse(Console.ReadLine());
            area = lado * lado;
            Console.Clear();
            Console.Write($"O valor da área do quadro é igual a: {area}");
            Console.ReadKey();
        }
    }
}
