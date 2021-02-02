using System;
using System.Collections.Generic;
using System.Text;

namespace Akahu.Api.Models
{
    public class Transaction : AkahuModelBase
    {
        public string AccountId { get; set; }
        public string ConnectionId { get; set; }
        public string CategoryId { get; set; }

        public DateTimeOffset CreatedAt { get; set; }
        public DateTimeOffset UpdatedAt { get; set; }
        public DateTimeOffset Date { get; set; }
        public bool Pending { get; set; }
        public Dictionary<string, object> Raw { get; set; }
        public Dictionary<string, object> Metadata { get; set; }

        public string Status { get; set; }
        public string Name { get; set; }
        public double Amount { get; set; }
        public string Type { get; set; }
        public string Logo { get; set; }

        //add location
    }
}
