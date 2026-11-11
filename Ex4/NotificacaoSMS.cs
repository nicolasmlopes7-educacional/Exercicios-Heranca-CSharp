namespace ExercicioHerancaCSharp.Ex4
{
    public class NotificacaoSMS : Notificacao
    {
        public override void Enviar()
        {
            Console.WriteLine("Mensagem de SMS enviada!");
        }
    }
}