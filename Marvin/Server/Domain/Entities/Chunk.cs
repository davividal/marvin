using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Marvin.Domain.Entities
{
    class Chunk
    {
        protected static Int32 ChunkId;

        protected String Checksum;

        protected Byte[] Segment;

        public Chunk(ArraySegment<Byte> Segment)
        {
            ChunkId++;
            this.Segment = Segment.ToArray();

            DetermineChecksum();
        }

        protected void DetermineChecksum()
        {
            using (var md5 = MD5.Create())
            {
                Stream data = new MemoryStream();
                Checksum = md5.ComputeHash(Segment).ToString();
            }
        }
    }
}
