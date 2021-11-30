using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Festival.Shared.Models
{
    public class Vagter : Hold
    {
        public int vagterId { get; set; }
        public DateTime starttidspunkt { get; set; }
        public DateTime sluttidspunkt { get; set; }
        public string beskrivelse { get; set; }
        public int kap { get; set; }
        public bool ledig { get; set; }
        

        public Vagter(int vagterId, DateTime starttidspunkt, DateTime sluttidspunkt, string beskrivelse, int kap, bool ledig)
        {
            this.vagterId = vagterId;
            this.starttidspunkt = starttidspunkt;
            this.sluttidspunkt = sluttidspunkt;
            this.beskrivelse = beskrivelse;
            this.kap = kap;
            this.ledig = ledig;
        }
        public Vagter()
        {

        }

        //public void LedigVagt()
        //{
        //    if this.kap == true {

        //    }
        //}
    }
}
