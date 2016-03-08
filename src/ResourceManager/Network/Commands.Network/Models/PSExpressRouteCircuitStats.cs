﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft.Azure.Commands.Network.Models
{
    public class PSExpressRouteCircuitStats
    {
        public ulong PrimaryBytesIn { get; set; }

        public ulong PrimaryBytesOut { get; set; }

        public ulong SecondaryBytesIn { get; set; }

        public ulong SecondaryBytesOut { get; set; }

    }
}
