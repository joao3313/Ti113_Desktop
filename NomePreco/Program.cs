namespace NomePreco
{
    using System;

    class Program
    {
        static void Main()
        {
            string[] nomes = new string[6];
            double[] precos = new double[6];

            for (int i = 0; i < 6; i++)
            {
                Console.Write($"Digite o nome do produto {i + 1}: ");
                nomes[i] = Console.ReadLine();

                Console.Write($"Digite o preço do produto {i + 1}: ");
                while (!double.TryParse(Console.ReadLine(), out precos[i]) || precos[i] < 0)
                {
                    Console.Write("Preço inválido. Digite novamente: ");
                }
            }

            // Exibir o nome do último produto inserido
            Console.WriteLine($"\nO último produto inserido foi: {nomes[5]}");

            // Encontrar o produto mais barato
            int indiceMaisBarato = 0;
            for (int i = 1; i < 6; i++)
            {
                if (precos[i] < precos[indiceMaisBarato])
                {
                    indiceMaisBarato = i;
                }
            }

            Console.WriteLine($"O produto mais barato é: {nomes[indiceMaisBarato]} - R$ {precos[indiceMaisBarato]:F2}");
        }
    }
}