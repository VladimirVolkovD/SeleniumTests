﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Configuration
{
    public class BrowserConfiguration : IConfiguration
    {
        public string SectionName => "Browser";

        public bool Hedless { get; set; }
        public string Type { get; set; }
        public int TimeOut { get; set; }

    }
}
