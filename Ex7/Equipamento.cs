namespace ExercicioHerancaCSharp.Ex7
{
    public class Equipamento
    {
        public string? Modelo { get; set; }

        protected int? NumeroSerie { get; set; }
        public Equipamento(string modelo, int numerodeSerie)
        {
            Modelo = modelo;
            NumeroSerie = numerodeSerie;
        }

        public virtual void ExibirInformacoes()
        {
          Console.WriteLine($"O equipamento: {Modelo}, o número de série é: {NumeroSerie}.");  
        }
    }
}