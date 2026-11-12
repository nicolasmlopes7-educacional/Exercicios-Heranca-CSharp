namespace ExercicioHerancaCSharp.Ex9
{
    public class BancoDados : IArmazenavel
    {
        public void Salvar(string conteudo)
        {
            Console.WriteLine($"Salvando {conteudo} no banco de dados.");
        }

        public void Ler()
        {
            Console.WriteLine("Lendo conteúdo do banco de dados.");
        }
    }
}