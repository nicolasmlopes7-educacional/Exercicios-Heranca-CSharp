namespace ExercicioHerancaCSharp
{
    public class Veiculo
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }

        public virtual void ExibirInformacoes()
        {
                Console.WriteLine($"O veiculo é um(a) {Modelo} da marca {Marca}.");
        }
    }
}