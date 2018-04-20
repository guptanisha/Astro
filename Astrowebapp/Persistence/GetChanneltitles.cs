using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Astrowebapp.Persistence
{
    public partial class GetChanneltitles
    {
        public int channelId { get; set; }
        public string channelTitle { get; set; }
        public string channelDescription { get; set; }
        public string channelCategory { get; set; }
        
    }
}