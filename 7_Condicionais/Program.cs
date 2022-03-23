// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

namespace _7_Condicionais
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando Projeto 7 - Condicionais");

            int idadeJoao = 16;
            int quantidadePessoas = 2;

            if (idadeJoao >= 18)
            {
                Console.WriteLine("Joao possui mais de 18 anos de idade. Pode entrar.");
            }
            else
            {
                if (quantidadePessoas >= 2)
                {
                    Console.WriteLine("Joao nao possui mais de 18 anos de idade, mas esta acompanhado. Pode entrar.");
                }
                else
                {
                    Console.WriteLine("Joao nao possui mais de 18 anos de idade. Nao pode entrar.");
                }
               

            }

            Console.ReadLine();
        }
    }
}