using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex13Pag16CompraLoja
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double valoruni;
            int quant;
            double valor;
            Console.Write("Qual o valor do produto: ");
            valoruni = double.Parse(Console.ReadLine());
            Console.Clear();
            Console.Write("Quantas unidades foram compradas: ");
            quant = int.Parse(Console.ReadLine());
            Console.Clear();
            valor = valoruni * quant;
            Console.Write($"O valor total de compra será: R${valor}");
            Console.ReadKey();
        }
    }
}
