using System;
using System.Collections.Generic;
using System.Text;

namespace Akahu.Api.Models
{
    public class Connection : AkahuModelBase
    {
        public string Name { get; set; }
        public string Url { get; set; }
        public string Logo { get; set; }
        public string Profile { get; set; }
    }
}
