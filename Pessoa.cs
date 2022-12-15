namespace Votacao
{
    public class Pessoa
    {
        public Pessoa(int id, string nome)
        {
            Id = id;
            Nome = nome;
            Votos = 0;

            
        }

        public int Id { get; set; }
        public string Nome { get; set; }
        public int Votos { get; set; }
        

        public void Imprimir()
        {
            Console.WriteLine(Id + " - " + Nome);
        }

        public void ImprimirVotos()
        {
            Console.WriteLine(Id + " - " + Nome + " \t| Votos: " + Votos);
        }
    }
}
