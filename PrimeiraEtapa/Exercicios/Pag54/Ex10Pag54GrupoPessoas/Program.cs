using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex10Pag54GrupoPessoas
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int mulMais18 = 0, somaIdHom = 0, mulheres20a29 = 0, homens = 0, total = 0;
            double mediaIdHom = 0, porMulheres20a29 = 0;
            while (true)
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

                do {
                    Console.Write("Sexo (F/M): ");
                    char sexo = char.Parse(Console.ReadLine().ToUpper());
                    Console.Clear();
                    if (sexo != 'F' && sexo != 'M')
                    {
                        Console.Write("Escolha F ou M\n");
                    }
                } while (sexo != 'F' && sexo != 'M')

                total += 1;

                if (sexo == 'F')
                {
                    if (idade > 18)
                    {
                        mulMais18 += 1;
                    }
                    
                    if (idade > 20 && idade < 29)
                    {
                        mulheres20a29 += 1;
                    }
                } else
                {
                    homens += 1;
                    somaIdHom += idade;
                }
            }
            mediaIdHom = somaIdHom / homens;
            porMulheres20a29 = (mulheres20a29 * 100) / total;

            Console.WriteLine($"Número de Mulheres com mais de 18 anos: {mulMais18}");
            Console.WriteLine($"Média idade Homens: {mediaIdHom}");
            Console.WriteLine($"Porcentagem de Mulheres que têm entre 20 a 29 Anos: {porMulheres20a29}");
            Console.ReadKey();
        }
    }
}
