using System;

namespace Linq.Samples.Models
{
    public class Account
    {
        public Guid Id { get; set; }
        public string Description { get; set; }
        public AccountType Type { get; set; }
    }
}
