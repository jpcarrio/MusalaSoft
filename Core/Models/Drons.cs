using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    [Table("Drons")]
    public class Drons
    {        
        [Required]
        [StringLength(100, ErrorMessage = "Serial Number length can't be more than 100 characters")]
        public string serialNumber { get; set; }

        [Required]
        public dronModels model { get; set; }

        [Required]
        [Range(0, 500, ErrorMessage ="Weight Limit no more than 500 grams")]
        public int weightLimit { get; set; }

        [Required]
        public int battery { get; set; }

        [Required]
        public dronState state { get; set; }
    }

    public enum dronModels 
    {
        Lightweight, Middleweight, Cruiserweight, Heavyweight
    }

    public enum dronState
    {
        IDLE, LOADING, LOADED, DELIVERING, DELIVERED, RETURNING
    }
}
