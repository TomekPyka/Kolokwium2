﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Kolokwium2.Model
{
    public class Action
    {
        [Key]
        public int IdAction { get; set; }

        [Required]
        public DateTime StartTime { get; set; }

        public DateTime? EndTime { get; set; }

        
        public bool NeedSpecialEquipment { get; set; }

       
    }
}
