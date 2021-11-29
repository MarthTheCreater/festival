using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sem2project.Shared.Models
{
    class Vagter
    {
        public DateTime start { get; set; }
        public DateTime slut { get; set; }
        public string beskrivelse { get; set; }
        public int antal { get; set; }
        public bool ledig { get; set; }

        public Vagter(DateTime start, DateTime slut, string beskrivelse, int antal, bool ledig)
        {
            this.start = start;
            this.slut = slut;
            this.beskrivelse = beskrivelse;
            this.antal = antal;
            this.ledig = ledig;

        }
    }
}
