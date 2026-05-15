using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex01Pag54SomaVariosValores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero, typed = 0, typed40and50 = 0, soma = 0;

            Console.Write("Informe o 1° número inteiro: ");
            numero = int.Parse(Console.ReadLine());

            while (numero != 0)
            {
                typed += 1;
                if (numero > 40 && numero < 50)
                {typed40and50 += 1;}

                soma += numero;

                Console.Write("Informe outro número inteiro: ");
                numero = int.Parse(Console.ReadLine());

            }

            Console.WriteLine($"Total da soma: {soma}");
            Console.WriteLine($"Foram digitados: {typed}");
            Console.WriteLine($"Foram digitados entre 40 e 50: {typed40and50}");
            Console.ReadKey();
        }
    }
}
