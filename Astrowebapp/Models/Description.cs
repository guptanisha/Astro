using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Astrowebapp.Models
{
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]

    public class Description
    {

        [JsonProperty(PropertyName = "channelId")]
        public int channelId { get; set; }
        [JsonProperty(PropertyName = "channelTitle")]
        public string channelTitle { get; set; }
        [JsonProperty(PropertyName = "channelDescription")]
        public string channelDescription { get; set; }
        [JsonProperty(PropertyName = "channelCategory")]
        public string channelCategory { get; set; }

        [JsonProperty(PropertyName = "channelExtRef")]
        public List<Images> channelExtRef { get; set; }

       
    }

    public class Images
    {
        [JsonProperty(PropertyName = "system")]
        public string system { get; set; }
     
        [JsonProperty(PropertyName = "value")]
        public string value { get; set; }
    }

    public class FromAstroDescription
    {
        [JsonProperty(PropertyName = "channel")]
        public List<Description> channel { get; set; }
        [JsonProperty(PropertyName = "channelId")]
        public int channelId { get; set; }
        [JsonProperty(PropertyName = "channelDescription")]
        public int channelDescription { get; set; }
        public class FromAstroImages
        {

            [JsonProperty(PropertyName = "channelExtRef")]
            public List<Images> channelExtRef { get; set; }
        }

    }

   
}