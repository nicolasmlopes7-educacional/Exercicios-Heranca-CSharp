namespace ExercicioHerancaCSharp
{
    public class Motocicleta : Veiculo
    {
        public int? Cilindradas { get; set; }
        public Motocicleta(string modelo, string marca, int cilindradas) : base(modelo, marca)
        {
            Cilindradas = cilindradas;
        }
        public override void ExibirInformacoes()
        {
            Console.WriteLine($"O veiculo é um(a) {Modelo} da marca {Marca} e possui {Cilindradas}c.");
        }
    }
}