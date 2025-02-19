namespace MaiorNumero
{
    using System;

    class Program
    {
        static void Main()
        {
            // Solicita dois números ao usuário
            Console.Write("Digite o primeiro número: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o segundo número: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            // Verifica e imprime o maior número
            if (num1 > num2)
            {
                Console.WriteLine($"O maior número é: {num1}");
            }
            else if (num2 > num1)
            {
                Console.WriteLine($"O maior número é: {num2}");
            }
            else
            {
                Console.WriteLine("Os números são iguais.");
            }
        }
    }
}