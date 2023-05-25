using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public static class Questao01
    {
        public static void Executar()
        {

            {
                Console.WriteLine("Digite a base do retângulo:");
                double b = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Digite a altura do retângulo:");
                double h = Convert.ToDouble(Console.ReadLine());

                double perimetro = 2 * (b + h);
                double area = b * h;
                double diagonal = Math.Sqrt(Math.Pow(b, 2) + Math.Pow(h, 2));

                Console.WriteLine("Perímetro: " + perimetro);
                Console.WriteLine("Área: " + area);
                Console.WriteLine("Diagonal: " + diagonal);
                //*Utilizei a função Convert.ToDouble() para converter as strings lidas do console em número flutuante no caso (double);Utilizei a função Math.Sqrt() para conseguir calcular a raiz quadrada. E a função Math.Pow() para calcular a potência.
            }
        }
    }
}



