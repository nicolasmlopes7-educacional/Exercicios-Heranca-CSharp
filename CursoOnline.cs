namespace ExercicioHerancaCSharp
{
    public class CursoOnline : ProdutoDigital
    {
        public int? CargaHoraria { get; set; }
        public CursoOnline()
        {
        }

        public CursoOnline(string nome, decimal preco, int cargaHoraria) : base(nome, preco)
        {
            CargaHoraria = cargaHoraria;
        }

    }
}