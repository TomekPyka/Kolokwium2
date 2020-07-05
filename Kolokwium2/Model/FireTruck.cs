using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Kolokwium2.Model
{
    public class FireTruck
    {
        [Key]
        public int IdFireTruck { get; set; }

        [Required]
        [MaxLength(10)]
        public string OperationalNumber { get; set; }

        [Required]
        public bool SpecialEquipment { get; set; }

        public ICollection<FireTruck_Action> FireTruck_Action { get; set; }
    }
}
