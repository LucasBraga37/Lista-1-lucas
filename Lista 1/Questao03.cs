using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public static class Questao03
    {
        public static void Executar()
        {
            Console.Write("Digite o valor do salário mínimo: ");
            double salarioMinimo = double.Parse(Console.ReadLine());

            Console.Write("Digite a quantidade de kilowatt gasta na residência: ");
            double kilowatt = double.Parse(Console.ReadLine());

            double valoremKilowatt = salarioMinimo / 7 / 100;

            double valorKilowatt = 0;
            double valorAPagar = kilowatt * valorKilowatt;
            Console.WriteLine("Valor em reais a ser pago: R$ " + valorAPagar.ToString("F2"));

            double valorComDesconto = valorAPagar * 0.9;
            Console.WriteLine("Valor com desconto de 10%: R$ " + valorComDesconto.ToString("F2"));

        }
    }
}
