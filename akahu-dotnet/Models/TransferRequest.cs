using System;
using System.Collections.Generic;
using System.Text;

namespace Akahu.Api.Models
{
    public class TransferRequest
    {
        public string From { get; set; }
        public string To { get; set; }
        public double Amount { get; set; }
    }
}
