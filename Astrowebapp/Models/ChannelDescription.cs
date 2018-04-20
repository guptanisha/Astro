using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Astrowebapp.Models
{
    public class ChannelDescription
    {

        [JsonProperty(PropertyName = "channelId")]
        public int channelId { get; set; }
        [JsonProperty(PropertyName = "channelDescription")]
        public int channelDescription { get; set; }

        


    }
}