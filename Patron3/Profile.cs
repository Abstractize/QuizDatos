public abstract class Notified
{
    public abstract void GetNotified(Message message);
}
public class Player : Notified
{
    private string name;
    Notificator notificator;
    public Player(string name)
    {
        this.name = name;
        notificator = new Notificator();
    }
    public override void GetNotified(Message message)
    {
        Console.WriteLine("Yo " + this.name);
        Console.WriteLine("Recibi: " + message.message);
        Console.WriteLine("De: " + message.nameFrom);
    }
    public void NotifyPlayer(string message)
    {
        Message mes;
        mes.message = message;
        mes.nameFrom = this.name;
        notificator.Notify(mes);
    }
    public void AddFriend(Player player)
    {
        notificator.AddObserver(player);
    }
}