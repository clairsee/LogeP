using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex05Pag54EntrevistaPessoas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int entrevista = 0, mul = 0, hom = 0;
            double homPorc = 0, mulPorc = 0, homCasRenda = double.MaxValue, mulSolRenda = double.MinValue, somaSal30a40 = 0, mediaSal30a40 = 0, pessoasSal30a40 = 0, mulSol25 = 0; 

            while(true)
            {
                Console.Write("Para sair, digite 0\nSua Idade: ");
                int idade = int.Parse(Console.ReadLine());

                Console.Clear();

                if (idade == 0)
                {
                    break;
                }

                Console.Write("Seu Nome: ");
                string nome = Console.ReadLine();

                Console.Clear();

                Console.Write("Sexo (F/M): ");
                char sexo = char.Parse(Console.ReadLine().ToUpper());

                Console.Clear();

                if (sexo != 'F' && sexo != 'M')
                {
                    Console.Write("Escolha F ou M\n");
                    continue;
                } else if (sexo == 'F')
                {
                    mul += 1;
                } else if (sexo == 'M')
                {
                    hom += 1;
                }

                Console.Write("Estado Civil\n1 - Casado\n2 - Solteiro\nOpção: ");
                int estadoCivil = int.Parse(Console.ReadLine());

                Console.Clear();

                switch (estadoCivil)
                {
                    case 1:
                        break;
                    case 2:
                        break;
                    default:
                        Console.Write("Escolha um valor Válido entre Casado e Solteiro\n");
                        continue;
                }

                Console.Write("Renda Mensal: ");
                double renda = double.Parse(Console.ReadLine());

                Console.Clear();

                entrevista += 1;

                if (sexo == 'M' && estadoCivil == 1 && renda < homCasRenda)
                {
                    homCasRenda = renda;
                }

                if (sexo == 'F' && estadoCivil == 2 && renda > mulSolRenda)
                {
                    mulSolRenda = renda;
                }

                if (idade > 30 && idade < 40)
                {
                    pessoasSal30a40 += 1;
                    somaSal30a40 += renda;
                }
                
                if (sexo == 'F' && estadoCivil == 2 && idade < 25 && renda < 3200)
                {
                    mulSol25 += 1;
                }
            }
            mediaSal30a40 = somaSal30a40 / pessoasSal30a40;
            homPorc = (hom * 100) / entrevista;
            mulPorc = (mul * 100) / entrevista;

            Console.WriteLine($"Porcentagem de Homens: {homPorc}");
            Console.WriteLine($"Porcentagem de Mulheres: {mulPorc}");
            Console.WriteLine($"Menor renda entre os Homens Casados: R${homCasRenda}");
            Console.WriteLine($"Maior renda entre Mulheres Solteiras: R${mulSolRenda}");
            Console.WriteLine($"Renda média das pessoas com idade entre 30 a 40 anos: R${mediaSal30a40.ToString("0,00")}");
            Console.WriteLine($"Mulheres solteiras com idade inferior a 25 anos que ganham até R$3200: {mulSol25}");

            Console.ReadKey();
        }
    }
}
