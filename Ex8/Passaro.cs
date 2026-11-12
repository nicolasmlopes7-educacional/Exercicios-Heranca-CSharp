namespace ExercicioHerancaCSharp.Ex8
{
    public class Passaro : Animal
    {
        public string? Canto { get; set; }
        public Passaro(string nome, string canto) : base(nome)
        {
            Canto = canto;
        }

        public override void EmitirSom()
        {
            Console.WriteLine($"O som é: {Canto}.");
        }
    }
}