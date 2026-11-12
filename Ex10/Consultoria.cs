namespace ExercicioHerancaCSharp.Ex10
{
    public class Consultoria : Servico, IContratavel
    {
        public Consultoria(string nome) : base(nome)
        {
            Nome = nome;
        }

        public void Contratar()
        {
            Console.WriteLine($"Consultoria contratou o serviço: {Nome}!");
        }
    }
}