namespace NomeSenha
{
    using System;

    class Program
    {
        static void Main()
        {
            string usuario, senha;

            while (true)
            {
                Console.Write("Digite o nome de usuário: ");
                usuario = Console.ReadLine();

                Console.Write("Digite a senha: ");
                senha = Console.ReadLine();

                if (senha.Equals(usuario, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("Erro: A senha não pode ser igual ao nome de usuário. Tente novamente.\n");
                }
                else
                {
                    Console.WriteLine("Usuário e senha cadastrados com sucesso!");
                    break;
                }
            }
        }
    }
}