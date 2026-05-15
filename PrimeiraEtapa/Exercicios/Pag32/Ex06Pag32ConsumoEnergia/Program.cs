using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex06Pag32ConsumoEnergia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double valorKwh, quantConsumida, totalPago;

            Console.Write("Qual o valor do KwH: ");
            valorKwh = double.Parse(Console.ReadLine());
            Console.Clear();

            Console.Write("Qual a quantidade consumida: ");
            quantConsumida = double.Parse(Console.ReadLine());
            Console.Clear();

            totalPago = (quantConsumida * valorKwh) * 1.035;

            Console.Write($"O valor total à ser pago será de R${Math.Round(totalPago, 2)}");
            Console.ReadKey();
        }
    }
}
