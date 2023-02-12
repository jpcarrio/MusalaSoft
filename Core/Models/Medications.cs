using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    [Table("Medications")]
    public class Medications
    {
        [Required]
        [RegularExpression(@"[a-zA-Z0-9_]")]
        public string medicationName { get; set; }

        [Required]
        public int weight { get; set; }

        [Required]
        [RegularExpression(@"[a-zA-Z0-9_]")]
        public string code { get; set; }

        [Required]
        public string image { get; set; }
    }
}
