using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Szkolenie_techniczne_3_projekt.Models
{
    public class Teachers
    {
        [Key]
        public int id { get; set; }
        [Required]
        [MaxLength(24)]
        public string imie { get; set; }
        [Required]
        [MaxLength(24)]
        public string nazwisko { get; set; }
        [Required]
        [MaxLength(24)]
        public string specjalizacja { get; set; }
        [Required]
        [MaxLength(24)]
        public string email {get; set; }
        public ICollection<Students> Students { get; set; }
    }
}
