﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Akahu.Api.Models
{
    public class Payment : AkahuModelBase
    {
        public string Status { get; set; }
        public string From { get; set; }
        public PaymentTo To { get; set; }
        public double Amount { get; set; }

        [JsonPropertyName("created_at")]
        public DateTimeOffset CreatedAt { get; set; }
        [JsonPropertyName("updated_at")]
        public DateTimeOffset UpdatedAt { get; set; }

        public List<TimelineEvent> Timeline { get; set; }
        public bool Final { get; set; }
    }
}
