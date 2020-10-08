using Microsoft.Extensions.Configuration;
using System;

namespace Food
{
    public class Configuration
    {
        public string ConnectionString { get; set; }

        public string Server { get; set; }
        public string Log { get; set; }
        public string Pas { get; set; }
    }
}
