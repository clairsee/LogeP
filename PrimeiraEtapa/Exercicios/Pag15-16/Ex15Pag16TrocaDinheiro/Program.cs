using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex15Pag16TrocaDinheiro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int valortotal, nota200=0, nota100=0, nota50=0, nota20=0, nota10=0, nota5=0, nota2=0;
            Console.Write("Qual será o valor a ser trocado (Valor inteiro): ");
            valortotal = int.Parse(Console.ReadLine());
            while (valortotal >= 200)
            {
                nota200++;
                valortotal = valortotal - 200;
            }
            while (valortotal >= 100)
            {
                nota100++;
                valortotal = valortotal - 100;
            }
            while (valortotal >= 50)
            {
                nota50++;
                valortotal = valortotal - 50;
            }
            while (valortotal >= 20)
            {
                nota20++;
                valortotal = valortotal - 20;
            }
            while (valortotal >= 10)
            {
                nota10++;
                valortotal = valortotal - 10;
            }
            while (valortotal >= 5)
            {
                nota5++;
                valortotal = valortotal - 5;
            }
            while (valortotal >= 2)
            {
                nota2++;
                valortotal = valortotal - 2;
            }
            Console.Write($"Foram utilizadas: \n{nota200} Notas de 200\n{nota100} Notas de 100\n{nota50} Notas de 50\n{nota20} Notas de 20\n{nota10} Notas de 10\n{nota5} Notas de 5\n{nota2} Notas de 2");
            Console.ReadKey();
        }
    }
}
