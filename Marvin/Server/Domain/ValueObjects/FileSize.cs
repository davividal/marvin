using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marvin.Domain.ValueObjects
{
    class FileSize
    {
        public enum Unit { B, KB, MB, GB };
        private Double Size;
        private Unit DisplayUnit;

        public FileSize(Double size, Unit unit)
        {
            DisplayUnit = unit;
            Size = Math.Round(size / GetDivisor(), 2);
        }

        public String GetUnit()
        {
            switch (DisplayUnit)
            {
                case Unit.GB:
                    return "GB";
                case Unit.MB:
                    return "MB";
                case Unit.KB:
                    return "KB";
                case Unit.B:
                default:
                    return "B";
            }
        }

        private Double GetDivisor()
        {
            return Math.Pow(1024, Convert.ToInt32(DisplayUnit));
        }

        override public String ToString()
        {
            return String.Format("{0} {1}", Size, GetUnit());
        }
    }
}
