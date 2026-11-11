namespace ExercicioHerancaCSharp.Ex4
{
    public class NotificacaoEmail : Notificacao
    {
        public override void Enviar()
        {
            Console.WriteLine("Mensagem de Email enviada!");
        }
    }
}