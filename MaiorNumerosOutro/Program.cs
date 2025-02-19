namespace MaiorNumerosOutro
{
    using System;

    class Program
    {
        static void Main()
        {
            // Solicita três números ao usuário
            Console.Write("Digite o primeiro número: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o segundo número: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o terceiro número: ");
            double num3 = Convert.ToDouble(Console.ReadLine());

            // Determina o maior número
            double maior = num1;

            if (num2 > maior)
            {
                maior = num2;
            }
            if (num3 > maior)
            {
                maior = num3;
            }

            // Exibe o maior número
            Console.WriteLine($"O maior número é: {maior}");
        }
    }
}