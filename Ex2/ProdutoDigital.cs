namespace ExercicioHerancaCSharp
{
    public abstract class ProdutoDigital
    {
        public string? Nome { get; set; }
        public decimal? Preco { get; set; }

        public ProdutoDigital(string nome, decimal preco)
        {
            Nome = nome;
            Preco = preco;
        }
        public virtual void ExibirInformacoes()
        {
            Console.WriteLine($"O produto {Nome} custa {Preco:C}.");
        }
    }
}