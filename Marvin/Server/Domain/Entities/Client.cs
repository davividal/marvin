using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace Marvin.Domain.Entities
{
    class Client : ThreadStaticAttribute
    {
        protected Socket Connect;

        protected IPAddress IPAddress;

        protected Boolean Active;

        protected Boolean StandBy;

        public Client(Socket Socket)
        {
            // IPAddress = Socket.GetIP();
            Active = true;
            StandBy = false;

            Connect = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);

        }
    }
}
