using System;
using System.ComponentModel.DataAnnotations;

namespace StackUpDemo.Model
{
    public class Status
    {
        [Key]
        public int StatusId { get; set; }

        [Required]
        public string EntityStatus { get; set; }
    }
}
