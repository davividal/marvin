using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marvin.Domain.Entities
{
    class Chunk
    {
        protected File File;

        protected Byte[] Content;

        protected String Checksum;
    }
}
