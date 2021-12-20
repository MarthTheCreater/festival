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
        public int vagtid { get; set; }
        public string dag { get; set; }
        

        public Vagter(int vagterId, DateTime starttidspunkt, DateTime sluttidspunkt, string beskrivelse, int kap, bool ledig, int vagtid, string dag)
        {
            this.vagterId = vagterId;
            this.starttidspunkt = starttidspunkt;
            this.sluttidspunkt = sluttidspunkt;
            this.beskrivelse = beskrivelse;
            this.kap = kap;
            this.ledig = ledig;
            this.vagtid = vagtid;
            this.dag = dag;
        }
        public Vagter()
        {

        }
    }
}
