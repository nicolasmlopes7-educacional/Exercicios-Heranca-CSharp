namespace ExercicioHerancaCSharp
{
    public class Ebook : ProdutoDigital
    {
        public int? QuantidadePaginas { get; set; }
        public Ebook()
        {
        }

        public Ebook(string nome, decimal preco, int quantidadePaginas) : base(nome, preco)
        {
            QuantidadePaginas = quantidadePaginas;
        }

    }
}