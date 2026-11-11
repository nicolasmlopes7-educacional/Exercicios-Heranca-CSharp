namespace ExercicioHerancaCSharp
{
    public class JogoDigital : Jogo
    {
        public int? CodigoVerificacao { get; set; }
        public JogoDigital(string nome, string plataforma, int codigoverificacao) : base(nome, plataforma)
        {
            CodigoVerificacao = codigoverificacao;
        }
        public override void ExibirInformacoes()
        {
            Console.WriteLine($"O jogo: {Nome} é da plataforma {Plataforma} e o código de verificação é {CodigoVerificacao}.");
        }
    }
}