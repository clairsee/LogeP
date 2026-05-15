using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex12Pag38HorarioOutraForma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int segundos, hora = 0, minuto = 0;

            do
            {
                Console.Write("Digite um valor em Segundos: ");
                segundos = int.Parse(Console.ReadLine());

                hora = segundos / 3600;
                minuto = (segundos % 3600) / 60;
                segundos = segundos % 60;

                Console.Write($"{hora.ToString("00")}:{minuto.ToString("00")}:{segundos.ToString("00")}");
                Console.ReadKey();
                Console.Clear();
            } while (segundos != 0);
        }
    }
}
