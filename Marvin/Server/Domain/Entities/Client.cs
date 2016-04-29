using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Marvin.Domain.Entities
{
    class Client
    {
        protected Socket Socket;

        protected IPAddress IPAddress;

        protected Boolean Active;

        protected Boolean StandBy;

        public Client(Socket Socket)
        {
            // IPAddress = Socket.GetIP();
            Active = true;
            StandBy = false;
        }
    }
}
