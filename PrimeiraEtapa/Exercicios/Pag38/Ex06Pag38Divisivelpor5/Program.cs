using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex06Pag38Divisivelpor5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.Write("Escrvea um número: ");
            num = int.Parse(Console.ReadLine());

            if (num % 5 == 0)
            {
                Console.Write("O número digitado é divisível por 5");
            }
            else
            {
                Console.Write("O número digitado não é divisível por 5");
            }
            Console.ReadKey();
        }
    }
}
