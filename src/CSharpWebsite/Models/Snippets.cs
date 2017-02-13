using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CSharpWebsite.Models
{

    public class Snippets {
        [Key]
        public int id { get; set; }

        [Required]
        public string title { get; set; }

        [Required]
        public string code { get; set; }

        [Required]
        public string language { get; set; }

        [Required]
        public string description { get; set; }
    }
}
