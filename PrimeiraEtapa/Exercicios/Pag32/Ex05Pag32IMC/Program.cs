using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex05Pag32IMC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double imc, altura, peso;

            Console.Write("Qual sua altura em metros: ");
            altura = double.Parse(Console.ReadLine());
            Console.Clear();

            Console.Write("Qual seu peso em quilos: ");
            peso = double.Parse(Console.ReadLine());
            Console.Clear();

            imc = peso / Math.Pow(altura,2);

            Console.Write($"O seu IMC é de {imc}");
            Console.ReadKey();
        }
    }
}
