namespace ExercicioHerancaCSharp
{
    public abstract class ProdutoDigital
    {
        public string? Nome { get; set; }
        public decimal? Preco { get; set; }

        public ProdutoDigital()
        {
            
        }
        public ProdutoDigital(string nome, decimal preco)
        {
            Nome = nome;
            Preco = preco;
        }
    }
}