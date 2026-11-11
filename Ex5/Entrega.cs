namespace ExercicioHerancaCSharp.Ex5
{
    public abstract class Entrega
    {
        public decimal Distancia { get; set; }

        public abstract void CalcularFrete();
    }
}