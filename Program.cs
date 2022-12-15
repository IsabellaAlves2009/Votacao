using System;

namespace Votacao
{
    class Program
    {
        static Pessoa[] pessoas = Pessoas();

        static void Main(string[] args)
        {
            var opcao = "n";

            //ToLower - mudar o texto para minusculo
            while (opcao?.ToLower() == "n")
            {
                Console.Clear();
                Console.WriteLine("Escolha seu canditado a votação");

                // Length retorna a quantidade de itens no array
                // for(var i = 0; i < pessoas.Length; i++)
                // {
                //     pessoas[i].Imprimir();
                // }

                foreach (var p in pessoas)
                {
                    p.Imprimir();
                }


                int num = int.Parse(Console.ReadLine());
                Votar(num - 1);

                Console.WriteLine("\n");
                Console.WriteLine("deseja finalizar a votação? s/n");
                opcao = Console.ReadLine();
            }

            Console.WriteLine("\n");
            Console.WriteLine("======TOTAL=DE=VOTOS======");
            foreach (var p in pessoas)
            {
                p.ImprimirVotos();
            }
            Console.WriteLine("==========================");
        }

        static void Votar(int num)
        {
            Console.WriteLine("Você votou em: " + pessoas[num].Nome);
            pessoas[num].Votos += 1;
        }

        static Pessoa[] Pessoas()
        {
            return new Pessoa[]
            {
                new Pessoa(1, "João"),
                new Pessoa(2, "Maria"),
                new Pessoa(3, "José"),
                new Pessoa(4, "Rosa"),
            };
        }
    }
}
