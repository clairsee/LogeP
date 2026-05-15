using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex07Pag15FabricaCamisetas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pequena;
            int media;
            int grande;
            int valorfinal;
            Console.Write("Quantas camisetass Pequenas serão vendidas: ");
            pequena = int.Parse(Console.ReadLine());
            Console.Write("Quantas camisetas Médias serão vendidas: ");
            media = int.Parse(Console.ReadLine());
            Console.Write("Quantas camisetas Grandes serão vendidas: ");
            grande = int.Parse(Console.ReadLine());
            Console.Clear();
            valorfinal = (pequena*12) + (media*16) + (grande*22);
            Console.Write($"O valor arrecadado será de: R${valorfinal}");
            Console.ReadKey();
        }
    }
}
