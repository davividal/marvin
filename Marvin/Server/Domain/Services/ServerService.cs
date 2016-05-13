using Marvin.Domain.Aggregates;
using Marvin.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Marvin.Domain.Services
{
    class ServerService
    {
        protected Connections Clients;
        protected Socket Server;

        public ServerService(String Address, String Port)
        {
            this.Clients = Connections.getInstance();
            this.Server = new Socket();
            this.Server.Bind();
            this.Server.Listen();
        }

        public void AcceptClient(Client Client)
        {
            Clients.Accept(Client);
        }

        public void DisconnectClient(Client Client)
        {
            Clients.Disconnect(Client);
        }

        public void SendMessage(Client Client, Byte[] Message)
        {
            Clients.SendMessage(Client, Message);
        }

        public void SendMessage(Client Client, String Message)
        {
            Clients.SendMessage(Client, Message);
        }

        internal static void ListenConnection()
        {
            // Uma nova thread para cada accept
            // Accept ou AcceptAsync
            Server.AcceptAsync();
        }
    }
}
