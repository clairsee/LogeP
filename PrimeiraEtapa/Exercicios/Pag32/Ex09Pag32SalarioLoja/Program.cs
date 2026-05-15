using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Ex09Pag32SalarioLoja
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nomeVendedor;
            int pecasVendidas;
            double salarioFixo, comissaoVendedor, salarioBruto, valorInss, planoSaude, salarioLiquido;

            Console.Write("Qual o nome do Vendedor: ");
            nomeVendedor = Console.ReadLine();
            Console.Clear();

            Console.Write("Qual o Salário Fixo do mesmo: ");
            salarioFixo = double.Parse(Console.ReadLine());
            Console.Clear();

            Console.Write("Qual foi a quantidade de peças vendidas por ele: ");
            pecasVendidas = int.Parse(Console.ReadLine());
            Console.Clear();

            comissaoVendedor = pecasVendidas * 1.5;
            salarioBruto = salarioFixo + comissaoVendedor;
            valorInss = salarioBruto * 0.11;
            planoSaude = salarioBruto * 0.02;
            salarioLiquido = salarioBruto - valorInss - planoSaude;

            Console.WriteLine($"O vendedor {nomeVendedor} tem salário fixo de R${salarioFixo} e vendeu {pecasVendidas} peças");
            Console.WriteLine($"O salário bruto do mesmo é de R${salarioBruto}");
            Console.WriteLine($"A contribuição do INSS dele é de R${valorInss}");
            Console.WriteLine($"O desconto do plano de saúde é de R${planoSaude}");
            Console.WriteLine($"No final, ele ganha {salarioLiquido}");
            Console.ReadKey();
            
        }
    }
}
