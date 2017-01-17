using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace CSharpWebsite.Models
{
    public class IpAddress
    {
        [Required]
        public int Id { get; set; }

        [Required]
        [MaxLength(255)]
        public string hostname { get; set; }

        [MinLength(9)]
        [MaxLength(21)]
        public string ipv4 { get; set; }
        
        [MaxLength(45)]
        public string ipv6 { get; set; }

        [Required]
        public bool vm { get; set; }

        [Required]
        public bool container { get; set; }

        [Required]
        public bool docker { get; set; }

        [Required]
        public string operating_system { get; set; }

        [Required]
        public string description { get; set; }
    }
}
