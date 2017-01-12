using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSharpWebsite.Models.HomeViewModels
{
    public class IPAddress
    {
        public int addressId { get; set; }
        public string hostname { get; set; }
        public string ipv4 { get; set; }
        public bool vm { get; set; }
        public string description { get; set; }

    }
}
