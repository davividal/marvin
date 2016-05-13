using Marvin.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Security.Cryptography;

namespace Marvin.Domain.Entities
{
    class File
    {
        protected String Path;

        protected String Name;

        protected Double Size;

        protected String Checksum;

        protected List<Chunk> Chunks;

        protected const Int32 ChunkSize = 1024;

        public File(String Filepath, String Basename)
        {
            Path = Filepath;
            Name = Basename;

            this.DetermineFileSize();
            this.DetermineFileChecksum();
            this.DetermineChunks();
        }

        private void DetermineChunks()
        {
            Int32 chunks = Convert.ToInt32(Math.Round(Size / ChunkSize));

            Byte[] file = System.IO.File.ReadAllBytes(Path);

            for (Int32 chunk = 0, offset = 0; chunk <= chunks; chunk++, offset += ChunkSize)
            {
                Chunks.Add(new Chunk(new ArraySegment<Byte>(file, offset, ChunkSize)));
            }
        }

        private void DetermineFileChecksum()
        {
            using (var md5 = MD5.Create())
            {
                using (var stream = System.IO.File.OpenRead(Path))
                {
                    Checksum = md5.ComputeHash(stream).ToString();
                }
            }
        }

        private void DetermineFileSize()
        {
            Size = Convert.ToDouble((new System.IO.FileInfo(Path)).Length);
        }

        override public String ToString()
        {
            return String.Format("{0} ({1})", Name, new FileSize(Size, FileSize.Unit.MB).ToString());
        }
    }
}
