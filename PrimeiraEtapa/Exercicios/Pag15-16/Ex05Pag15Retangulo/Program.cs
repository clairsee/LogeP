using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex05Pag15Retangulo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double lado1;
            double lado2;
            double area;
            double perimetro;
            Console.Write("Qual o valor do primeiro lado do retângulo: ");
            lado1 = double.Parse(Console.ReadLine());
            Console.Clear();
            Console.Write("Qual o valor do segundo lado do retângulo: ");
            lado2 = double.Parse(Console.ReadLine());
            Console.Clear();
            area = lado1 * lado2;
            perimetro = (lado1 * 2) + (lado2 * 2);
            Console.Write($"O valor da área desse retângulo será de: {area}\nO valor do perímetro desse retângulo será de: {perimetro}");
            Console.ReadKey();
        }
    }
}
