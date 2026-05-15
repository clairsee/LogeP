using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04Pag32SeComDobroeTriplo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num;

            Console.Write("Digite um número: ");
            num = double.Parse(Console.ReadLine());
            Console.Clear();

            if (num > 0)
            {
                num = num * 2;
            }
            else 
            {
                num = num * 3;
            }

            Console.Write($"O número final será de {num}");
            Console.ReadKey();
        }
    }
}
