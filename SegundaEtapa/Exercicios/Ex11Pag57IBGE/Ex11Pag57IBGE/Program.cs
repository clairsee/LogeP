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
                Console.Write("Nome ou tecle ENTER para sair: ");
                nome = Console.ReadLine();
                Console.Clear();
                
                if (nome == String.Empty) // Utilização do 'String.Empty' (Pode ser apenas "") para execução de saída
                    break;

                Console.Write("Idade de entrevistado: ");
                idade = int.Parse(Console.ReadLine());
                Console.Clear();

                do { // Utilização do 'Do While' para impedir a digitação de números não entre 0 a 4
                    Console.Write("Grau de Instrução: \n0 - Analfabeto\n1 - Fundamental\n2 - Ensino Médio\n4 - Graduação\nDigite de 0 a 4: ");
                    instrucao = int.Parse(Console.ReadLine());
                    Console.Clear();
                    if (instrucao < 0 || instrucao > 4)
                        Console.Write("Digite um valor de instrução válido\n\n");
                } while (instrucao < 0 || instrucao > 4);


                do
                { // Utilização do 'Do While' para impedir a digitação de caracteres fora de F e M
                    Console.Write("Sexo (F ou M): ");
                    sexo = Console.ReadLine().ToUpper();
                    Console.Clear();
                    if (sexo != "F" && sexo != "M")
                        Console.Write("Insira um sexo válido ao programa\n\n");
                } while (sexo != "F" && sexo != "M");

                Console.Write("Renda Mensal: ");
                renda = double.Parse(Console.ReadLine());
                Console.Clear();

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

            Console.Clear();

            if (cont > 0) // Impedindo a execução quando não houve execução
            {
                pAnalfabetos = analfabetos * 100 / (double)cont;
                mediaIdade = soma / (double)contHA;
                pGraduados = homensG * 100 / contHomens;

                Console.Write($"(A) & de Analfabetos: {pAnalfabetos}" +
                    $"\n(B) Média idade de homens analfabetos: {mediaIdade} " +
                    $"\n(C) % de Homens graduados: {pGraduados}" +
                    $"\n(D) Mulheres, renda > 3200 e não graduadas: {mulheresG}" +
                    $"\n(E) Mulher mais nova: {nomeNova} - {maisNova} anos");
            }
            else // Se não houve execução, executar esse bloco
                Console.Write("\nObrigado por usar o programa!");
            Console.ReadKey();
        }
    }
}
