using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Food.ViewModel
{
    public class UserViewModel
    {
        public int Id { get; set; }
        public string Token { get; set; }
        public bool Success { get; set; }
        public int ErrorCode { get; set; }
    }
}
