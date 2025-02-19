namespace Calculadora
{
    using System;

    class Program
    {
        static void Main()
        {
            while (true)
            {
                Console.WriteLine("Calculadora Simples");
                Console.WriteLine("1 - Adição");
                Console.WriteLine("2 - Subtração");
                Console.WriteLine("3 - Multiplicação");
                Console.WriteLine("4 - Divisão");
                Console.WriteLine("5 - Sair");
                Console.Write("Escolha uma opção: ");

                int opcao;
                while (!int.TryParse(Console.ReadLine(), out opcao) || opcao < 1 || opcao > 5)
                {
                    Console.Write("Opção inválida. Escolha novamente: ");
                }

                if (opcao == 5)
                {
                    Console.WriteLine("Saindo da calculadora...");
                    break;
                }

                Console.Write("Digite o primeiro número: ");
                decimal num1;
                while (!decimal.TryParse(Console.ReadLine(), out num1))
                {
                    Console.Write("Valor inválido. Digite novamente: ");
                }

                Console.Write("Digite o segundo número: ");
                decimal num2;
                while (!decimal.TryParse(Console.ReadLine(), out num2) || (opcao == 4 && num2 == 0))
                {
                    Console.Write("Valor inválido ou divisão por zero. Digite novamente: ");
                }

                decimal resultado = 0;

                switch (opcao)
                {
                    case 1:
                        resultado = num1 + num2;
                        break;
                    case 2:
                        resultado = num1 - num2;
                        break;
                    case 3:
                        resultado = num1 * num2;
                        break;
                    case 4:
                        resultado = num1 / num2;
                        break;
                }

                Console.WriteLine($"O resultado da operação é: {resultado:F0}\n");

                Console.Write("Deseja continuar? (S/N): ");
                string resposta = Console.ReadLine().Trim().ToUpper();
                if (resposta != "S")
                {
                    Console.WriteLine("Encerrando a calculadora...");
                    break;
                }
            }
        }
    }

}