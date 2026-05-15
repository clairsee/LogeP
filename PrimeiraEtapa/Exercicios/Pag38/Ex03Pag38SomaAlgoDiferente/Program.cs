using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03Pag38SomaAlgoDiferente
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, result;
            Console.Write("Digite o primeiro Número: ");
            num1 = int.Parse(Console.ReadLine());

            Console.Write("Digite o segundo Número: ");
            num2 = int.Parse(Console.ReadLine());

            Console.Clear();

            result = num1 + num2;

            if (result > 20)
            {
                result = result + 8;
                Console.Write($"O Resultado foi maior que vinte, logo foi somado 8 a ele\nO valor agora é de {result}");
            }
            else if (result <= 20)
            {
                result = result - 5;
                Console.Write($"O Resultado foi menor ou igual a vinte, logo foi subtraído 5 a ele\nO valor agora é de {result}");
            }
            Console.ReadKey();
        }
    }
}
