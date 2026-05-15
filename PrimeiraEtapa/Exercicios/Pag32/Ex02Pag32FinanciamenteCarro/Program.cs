using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex02Pag32FinanciamenteCarro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double valorCarro, valorEntrada, totalParcelas, valorParcelas;
            int parcelas;

            Console.Write("Qual o valor total do carro: ");
            valorCarro = double.Parse(Console.ReadLine());
            Console.Clear();

            Console.Write("Qual a quantidade de parcelas desejada: ");
            parcelas = int.Parse(Console.ReadLine());
            Console.Clear();

            valorEntrada = valorCarro * 0.4;
            totalParcelas = valorCarro - valorEntrada;
            valorParcelas = totalParcelas / parcelas;
            

            Console.Write($"Do valor total do carro de R${valorCarro}\nO valor de entrada será de R${valorEntrada}\nDo restante R${totalParcelas}, serão pagas {parcelas} parcelas cada de R${valorParcelas}");
            Console.ReadKey();
        }
    }
}
