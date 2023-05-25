using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public static class Questao08
    {
        public static void Executar()
        {
            // Entrada de dados: leitura do número da conta corrente
            Console.Write("Digite o número da conta corrente (São 3 dígitos): ");
            int contaCorrente = int.Parse(Console.ReadLine());

            // Cálculo do dígito verificador
            int inverso = int.Parse(string.Join("", contaCorrente.ToString().Reverse()));
            int soma = contaCorrente + inverso;

        }
    }
}
