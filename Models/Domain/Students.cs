using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Szkolenie_techniczne_3_projekt.Models
{
    public class Students
    {
        [Key]
        public Guid id { get; set; }
        [Required]
       [MaxLength(24)]
        public string imie { get; set; }
        [Required]
        [MaxLength(24)]
        public string nazwisko { get; set; }
        [Required]
        [MaxLength(24)]
        public string ulica { get; set; }
        [Required]
        [MaxLength(24)]
        public string numer_domu { get; set; }
        [Required]
        [MaxLength(24)]
        public string email { get; set; }
        public ICollection<Teachers> Teachers { get; set; }

    }
}
