namespace ExercicioHerancaCSharp.Ex7
{
    public class Smartphone : Equipamento
    {
        public int Armazenamento { get; set; }

        public Smartphone(string modelo, int numerodeSerie, int armazenamento) : base(modelo, numerodeSerie)
        {
            Armazenamento = armazenamento;
        }
        public override void ExibirInformacoes()
        {
            base.ExibirInformacoes();
            Console.WriteLine($" E possue {Armazenamento}GB de armazenamento.");
        }
    }
}