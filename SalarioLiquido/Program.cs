namespace SalarioLiquido
{
    using System;

    class Program
    {
        static void Main()
        {
            const decimal descontoINSS = 0.12m;

            while (true)
            {
                decimal[] salariosBrutos = new decimal[5];
                decimal[] salariosLiquidos = new decimal[5];

                for (int i = 0; i < 5; i++)
                {
                    Console.Write($"Digite o salário bruto da pessoa {i + 1}: ");
                    while (!decimal.TryParse(Console.ReadLine(), out salariosBrutos[i]) || salariosBrutos[i] < 0)
                    {
                        Console.Write("Entrada inválida. Digite um valor válido para o salário bruto: ");
                    }
                    salariosLiquidos[i] = salariosBrutos[i] * (1 - descontoINSS);
                }

                Console.WriteLine("\nSalários líquidos:");
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine($"Pessoa {i + 1}: Salário Líquido = {salariosLiquidos[i]:C2}");
                }

                Console.Write("\nDeseja calcular novamente? (S/N): ");
                string resposta = Console.ReadLine().Trim().ToUpper();
                if (resposta != "S")
                {
                    Console.WriteLine("Encerrando o programa...");
                    break;
                }
            }
        }
    }
}