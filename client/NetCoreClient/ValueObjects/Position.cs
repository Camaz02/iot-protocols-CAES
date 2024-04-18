using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetCoreClient.ValueObjects
{
    internal class Position
    {
        public string Value { get; private set; }

        public Position(string value)
        {
            this.Value = value;
        }
    }
}
