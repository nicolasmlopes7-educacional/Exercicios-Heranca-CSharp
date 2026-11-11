namespace ExercicioHerancaCSharp.Ex4
{
    public class NotificacaoPush : Notificacao
    {
        public override void Enviar()
        {
            Console.WriteLine("Mensagem de Push enviada!");
        }
    }
}