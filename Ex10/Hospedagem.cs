namespace ExercicioHerancaCSharp.Ex10
{
    public class Hospedagem : Servico, IContratavel, ICancelavel
    {
        public Hospedagem(string nome) : base(nome)
        {
            Nome = nome;
        }

        public void Cancelar()
        {
            Console.WriteLine($"Hospedagem cancelou o serviço: {Nome}!");
        }

        public void Contratar()
        {
            Console.WriteLine($"Hospedagem contratou serviço: {Nome}!");
        }
    }
}