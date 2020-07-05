using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Kolokwium2.Model
{
    public class FireTruck_Action
    {
        [Key]
        public int IdFireTruck_Action { get; set; }

        [ForeignKey("IdFireTruck")]
        public FireTruck FireTruck { get; set; }


        [ForeignKey("IdFireTruck_Action")]
        public FireTruck_Action Action { get; set; }

        [Required]
        public DateTime AssignmentDate { get; set; }
    }
}