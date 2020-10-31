

using System;
using System.Net.Mail;

namespace Food.Data.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
        public bool IsActive { get; set; }
        public Guid guid { get; set; }
        public DateTime RegisterAt { get; set; }
    }
}
