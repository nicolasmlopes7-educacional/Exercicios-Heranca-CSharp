namespace ExercicioHerancaCSharp
{
    public class Carro : Veiculo
    {
        public int? QuantidadePortas { get; set; }
        public Carro(string modelo, string marca, int quantidadePortas) : base(modelo, marca)
        {
            QuantidadePortas = quantidadePortas;
        }
        public override void ExibirInformacoes()
        {
            Console.WriteLine($"O veiculo é um(a) {Modelo} da marca {Marca} e possui {QuantidadePortas} portas.");
        }
    }
}