using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex11Pag38VencimentoJuros
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double price, lateDays;
            Console.Write("Qual o valor da conta: ");
            price = double.Parse(Console.ReadLine());
            Console.Write("Quantos dias de atraso: ");
            lateDays = double.Parse(Console.ReadLine());

            Console.Clear();

            price = (price*0.10) * lateDays + price;

            Console.Write($"O valor que deverá ser pago será de R${price}");
            Console.ReadKey();
        }
    }
}
