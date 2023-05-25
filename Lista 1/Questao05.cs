using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
       public static class Questao05
    {
        public static void Executar()
        {
            // Entrada de dados: valor da aplicação mensal, taxa e número de meses
            Console.Write("Digite o valor da aplicação mensal: ");
            double p = double.Parse(Console.ReadLine());

            Console.Write("Digite a taxa de rendimento (em %): ");
            double i = double.Parse(Console.ReadLine()) / 100.0;

            Console.Write("Digite o número de meses da aplicação: ");
            int n = int.Parse(Console.ReadLine());

            // Cálculo do valor acumulado na poupança programada
            double valorAcumulado = p * ((Math.Pow(1 + i, n) - 1) / i);

            // Saída de dados: exibição do valor acumulado
            Console.WriteLine($"O valor acumulado na poupança programada é de: R$ {valorAcumulado:F2}");

        }
    }
}
