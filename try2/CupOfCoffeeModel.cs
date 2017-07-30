using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace try1
{
   public class CupOfCoffeeModel
    {

        [JsonProperty(PropertyName = "Id")]
        public string ID { get; set; }

        [JsonProperty(PropertyName = "CoffeeName")]
        public float Longitude { get; set; }

        [JsonProperty(PropertyName = "Time")]
        public float Latitude { get; set; }
    
}
}
