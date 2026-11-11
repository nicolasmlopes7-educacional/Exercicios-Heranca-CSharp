namespace ExercicioHerancaCSharp.Ex5
{
    public class EntregaExpressa : Entrega
    {
        public decimal TaxaAdicional { get; set; }

        public EntregaExpressa()
        {
            
        }
        public override void CalcularFrete()
        {
            decimal resultado = Distancia * 1.10m;
            Console.WriteLine($"O frete para a entrega expressa é: {resultado:C}.");
        }
    }
}