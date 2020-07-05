using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Kolokwium2.DTO.Requests
{
    public class NewActionRequest
    {
      
            [Required]
            public DateTime AssignmentDate { get; set; }


            [Required]
            public ICollection<FireTruckActionRequest> FireTruckActionRequests { get; set; }
        }

    public class FireTruckActionRequest
    {
        [Required]
        public DateTime StartTime { get; set; }

        public DateTime EndTime { get; set; }

        public bool NeedSpecialEquipment { get; set; }
    }
}
