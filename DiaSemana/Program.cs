namespace DiaSemana
{
    using System;

    class Program
    {
        static void Main()
        {
            while (true)
            {
                Console.Clear();
                Console.Write("Digite seu nome: ");
                string nome = Console.ReadLine()?.Trim();

                while (string.IsNullOrWhiteSpace(nome))
                {
                    Console.Write("Nome inválido. Digite seu nome: ");
                    nome = Console.ReadLine()?.Trim();
                }

                int numero;
                do
                {
                    Console.Write("Digite um número de 1 a 7: ");
                } while (!int.TryParse(Console.ReadLine(), out numero) || numero < 1 || numero > 7);

                string[] diasSemana = { "Domingo", "Segunda-feira", "Terça-feira", "Quarta-feira", "Quinta-feira", "Sexta-feira", "Sábado" };

                Console.WriteLine($"\nOlá {nome}, o dia correspondente ao número {numero} é {diasSemana[numero - 1]}.");

                string resposta;
                do
                {
                    Console.Write("\nDeseja continuar? (sim/nao): ");
                    resposta = Console.ReadLine().ToLower();

                    // Garante que a resposta seja "S" ou "N"
                    if (resposta != "S" && resposta != "N")
                    {
                        Console.WriteLine("Resposta inválida! Por favor, digite 'S' para sim ou 'N' para não.");
                    }

                } while (resposta != "s" && resposta != "n");



                if (resposta == "nao")
                {
                    Console.WriteLine("\nPrograma encerrado. Pressione qualquer tecla para sair...");
                    Console.ReadKey();
                    break;
                }
            }
        }
    }
}