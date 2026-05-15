using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex08Pag38SalarioeIdadeHomemMulher
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nome;
            int idade;
            double salario;
            char sexo;

            Console.Write("Qual seu nome: ");
            nome = Console.ReadLine();
            Console.Clear();
            Console.Write("Qual sua idade: ");
            idade = int.Parse(Console.ReadLine());
            Console.Clear();
            Console.Write("Qual seu salário: ");
            salario = double.Parse(Console.ReadLine());
            Console.Clear();
            do
            {
                Console.Write("Qual seu Sexo (M/F): ");
                sexo = char.Parse(Console.ReadLine().ToUpper());
                Console.Clear();
                if (sexo != 'F' && sexo != 'M') { Console.WriteLine("Digite de forma correta"); }
            } while (sexo != 'F' && sexo != 'M');

            if (sexo == 'F')
            {
                Console.Write($"Seu salário é de R${salario}");
            }
            else
            {
                Console.Write($"Sua idade é {idade} anos");
            }
            Console.ReadKey();  
        }
    }
}
