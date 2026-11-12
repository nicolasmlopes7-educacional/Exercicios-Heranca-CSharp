namespace ExercicioHerancaCSharp.Ex8
{
    public class Gato : Animal
    {
        public string? Miado { get; set; }
        public Gato(string nome, string miado) : base(nome)
        {
            Miado = miado;
        }

        public override void EmitirSom()
        {
            Console.WriteLine($"O som é: {Miado}.");
        }
    }
}