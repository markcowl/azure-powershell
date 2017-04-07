﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft.Azure.Commands.Common.Authentication.Abstractions
{
    public class HandlerSettings
    {
        string Name { get; set; }

        string Type { get; set; }

        IDictionary<string, string> Settings { get; } = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);

    }
}
