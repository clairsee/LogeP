using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex09Pag54VariosValores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int digitados = 0, somaValor = 0, maior = int.MinValue, menor = int.MaxValue, valor0 = 0, valorNegativo = 0, mediaValor = 0 ;
            double zeroPorc = 0;

            while (true)
            {
                Console.Write("Para sair, digite '-1'\nDigite um valor inteiro: ");
                int valor = int.Parse(Console.ReadLine());

                Console.Clear();

                if (valor == -1)
                    break;

                digitados += 1;

                somaValor += valor;

                if (valor > maior)
                    maior = valor;

                if (valor < menor)
                    menor = valor;

                if (valor == 0)
                    valor0 += 1;
                else if (valor < 0)
                    valorNegativo += 1;
            }

            if (digitados > 0)
            {
                zeroPorc = (valor0 * 100) / digitados;
                mediaValor = somaValor / digitados;
                Console.WriteLine($"A Soma total é: {somaValor}" +
                    $"\nO valor do Maior é: {maior}" +
                    $"\nO valor do Menor é: {menor}" +
                    $"\nA Média dos valores é: {mediaValor}" +
                    $"\nPorcentual de Zeros digitados: {zeroPorc}%" +
                    $"\nQuantidade de Números Negativos: {valorNegativo}");
            }
            else
                Console.Write("Obrigado por usar o programa!");
            Console.ReadKey();
        }
    }
}
