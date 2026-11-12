namespace ExercicioHerancaCSharp.Ex7
{
    public class Notebook : Equipamento
    {
        public int MemoriaRam { get; set; }
        public Notebook(string modelo, int numerodeSerie, int memoriaram) : base(modelo, numerodeSerie)
        {
            MemoriaRam = memoriaram;
        }
        public override void ExibirInformacoes()
        {
            base.ExibirInformacoes();
            Console.WriteLine($" E possue {MemoriaRam}GB Ram.");
        }
    }
}