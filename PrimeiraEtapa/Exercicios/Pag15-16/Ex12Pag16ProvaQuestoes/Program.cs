using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Ex12Pag16ProvaQuestoes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int questoes;
            int acertos;
            int errosporc;
            int erros
            Console.Write("Quantas questões haviam na prova: ");
            questoes = int.Parse(Console.ReadLine());
            Console.Clear();
            Console.Write("Quantas questões foram acertadas: ");
            acertos = int.Parse(Console.ReadLine());
            Console.Clear();
            erros = questoes-acertos
            errosporc = (erros*100)/questoes;
            acertos = (acertos * 100) / questoes;
            Console.Write($"Em uma prova de {questoes} questões\nVocê acertou {acertos}% questões\nVocê errou {erros} questões, sendo elas {errosporc}% das questões");
            Console.ReadKey();
        }
    }
}
