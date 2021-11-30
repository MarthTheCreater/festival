using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Festival.Shared.Models
{
    class Vagter : Hold
    {
        public int vagterId { get; set; }
        public DateTime starttidspunkt { get; set; }
        public DateTime sluttidspunkt { get; set; }
        public string beskrivelse { get; set; }
        //public int antal { get; set; }
        public bool ledig { get; set; }
        

        public Vagter(int vagterId, DateTime starttidspunkt, DateTime sluttidspunkt, string beskrivelse, /* int antal,*/ bool ledig)
        {
            this.vagterId = vagterId;
            this.starttidspunkt = starttidspunkt;
            this.sluttidspunkt = sluttidspunkt;
            this.beskrivelse = beskrivelse;
            //this.antal = antal;
            this.ledig = ledig;
            

        }
    }
}
