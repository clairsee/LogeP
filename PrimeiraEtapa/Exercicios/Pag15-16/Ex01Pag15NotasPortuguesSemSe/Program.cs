using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex01Pag15NotasPortugues
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double notapro;
            double notapi;
            double notapf;
            double notasim;
            double media;
            double soma;
            double maior = 0;
            string maiornota = "";

            Console.Write("Qual foi sua nota na prova Intermediária: ");
            notapi = double.Parse(Console.ReadLine());
            Console.Clear();

            Console.Write("Qual foi sua nota na prova Final: ");
            notapf = double.Parse(Console.ReadLine());
            Console.Clear();

            Console.Write("Qual foi sua nota no Simulado: ");
            notasim = double.Parse(Console.ReadLine());
            Console.Clear();

            Console.Write("Qual foi sua nota nos Projetos: ");
            notapro = double.Parse(Console.ReadLine());
            Console.Clear();

            soma = notapi + notapf + notasim + notapro;
            media = soma / 4;

            maior = Math.Max(notapi,notapf);
            maior = Math.Max(maior, notasim);
            maior = Math.Max(maior, notapro);

            Console.WriteLine($"A soma de todas suas notas foi de: {soma}");
            Console.WriteLine($"A média de todas suas notas foi de: {media}");
            Console.WriteLine($"Sua maior nota foi de: {maior} pontos adquiridos");
            Console.ReadKey();
        }
    }
}
