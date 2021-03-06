﻿using Ivvy.Json;
using Newtonsoft.Json;
using System;

namespace Ivvy.Venue.Bookings
{
    /// <summary>A single session on an iVvy venue booking.</summary>
    public class Session : ISerializable
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("startDate")]
        public DateTime StartDate { get; set; }

        [JsonProperty("endDate")]
        public DateTime EndDate { get; set; }

        [JsonProperty("startTime")]
        public TimeSpan StartTime { get; set; }

        [JsonProperty("endTime")]
        public TimeSpan EndTime { get; set; }

        [JsonProperty("spaceId")]
        public int SpaceId { get; set; }

        [JsonProperty("costCenterId")]
        public int CostCenterId { get; set; }

        [JsonProperty("cost")]
        public decimal Cost { get; set; }

        [JsonProperty("totalAmount")]
        public decimal TotalAmount { get; set; }
    }
}
