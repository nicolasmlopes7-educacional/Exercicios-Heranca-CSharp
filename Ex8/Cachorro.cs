
namespace ExercicioHerancaCSharp.Ex8
{
    public class Cachorro : Animal
    {
        public string? Latido { get; set; }
        public Cachorro(string nome, string latido) : base(nome)
        {
            Latido = latido;
        }

        public override void EmitirSom()
        {
            Console.WriteLine($"O som é: {Latido}.");
        }
    }
}