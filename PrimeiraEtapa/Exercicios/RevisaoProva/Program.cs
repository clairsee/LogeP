using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace RevisaoProva
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nomeUnit
            double valor = 200, somaValor = 0;
            int maxValue = int.MinValue, minValue = int.MaxValue, performanceValor = 0, alunos = 0;

            Console.Write("Qual o nome de sua Unidade Esportiva: ");
            nomeUnit = Console.ReadLine();

            Console.Clear();

            while (true)
            {
                Console.Write("Para sair, digite 0\r\nQual seu Número de Matrícula: ");
                int matricula = int.Parse(Console.ReadLine());

                Console.Clear();

                if (matricula == 0)
                {
                    break;
                }
                else if (!(matricula > 1000 & matricula < 5000))
                {
                    Console.WriteLine("Código de Matrícula Inválido");
                    continue;
                }

                Console.Write("Seu Nome: ");
                string nome = Console.ReadLine();

                Console.Clear();

                Console.Write("Sexo (F/M): ");
                char sexo = char.Parse(Console.ReadLine().ToUpper());

                Console.Clear();

                if (sexo != 'F' && sexo != 'M')
                {
                    Console.WriteLine("Escolha um Sexo válido. F ou M.");
                    continue;
                }

                Console.Write("Peso Atual (Em Quilos): ");
                int peso = int.Parse(Console.ReadLine());

                Console.Clear();

                Console.Write("Objetivo de Treino\n1 - Perda de Peso\n2 - Ganho de Massa\n3 - Performance Atleta\nOpção: ");
                int treino = int.Parse(Console.ReadLine());

                Console.Clear();

                switch(treino)
                {
                    case 1:
                        valor *= 1.1;
                        break;
                    case 2:
                        valor *= 1.15;
                        break;
                    case 3:
                        valor *= 1.25;
                        performanceValor += 1;
                        break;
                    default:
                        Console.WriteLine("Escolha um treino válido.");
                        continue;
                }

                if (peso > 95)
                {
                    Console.Write("Status: Requer Equipamento Reforçado\n");
                } else
                {
                    Console.Write("Status: Equipamento Padrão\n");
                }

                somaValor += valor;
                alunos += 1;


                if (peso > maxValue)
                {
                    maxValue = peso;
                }

                if (peso < minValue)
                {
                    minValue = peso;
                } 

                Console.Write($"Foram Matriculados: {alunos} Alunos\n");
                Console.Write($"Alunos que escolheram Performance Alta: {performanceValor}\n");
                Console.Write($"Valor total de todas as Mensalidades: R${somaValor}\n");
                Console.Write($"O Maior peso foi: {maxValue}\n");
                Console.Write($"O Menor peso foi: {minValue}\n");
                Console.ReadKey();
                Console.Clear();
            }
            double media = somaValor/alunos;
            Console.Write($"{nomeUnit}\n");
            Console.Write($"Foram Matriculados: {alunos} Alunos\n");
            Console.Write($"Alunos que escolheram Performance Alta: {performanceValor}\n");
            Console.Write($"O Maior peso foi: {maxValue}\n");
            Console.Write($"O Menor peso foi: {minValue}\n");
            Console.Write($"A Média das Mensalidades foram: R${media.ToString("0,00")}\n");
            Console.ReadKey();
        }
    }
}
