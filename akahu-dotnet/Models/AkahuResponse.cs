using System;
using System.Collections.Generic;
using System.Text;

namespace Akahu.Api.Models
{
    public class AkahuResponse<T> : AkahuResponseBase
    {
        public bool Success { get; set; }
        public T Item { get; set; }
    }
}
