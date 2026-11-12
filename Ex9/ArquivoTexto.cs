namespace ExercicioHerancaCSharp.Ex9
{
    public class ArquivoTexto : IArmazenavel
    {
        public override void Salvar(string conteudo)
        {
            Console.WriteLine("Salvando conteúdo no arquivo de texto.");
        }

        public override void Ler()
        {
            Console.WriteLine("Lendo conteúdo do arquivo de texto.");
        }
    }
}