namespace ExercicioHerancaCSharp
{
    public class JogoFisico : Jogo
    {
        public int QuantidadeCd { get; set; }
        public JogoFisico(string nome, string plataforma, int quantidadeCd) : base(nome, plataforma)
        {
            QuantidadeCd = quantidadeCd;
        }
        public override void ExibirInformacoes()
        {
            Console.WriteLine($"O jogo: {Nome} é da plataforma {Plataforma} e a quantidade de Cd(s) é {QuantidadeCd}.");
        }
    }
}