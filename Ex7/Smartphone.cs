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
            Console.WriteLine($"O smartphone: {Modelo}, o número de série é: {NumeroSerie} e possue {Armazenamento}GB de armazenamento.");
        }
    }
}