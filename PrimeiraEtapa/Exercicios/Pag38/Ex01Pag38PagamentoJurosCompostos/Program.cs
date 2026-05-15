using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex01Pag38PagamentoJurosCompostos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double price, entryPrice, monthFee, capital, priceFee, finalPrice = 0.0;
            int timeMonth, num=0;
            Console.Write("Qual o valor total do Veículo: ");
            price = double.Parse(Console.ReadLine());
            Console.Write("Qual o valor de entrada: ");
            entryPrice = double.Parse(Console.ReadLine());
            Console.Write("Qual a taxa mensal de juros: ");
            monthFee = int.Parse(Console.ReadLine());
            monthFee = monthFee / 100;
            Console.Write("Qual o tempo de financiamento (Em meses): ");
            timeMonth = int.Parse(Console.ReadLine());
            Console.Clear();

            capital = (price - entryPrice)/timeMonth;

            Console.WriteLine($"Com a entrada de R${entryPrice}\nCada mês será pago: ");

            while (num < timeMonth)
            {
                num = num+1;
                priceFee = capital * Math.Pow((1 + monthFee), num);
                Console.WriteLine($"{num}º Mês - R${priceFee}");
                finalPrice = priceFee + finalPrice;
            }
            Console.WriteLine($"O preço final será de R${finalPrice} mais a entrada de R${entryPrice}");
            Console.ReadKey();
        }
    }
}
