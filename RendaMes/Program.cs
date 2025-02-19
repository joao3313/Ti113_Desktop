namespace RendaMes
{
    using System;

    class Program
    {
        static void Main()
        {
            // Solicita o nome do usuário
            Console.Write("Digite seu nome: ");
            string nome = Console.ReadLine();

            // Solicita o valor ganho por hora
            Console.Write("Digite quanto você ganha por hora: ");
            double valorHora = Convert.ToDouble(Console.ReadLine());

            // Solicita o número de horas trabalhadas no mês
            Console.Write("Digite o número de horas trabalhadas no mês: ");
            double horasTrabalhadas = Convert.ToDouble(Console.ReadLine());

            // Calcula a renda total no mês
            double rendaMensal = valorHora * horasTrabalhadas;

            // Exibe o nome e a renda total
            Console.WriteLine($"\n{nome}, sua renda mensal é: R$ {rendaMensal:F2}");
        }
    }
}