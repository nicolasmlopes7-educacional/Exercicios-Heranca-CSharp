namespace ExercicioHerancaCSharp.Ex9
{
    public interface IArmazenavel
    {
        public virtual void Salvar(string conteudo)
        {
            Console.WriteLine("Salavando conteúdo...");
        }

        public virtual void Ler()
        {
            Console.WriteLine("Lendo conteúdo...");
        }
    }
}