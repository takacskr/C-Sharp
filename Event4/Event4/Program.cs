using System;

namespace Event4
{
    // Eseményargumentum osztály, ami egy üzenetet tárol.
    class ServerEventArgs : EventArgs
    {
        public ServerEventArgs(string message)
        : base()
        {
            this.Message = message;
        }
        public string Message { get; set; }
    }

    // Szerver osztály, amely kommunikál a kliensekkel.
    class Server
    {
        // Delegátum definiálása az eseményhez.
        public delegate void ServerEvent(object sender, ServerEventArgs e);

        // Az esemény definiálása a szerver állapotváltozásához.
        public event ServerEvent ServerChange;

        // Konstruktor, amely inicializálja a szerver objektumot.
        public Server() { }

        // Metódus a kliens csatlakozásához a szerverhez.
        public void Connect(Client client)
        {
            // Feliratkozás a kliens eseménykezelőjére.
            this.ServerChange += client.ServerMessageHandler;

            // Szerver állapotváltozás kiváltása, üzenet küldése.
            OnServerChange($"Felhasználó <{client.Name}> csatlakozott!");
        }

        // Metódus a kliens leválásához a szerverről.
        public void Disconnect(Client client)
        {
            // Leiratkozás a kliens eseménykezelőjéről.
            this.ServerChange -= client.ServerMessageHandler;

            // Szerver állapotváltozás kiváltása, üzenet küldése.
            OnServerChange($"Felhasználó <{client.Name}> kilépett!");
        }

        // Védett metódus a szerver állapotváltozás kiváltásához.
        protected void OnServerChange(string message)
        {
            // Ellenőrzés, hogy van-e feliratkozott eseménykezelő.
            if (ServerChange != null)
            {
                // Esemény kiváltása, eseményargumentummal.
                ServerChange(this, new ServerEventArgs(message));
            }
        }
    }

    // Kliens osztály, amely kapcsolódik a szerverhez.
    class Client
    {
        // Konstruktor, amely inicializálja a kliens objektumot.
        public Client(string name)
        {
            Name = name;
        }

        // Kliens nevének tulajdonsága.
        public string Name { get; set; }

        // Eseménykezelő metódus a szerver üzenetére.
        public void ServerMessageHandler(object sender, ServerEventArgs e)
        {
            // Kliens által fogadott üzenet megjelenítése.
            Console.WriteLine($"{this.Name} üzenetet kapott: {e.Message}");
        }
    }

    // Főprogram.
    class Program
    {
        // Belépési pont.
        static void Main()
        {
            // Szerver objektum létrehozása.
            Server server = new Server();

            // Kliens objektumok létrehozása.
            Client c1 = new Client("Józsi");
            Client c2 = new Client("Béla");
            Client c3 = new Client("Tomi");

            // Kliensek csatlakoztatása a szerverhez.
            server.Connect(c1);
            server.Connect(c2);

            // Egyik kliens leválása a szerverről.
            server.Disconnect(c1);

            // Egy másik kliens csatlakoztatása a szerverhez.
            server.Connect(c3);

            // Várakozás a billentyűleütésre.
            Console.ReadKey();
        }
    }
}
