using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex01Pag32LojaEletrodomesticos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double valorCompra, valorEntrada, totalCompra, totalParcela;
            int parcelas = 0;

            Console.Write("Qual o valor total da compra: ");
            valorCompra = double.Parse(Console.ReadLine());
            Console.Clear();

            Console.Write("Qual o valor de entrada: ");
            valorEntrada = double.Parse(Console.ReadLine());
            Console.Clear();

            do {
                Console.Write("Qual quantidade de parcelas gostaria (Máximo 5): ");
                parcelas = int.Parse(Console.ReadLine());
                Console.Clear();
                if (parcelas > 5 || parcelas <= 0)
                {
                    Console.Write("Valor errôneo. Digite uma quantidade de parcelas permitida.\n");
                }
            } while (parcelas > 5 || parcelas <= 0);

            totalCompra = valorCompra - valorEntrada;
            totalParcela = totalCompra / parcelas;

            Console.Write($"O valor de compra inicial foi de R${valorCompra}\nO valor de Entrada foi de R${valorEntrada}\nFoi dividido em {parcelas} parcelas cada uma de R${totalParcela} do valor de R${totalCompra}");
            Console.ReadKey();
        }
    }
}
