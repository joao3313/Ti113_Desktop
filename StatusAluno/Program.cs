namespace StatusAluno
{

    using System;

    class Program
    {
        static void Main()
        {
            while (true)
            {
                // Solicita o nome do aluno
                Console.Clear();
                Console.Write("Digite o seu nome: ");
                string nome = Console.ReadLine();

                // Solicita as duas notas
                Console.Write("Digite a primeira nota: ");
                double nota1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Digite a segunda nota: ");
                double nota2 = Convert.ToDouble(Console.ReadLine());

                // Calcula a média
                double media = (nota1 + nota2) / 2;

                // Exibe o nome e a situação do aluno com base na média
                Console.WriteLine($"\nAluno: {nome}");
                Console.WriteLine($"Média: {media:F2}");

                if (media >= 7)
                {
                    Console.WriteLine("Status: Aprovado");
                }
                else if (media >= 5)
                {
                    Console.WriteLine("Status: Recuperação");
                }
                else
                {
                    Console.WriteLine("Status: Reprovado");
                }

                // Pergunta ao usuário se deseja fazer uma nova verificação
                string resposta;
                do
                {
                    Console.Write("\nDeseja calcular novamente? (S para sim / N para não): ");
                    resposta = Console.ReadLine().ToUpper();

                    // Garante que a resposta seja "S" ou "N"
                    if (resposta != "S" && resposta != "N")
                    {
                        Console.WriteLine("Resposta inválida! Por favor, digite 'S' para sim ou 'N' para não.");
                    }

                } while (resposta != "S" && resposta != "N");

                // Se a resposta for "N", sai do loop e encerra o programa
                if (resposta == "N")
                {
                    break;
                }
            }

            Console.WriteLine("\nObrigado por usar o programa! Pressione qualquer tecla para sair.");
            Console.ReadKey();
        }
    }
}
