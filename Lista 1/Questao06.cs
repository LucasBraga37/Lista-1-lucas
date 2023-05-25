using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public static class Questao06
    {
        public static void Executar()
        {
            Console.Write("Digite o valor de A: ");
            double A = double.Parse(Console.ReadLine());

            Console.Write("Digite o valor de B: ");
            double B = double.Parse(Console.ReadLine());

            // Troca dos valores: utilização de uma variável auxiliar
            double auxiliar = A;
            A = B;
            B = auxiliar;

            Console.WriteLine("Os valores trocados são:" + A + " e " + B);

        }
    }
}