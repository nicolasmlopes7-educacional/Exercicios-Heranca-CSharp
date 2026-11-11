namespace ExercicioHerancaCSharp.Ex5
{
    public class EntregaEconomica : Entrega
    {
        public decimal TaxaAdicional { get; set; }
        public decimal TaxaReduzida { get; set; }
        public override void CalcularFrete()
        {
            decimal frete = Distancia * 1.10m;
            decimal resultadoFrete = frete * 0.10m;
            decimal freteFinal = frete - resultadoFrete;
            Console.WriteLine($"O frete para a entrega econômica é: {freteFinal:C}.");
        }
    }
}