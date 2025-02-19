namespace GeradorTabuada
{
    using System;

    class Program
    {
        static void Main()
        {
            while (true)
            {
                Console.Write("Digite um número inteiro para gerar a tabuada: ");
                int numero;
                while (!int.TryParse(Console.ReadLine(), out numero))
                {
                    Console.Write("Entrada inválida. Digite um número inteiro: ");
                }

                Console.WriteLine($"\nTabuada do {numero}:");
                for (int i = 1; i <= 10; i++)
                {
                    Console.WriteLine($"{numero} x {i} = {numero * i}");
                }

                Console.Write("\nDeseja gerar outra tabuada? (S/N): ");
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