using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex11Pag57IBGE
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nome, sexo, nomeNova = "";
            int cont = 0, idade, instrucao, analfabetos = 0, soma = 0, contHA = 0, homensG = 0, contHomens = 0, mulheresG = 0, maisNova = 200;
            double renda, pAnalfabetos, pGraduados, mediaIdade;
            while (cont < 2500)
            {
                Console.Write("Nome ou '0' para sair: ");
                nome = Console.ReadLine();
                if (nome == String.Empty)
                    break;
                Console.Write("IDade de entrevistado: ");
                idade = int.Parse(Console.ReadLine());
                Console.Write("Grau de Instrução: \n0 - Analfabeto\n1 - Fundamental\n2 - Ensino Médio\n4 - Graduação\nDigite de 0 a 4: ");
                instrucao = int.Parse(Console.ReadLine());
                Console.Write("Sexo (F ou M): ");
                sexo = Console.ReadLine().ToUpper();
                Console.Write("Renda Mensal: ");
                renda = double.Parse(Console.ReadLine());

                if (instrucao == 0)
                    analfabetos++;

                if (sexo == "M")
                {
                    contHomens++;
                    if (instrucao == 0)
                    {
                        soma += idade;
                        contHA++;
                    }
                    if (instrucao == 4)
                        homensG++;
                }
                if (sexo == "F" && renda >= 3200 && instrucao != 4)
                    mulheresG++;

                if (sexo == "F" && instrucao == 4 && idade < maisNova)
                {
                    maisNova = idade;
                    nomeNova = nome;
                }
                cont++; 
            }
            pAnalfabetos = analfabetos * 100 / (double)cont;
            mediaIdade = soma / (double)contHA;
            pGraduados = homensG * 100 / contHomens;

            Console.Write($"(A) & de Analfabetos: {pAnalfabetos}" +
                $"\n(B) Média idade de homens analfabetos: {mediaIdade} " +
                $"\n(C) % de Homens graduados: {pGraduados}" +
                $"\n(D) Mulheres, renda > 3200 e não graduadas: {mulheresG}" +
                $"\n(E) Mulher mais nova: {nomeNova} - {maisNova} anos");
            Console.ReadKey();
        }
    }
}
