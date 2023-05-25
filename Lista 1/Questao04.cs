using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1 
{
    public static class Questao04
    {
        public static void Executar()
        {
            // Entrada de dados: coordenadas dos pontos P1 e P2
            Console.Write("Digite as coordenadas do ponto P1 (x1,y1): ");
            string[] p1 = Console.ReadLine().Split(',');
            double x1 = double.Parse(p1[0]);
            double y1 = double.Parse(p1[1]);

            Console.Write("Digite as coordenadas do ponto P2 (x2,y2): ");
            string[] p2 = Console.ReadLine().Split(',');
            double x2 = double.Parse(p2[0]);
            double y2 = double.Parse(p2[1]);

            // Cálculo da distância entre os pontos
            double distancia = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            Console.WriteLine($"A distância entre os pontos P1({x1},{y1}) e P2({x2},{y2}) é: {distancia}");
        }

    }
    }
