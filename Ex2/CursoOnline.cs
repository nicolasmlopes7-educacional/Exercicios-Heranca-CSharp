namespace ExercicioHerancaCSharp
{
    public class CursoOnline : ProdutoDigital
    {
        public int? CargaHoraria { get; set; }

        public CursoOnline(string nome, decimal preco, int cargaHoraria) : base(nome, preco)
        {
            CargaHoraria = cargaHoraria;
        }

        public override void ExibirInformacoes()
        {
            Console.WriteLine($"O curso: {Nome}, custa {Preco:C} e possue {CargaHoraria} horas de carga horaria.");
        }
    }
}