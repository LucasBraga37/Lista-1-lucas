using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public static class Questao07
    {
        public static void Executar()
        {
            Console.Write("Digite a quantidade de dias sem acidentes: ");
            int diasSemAcidentes = int.Parse(Console.ReadLine());

            // Cálculo dos anos, meses e dias sem acidentes respectivamente
            int anos = diasSemAcidentes / 365;
            int meses = (diasSemAcidentes % 365) / 30;
            int dias = (diasSemAcidentes % 365) % 30;

            // Saída de dados: exibição dos dias sem acidentes separados em anos, meses e dias
            Console.WriteLine($"Dias sem acidentes: {anos} ano(s), {meses} mês(es) e {dias} dia(s)");

        }
    }
}
