namespace ParesImpares
{
    using System;

    class Program
    {
        static void Main()
        {
            while (true)
            {
                int[] numeros = new int[20];
                int[] pares = new int[20];
                int[] impares = new int[20];
                int contPar = 0, contImpar = 0;

                for (int i = 0; i < 20; i++)
                {
                    Console.Write($"Digite o {i + 1}º número inteiro: ");
                    while (!int.TryParse(Console.ReadLine(), out numeros[i]))
                    {
                        Console.Write("Entrada inválida. Digite um número inteiro: ");
                    }

                    if (numeros[i] % 2 == 0)
                    {
                        pares[contPar++] = numeros[i];
                    }
                    else
                    {
                        impares[contImpar++] = numeros[i];
                    }
                }

                Console.WriteLine("\nVetor original:");
                Console.WriteLine(string.Join(", ", numeros));

                Console.WriteLine("\nNúmeros pares:");
                Console.WriteLine(string.Join(", ", pares[..contPar]));

                Console.WriteLine("\nNúmeros ímpares:");
                Console.WriteLine(string.Join(", ", impares[..contImpar]));

                Console.Write("\nDeseja continuar? (S/N): ");
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