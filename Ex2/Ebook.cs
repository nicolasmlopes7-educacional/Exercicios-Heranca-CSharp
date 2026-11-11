namespace ExercicioHerancaCSharp
{
    public class Ebook : ProdutoDigital
    {
        public int? QuantidadePaginas { get; set; }

        public Ebook(string nome, decimal preco, int quantidadePaginas) : base(nome, preco)
        {
            QuantidadePaginas = quantidadePaginas;
        }

        public override void ExibirInformacoes()
        {
            Console.WriteLine($"O produto: {Nome}, custa {Preco:C} e possue {QuantidadePaginas} páginas.");
        }
    }
}