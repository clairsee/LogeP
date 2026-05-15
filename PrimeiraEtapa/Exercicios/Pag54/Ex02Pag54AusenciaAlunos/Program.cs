using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex02Pag54AusenciaAlunos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char unid = ' ';
            int pres = 0, falFlo = 0, falBar = 0, presFlo = 0, presBar = 0;

            while(true) {
            // Pergunte a Frequência
            do
            {
                Console.Write("Presença do Aluno (Digite -1 para sair do programa)\n0 - Presente\n1 - Ausente\nOpção: ");
                pres = int.Parse(Console.ReadLine().ToUpper());
                if (!(pres == 0) && !(pres == 1) && !(pres == -1)) { Console.Clear(); Console.WriteLine("Escolha entre Barroca ou Floresta"); } // Avisa o usuário de um input errado
            } while (!(pres == 0) && !(pres == 1) && !(pres == -1)); // Evita o uso de caracatéres errados
                Console.Clear();
                if (pres == -1) { Console.Write("Obrigado por usar o programa\n"); break; }

                // Pergunte a Unidade
                do {
                Console.Write("Qual unidade é do Aluno\nB - Barroca\nF - Floresta\nOpção: ");
                unid = char.Parse(Console.ReadLine().ToUpper());
                if (!(unid == 'F') && !(unid == 'B')) { Console.Clear(); Console.WriteLine("Escolha entre Barroca ou Floresta"); } // Avisa o usuário de um input errado
            } while (!(unid == 'F') && !(unid == 'B')); // Evita o uso de caracatéres errados

            Console.Clear();

            switch (pres)
            {
                case 0:
                    switch (unid)
                    {
                        case 'F':
                            presFlo += 1;
                            break;
                        case 'B':
                            presBar += 1;
                            break;
                    }
                    break;
                case 1:
                    switch (unid)
                    {
                        case 'F':
                            falFlo += 1;
                            break;
                        case 'B':
                            falBar += 1;
                            break;
                    }
                    break;
             }
            }

            Console.Write($"Presença no Colégio Floresta\nPresentes - {presFlo}\nAusentes - {falFlo}\n");
            Console.WriteLine($"Presença no Colégio Barroca\nPresentes - {presBar}\nAusentes - {falBar}");
            Console.ReadKey();
        }
    }
}
