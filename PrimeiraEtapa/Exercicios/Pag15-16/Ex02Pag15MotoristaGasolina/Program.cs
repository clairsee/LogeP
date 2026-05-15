using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex02Pag15MotoristaGasolina
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double gasolina;
            double preco;
            double valorfinal;
            Console.Write("Qual o valor da Gasolina: ");
            gasolina = double.Parse(Console.ReadLine());
            Console.Clear();
            Console.Write("Qual valor você irá pagar: ");
            preco = double.Parse(Console.ReadLine());
            valorfinal = preco / gasolina;
            Console.Clear();
            Console.Write($"Com R${preco}, você irá conseguir abastecer com: {valorfinal} Litros de gasolina.");
            Console.ReadKey();
        }
    }
}