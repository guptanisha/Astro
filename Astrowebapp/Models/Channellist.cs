using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Astrowebapp.Models
{
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]

    public class Channellist
    {

        [JsonProperty(PropertyName = "channelId")]
        public int channelId { get; set; }
        [JsonProperty(PropertyName = "channelTitle")]
        public string channelTitle { get; set; }
        [JsonProperty(PropertyName = "channelStbNumber")]
        public int channelStbNumber { get; set; }
    }

    public class FromAstro
    {
        [JsonProperty(PropertyName = "channels")]
        public List<Channellist> channels { get; set; }
    }
}