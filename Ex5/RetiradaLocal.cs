namespace ExercicioHerancaCSharp.Ex5
{
    public class RetiradaLocal : Entrega
    {
        public override void CalcularFrete()
        {
            Console.WriteLine("Seu produto não possuí frete!");
        }
    }
}