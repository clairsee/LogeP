// Bernardo Oliveira de Souza - Número de Chamada: 9

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex02Pag46
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcao, juros = 0;
            double parcela = 0;

            Console.Write("Valor do Veículo Adquirido: ");
            double priceCar = double.Parse(Console.ReadLine());

            Console.Write("Qual o plano escolhido:\n1 - 24 Parcelas e Juros de 30%\n2 - 36 Parcelas e Juros de 55%\n3 - 48 Parcelas e Juros de 75%\n4 - 60 Parcelas e Juros de 100%\nOpção: ");
            do
            {
                opcao = int.Parse(Console.ReadLine());
                Console.Clear();
                if (opcao < 1 || opcao > 4) {
                    Console.WriteLine("Opção Errada.");
                    Console.Write("Qual o plano escolhido:\n1 - 24 Parcelas e Juros de 30%\n2 - 36 Parcelas e Juros de 55%\n3 - 48 Parcelas e Juros de 75%\n4 - 60 Parcelas e Juros de 100%\nOpção: ");
                }
            } while (opcao < 1 || opcao > 4);

            switch (opcao)
            {
                case 1:
                    juros = 30;
                    priceCar *= 1.3;
                    parcela = priceCar / 24;
                    break;
                case 2:
                    juros = 55;
                    priceCar *= 1.55;
                    parcela = priceCar / 36;
                    break;
                case 3:
                    juros = 75;
                    priceCar *= 1.75;
                    parcela = priceCar / 48;
                    break;
                case 4:
                    juros = 100;
                    priceCar *= 2;
                    parcela = priceCar / 60;
                    break;
            }
            Console.Write($"Os Juros a serem cobrados serão de {juros}%\nO valor total do financiamento será de R${priceCar}\nCada parcela valerá R${parcela}") ;
            Console.ReadKey();
        }
    }
}
