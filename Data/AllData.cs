using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class AllData
    {
        [JsonProperty("clients")]
        public Client[] Clients
        {
            get;
            set;
        }

        [JsonProperty("companies")]
        public Company[] Companies
        {
            get;
            set;
        }
    }
}
