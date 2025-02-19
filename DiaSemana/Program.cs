namespace DiaSemana
{

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe um número de 1 a 7 para exibir o Dia da Semana");
            string opcao = Console.ReadLine()!;

            switch (opcao)
            {
                case "1":
                    Console.WriteLine("Domingo");
                    break;
                case "2":
                    Console.WriteLine("Segunda-feira");
                    break;
                case "3":
                    Console.WriteLine("Terça-feira");
                    break;
                case "4":
                    Console.WriteLine("Quarta-feira");
                    break;
                case "5":
                    Console.WriteLine("Quinta-feira");
                    break;
                case "6":
                    Console.WriteLine("Sexta-feira");
                    break;
                case "7":
                    Console.WriteLine("Sábado");
                    break;
                default:
                    Console.WriteLine("Dia Inválido");
                    break;
            }



        }
    }
}