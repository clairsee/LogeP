using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex07Pag32CompraDesconto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double valorCompra, totalPago;

            Console.Write("Qual é o valor da compra: ");
            valorCompra = double.Parse(Console.ReadLine());
            Console.Clear();

            totalPago = valorCompra * 0.88;

            Console.Write($"O valor a ser pago será de R${totalPago}, com o desconto aplicado");
            Console.ReadKey();
        }
    }
}
