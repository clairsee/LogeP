using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex08Pag32TimeMineiroEstatisticas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nomeTime;
            int vitoria, empate, derrota, pontos;
            double golsMarcados, golsSofridos, saldo, jogos, porcVitoria, porcEmpate, porcDerrota, mediaGolsMarcados, mediaGolsSofridos;

            Console.Write("Qual o nome do time: ");
            nomeTime = Console.ReadLine();
            Console.Clear();

            Console.Write("Quantas vitórias tiveram: ");
            vitoria = int.Parse(Console.ReadLine());
            Console.Clear();

            Console.Write("Quantos empates tiveram: ");
            empate = int.Parse(Console.ReadLine());
            Console.Clear();

            Console.Write("Quantas derrotas tiveram: ");
            derrota = int.Parse(Console.ReadLine());
            Console.Clear();

            Console.Write("Quantos gols marcaram: ");
            golsMarcados = int.Parse(Console.ReadLine());
            Console.Clear();

            Console.Write("Quantos gols sofreram: ");
            golsSofridos = int.Parse(Console.ReadLine());
            Console.Clear();

            pontos = vitoria * 3 + empate;
            saldo = golsMarcados - golsSofridos;
            jogos = vitoria + empate + derrota;
            porcVitoria = (vitoria * 100) / jogos;
            porcEmpate = (empate * 100) / jogos;
            porcDerrota = (derrota * 100) / jogos;
            mediaGolsMarcados = golsSofridos / jogos;
            mediaGolsSofridos = golsSofridos / jogos;

            Console.WriteLine($"O time {nomeTime} obteve {pontos} pontos");
            Console.WriteLine($"Ele teve um saldo de {saldo} gols em {jogos} jogos");
            Console.WriteLine($"Nessa temporada ele possui uma porcentagem de vitória de {porcVitoria}%");
            Console.WriteLine($"Nessa temporada ele possui uma porcentagem de empate de {porcEmpate}%");
            Console.WriteLine($"Nessa temporada ele possui uma porcentagem de derrota de {porcDerrota}%");
            Console.WriteLine($"Ele teve uma média de gols marcados de {mediaGolsMarcados} gols");
            Console.WriteLine($"Ele teve uma média de gols sofridos de {mediaGolsSofridos} gols");
            Console.ReadKey();
        }
    }
}
