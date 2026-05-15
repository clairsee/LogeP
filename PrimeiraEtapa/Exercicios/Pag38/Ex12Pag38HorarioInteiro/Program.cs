using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex12Pag38HorarioInteiro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int segundos, hora=0, minuto=0;

            do
            {
                minuto = 0;
                hora = 0;
                Console.Write("Digite um valor em Segundos: ");
                segundos = int.Parse(Console.ReadLine());

                while (segundos >= 60)
                {
                    minuto++;
                    segundos = segundos - 60;
                }
                while (minuto >= 60)
                {
                    hora++;
                    minuto = minuto - 60;
                }

                Console.Write($"{hora.ToString("00")}:{minuto.ToString("00")}:{segundos.ToString("00")}");
                Console.ReadKey();
                Console.Clear();
            } while (segundos != 0);
        }
    }
}
