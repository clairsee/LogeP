using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex13Pag38PostoGasolina
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double liters;
            Console.Write("Quantos litros de gasolina foram postos em seu carro: ");
            liters = double.Parse(Console.ReadLine());

            Console.Clear();

            if (liters <= 10)
            {
                Console.Write("Você ganhou um Chaveiro de brinde!");
            }
            else if (liters <= 30)
            {
                Console.Write("Você ganhou uma Ducha no Carro de brinde!");
            }
            else if (liters <= 40)
            {
                Console.Write("Você ganhou uma Troca de Óleo de brinde!");
            }
            else
            {
                Console.Write("Você ganhou uma Ducha no Carro e uma Troca de Óleo de brinde!");
            }
            Console.ReadKey();
        }
    }
}
