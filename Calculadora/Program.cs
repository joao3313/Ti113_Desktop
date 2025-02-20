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
                Console.WriteLine("5 - Potenciação");
                Console.WriteLine("6 - Radiciação");
                Console.WriteLine("7 - Sair");
                Console.Write("Escolha uma opção: ");

                int opcao;
                while (!int.TryParse(Console.ReadLine(), out opcao) || opcao < 1 || opcao > 7)
                {
                    Console.Write("Opção inválida. Escolha novamente: ");
                }

                if (opcao == 7)
                {
                    Console.WriteLine("Saindo da calculadora...");
                    break;
                }

                Console.Write("Digite o primeiro número: ");
                double num1;
                while (!double.TryParse(Console.ReadLine(), out num1))
                {
                    Console.Write("Valor inválido. Digite novamente: ");
                }

                double num2 = 0;
                if (opcao != 6)
                {
                    Console.Write("Digite o segundo número: ");
                    while (!double.TryParse(Console.ReadLine(), out num2) || (opcao == 4 && num2 == 0))
                    {
                        Console.Write("Valor inválido ou divisão por zero. Digite novamente: ");
                    }
                }

                double resultado = 0;

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
                    case 5:
                        resultado = Math.Pow(num1, num2);
                        break;
                    case 6:
                        if (num1 < 0)
                        {
                            Console.WriteLine("Não é possível calcular a raiz de um número negativo.");
                            continue;
                        }
                        resultado = Math.Sqrt(num1);
                        break;
                }

                Console.WriteLine($"O resultado da operação é: {resultado:F2}\n");

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