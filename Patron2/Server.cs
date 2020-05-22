public class Server
{
    private static Server instance;
    public static Server Instantiate()
    {
        if (instance == null)
            instance = new Server();
        return instance;
    }
    private Server()
    {
        //Do Something...
    }
}