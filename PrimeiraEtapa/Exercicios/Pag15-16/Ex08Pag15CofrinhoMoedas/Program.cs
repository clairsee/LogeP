using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex08Pag15CofrinhoMoedas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double cent1;
            double cent5;
            double cent10;
            double cent25;
            double cent50;
            double real1;
            double total;
            Console.Write("Quantas moedas de 1 centavos existem: ");
            cent1 = double.Parse(Console.ReadLine());
            Console.Clear();
            Console.Write("Quantas moedas de 5 centavos existem: ");
            cent5 = double.Parse(Console.ReadLine());
            Console.Clear();
            Console.Write("Quantas moedas de 10 centavos existem: ");
            cent10 = double.Parse(Console.ReadLine());
            Console.Clear();
            Console.Write("Quantas moedas de 25 centavos existem: ");
            cent25 = double.Parse(Console.ReadLine());
            Console.Clear();
            Console.Write("Quantas moedas de 50 centavos existem: ");
            cent50 = double.Parse(Console.ReadLine());
            Console.Clear();
            Console.Write("Quantas moedas de 1 real existem: ");
            real1 = double.Parse(Console.ReadLine());
            Console.Clear();
            total = (cent1 * 0.01) + (cent5*0.05) + (cent10 * 0.1) + (cent25 * 0.25) + (cent50 * 0.5) + (real1 * 1);
            Console.Write($"No total, foram arrecadados: R${total}");
            Console.ReadKey();

        }
    }
}
