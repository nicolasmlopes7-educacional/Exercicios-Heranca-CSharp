namespace ExercicioHerancaCSharp
{
    public abstract class Jogo
    {
        public string? Nome { get; set; }
        protected string? Plataforma;

        public void ExibirInformacoes()
        {
            Console.WriteLine($"O jogo {Nome} é da plataforma: {Plataforma}.");
        }
    }
}