﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace try2
{
    public class NotHotDogModel
    {
        [JsonProperty(PropertyName = "Id")]
        public string ID { get; set; }

        [JsonProperty(PropertyName = "Longitude")]
        public float Longitude { get; set; }

        [JsonProperty(PropertyName = "Latitude")]
        public float Latitude { get; set; }
    }
}