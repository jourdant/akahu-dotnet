using System;

namespace Akahu.Api.Models
{
    public class TimelineEvent
    {
        public string Status { get; set; }
        public DateTimeOffset Time { get; set; }
    }
}