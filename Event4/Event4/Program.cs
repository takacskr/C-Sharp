namespace Event4
{
    class ServerEventArgs : EventArgs
    {
        public ServerEventArgs(string message)
        : base()
        {
            this.Message = message;
        }
        public string Message { get; set; }
    }

    class Server
    {
        public delegate void ServerEvent(object sender, ServerEventArgs e);
        public event ServerEvent ServerChange;
        public Server() { }
        public void Connect(Client client)
        {
            this.ServerChange += client.ServerMessageHandler;
            OnServerChange(string.Format($"Felhasználó <{client.Name}> csatlakozott!"));
        }
        public void Disconnect(Client client)
        {
            this.ServerChange -= client.ServerMessageHandler;
            OnServerChange(string.Format($"Felhasználó <{client.Name}> kilépett!"));
        }
        protected void OnServerChange(string message)
        {
            if (ServerChange != null)
            {
                ServerChange(this, new ServerEventArgs(message));
            }
        }
    }

    class Client
    {
        public Client(string name)
        {
            Name = name;
        }
        public string Name { get; set; }
        public void ServerMessageHandler(object sender, ServerEventArgs e)
        {
            Console.WriteLine($"{this.Name} üzenetet kapott: {e.Message}");
        }
    }
    
    class Program
    {
        static void Main()
        {
            Server server = new Server();
            Client c1 = new Client("Józsi");
            Client c2 = new Client("Béla");
            Client c3 = new Client("Tomi");
            server.Connect(c1);
            server.Connect(c2);
            server.Disconnect(c1);
            server.Connect(c3);
            Console.ReadKey();
        }
    }
}
