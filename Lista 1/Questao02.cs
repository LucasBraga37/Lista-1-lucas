using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public static class Questao02
    {
        public static void Executar()
        {
            Console.WriteLine("Digite o valor do cateto oposto:");
            double catetoOposto = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o valor do cateto adjacente:");
            double catetoAdjacente = Convert.ToDouble(Console.ReadLine());

            double hipotenusa = Math.Sqrt(Math.Pow(catetoOposto, 2) + Math.Pow(catetoAdjacente, 2));

            Console.WriteLine("A hipotenusa é: " + hipotenusa);

        }
    }
}
