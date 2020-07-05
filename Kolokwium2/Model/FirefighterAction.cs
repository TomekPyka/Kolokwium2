using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Kolokwium2.Model
{
    public class FirefighterAction
    {
        [Key]
        public int FireFighter { get; set; }

        [ForeignKey("IdFireFighter")]
        public Firefighter fireFighter { get; set; }

        [Key]
        public int Action{ get; set; }

        [ForeignKey("IdAction")]
        public Action action { get; set; }

   
    }
}
