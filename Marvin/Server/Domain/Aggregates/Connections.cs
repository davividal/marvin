using Marvin.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Marvin.Domain.Aggregates
{
    class Connections
    {
        private static Connections instance;

        protected List<Client> Clients;

        private Connections()
        {
            Clients = new List<Client>();
        }

        public static Connections getInstance()
        {
            if (null == instance)
            {
                instance = new Connections();
            }

            return instance;
        }

        public void Accept(Client Client)
        {
            Clients.Add(Client);
        }

        public void Disconnect(Client Client)
        {
            Client.Disconnect();
            Clients.Remove(Client);
        }

        internal void SendMessage(Client client, Byte[] message)
        {
            Client.SendMessage(message);
        }

        internal void SendMessage(Client client, String messageStr)
        {
            Byte[] message = System.Text.Encoding.UTF8.GetBytes(messageStr);
            SendMessage(client, message);
        }
    }
}
