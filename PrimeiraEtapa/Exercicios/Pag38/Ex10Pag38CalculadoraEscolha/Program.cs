using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex10Pag38CalculadoraEscolha
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2 escolha;
            double result;
            Console.Write("Primeiro número para a conta: ");
            num1 = int.Parse(Console.ReadLine());
            Console.Write("Segundo número para a conta: ");
            num2 = int.Parse(Console.ReadLine());

            Console.Clear();

            do {
                Console.Write("Escolha uma das opções\n1 - Soma\n2 - Subtração\n3 - Multiplicação\n4 - Divisão\nEscolha: ");
                escolha = int.Parse(Console.ReadLine());
                Console.Clear();
                if (escolha == 4 && num2 == 0) { Console.WriteLine("Não existe divisão por 0"); }
            } while (escolha == 4 && num2 == 0);

            switch (escolha)
            {
                case 1:
                    result = num1 + num2;
                    Console.Write($"{num1} + {num2} = {result}");
                    break;
                case 2:
                    result = num1 - num2;
                    Console.Write($"{num1} - {num2} = {result}");
                    break;
                case 3:
                    result = num1 * num2;
                    Console.Write($"{num1} * {num2} = {result}");
                    break;
                case 4:
                    result = (double)num1 / num2;
                    Console.Write($"{num1} / {num2} = {result}");
                    break;
            }
            Console.ReadKey(); 
        }
    }
}
