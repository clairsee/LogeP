using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04Pag54Salario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sal2545 = 0, salarioMin = 0, trabalhadores = 0;
            double somaSal = 0, mediaSal = 0, porcSal2545 = 0;

            while (true)
            {
                Console.Write("Para sair, digite 0\nQual seu Salário: ");
                double salario = double.Parse(Console.ReadLine());

                Console.Clear();

                if (salario == 0)
                { 
                    break;
                }

                trabalhadores += 1;

                if (salario >= 2500 && salario <= 4500) {
                    sal2545 += 1;
                }

                if (salario == 1621) {
                    salarioMin += 1;
                }

                somaSal += salario;
                mediaSal = salario / trabalhadores;
                porcSal2545 = (sal2545 * 100) / trabalhadores;
            }

            Console.WriteLine($"Trabalhadores que ganham Salário Mínimo: {salarioMin}");
            Console.WriteLine($"Valor gasto pela Empressa em Salário: R${somaSal}");
            Console.WriteLine($"Media Salarial: R${mediaSal.ToString("0.00")}");
            Console.WriteLine($"Porcentagem de Trabalhadores que ganham entre 2500 e 4500 Reais: {porcSal2545}%");
            Console.ReadKey();
        }
    }
}
