using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex09Pag15PessoaDados
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nascimento;
            int anoatual;
            int idadeano;
            int idademes;
            int idadedia;
            int idadesemana;
            Console.Write("Qual seu ano de nascimento: ");
            nascimento = int.Parse(Console.ReadLine());
            Console.Clear();
            Console.Write("Qual o ano atual: ");
            anoatual = int.Parse(Console.ReadLine());
            Console.Clear();
            idadeano = anoatual - nascimento;
            idadedia = idadeano * 365;
            idadesemana = idadeano * 52;
            idademes = idadeano * 12;
            Console.Write($"Você possui {idadeano} Anos de vida\nVocê possui {idademes} Meses de vida\nVocê possui {idadesemana} Semanas de vida\nVocê possui {idadedia} Dias de vida");
            Console.ReadKey();
        }
    }
}
