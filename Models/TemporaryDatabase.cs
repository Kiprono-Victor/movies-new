using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MOVIEW.Models
{
    public class TemporaryDatabase
    {
        [Key]
        public string Id { get; set; }
        [Required]
        public string user_id { get; set; }
        [Required]
        public string movie_id { get; set; }
    }
}
