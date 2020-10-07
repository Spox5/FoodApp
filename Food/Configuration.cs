using Microsoft.Extensions.Configuration;
using System;

namespace Food
{
    public class Configuration
    {
        public string ConnectionString { get; set; }

        internal static IConfiguration GetSection(string v)
        {
            throw new NotImplementedException();
        }
    }
}
