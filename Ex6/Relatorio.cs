namespace ExercicioHerancaCSharp.Ex6
{
    public class Relatorio : IImprimivel, IExportavel
    {
        public void Exportar()
        {
            Console.WriteLine("Exportando o relátorio.");
        }

        public void Imprimir()
        {
            Console.WriteLine("Imprimindo o relátorio.");
        }
    }
}