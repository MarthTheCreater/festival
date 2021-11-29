using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sem2project.Shared.Models
{
    class Hold
    {
        public string navn { get; set; }
        public int opgaver { get; set; }
        public string antal_fri { get; set; }

        public Hold(string navn, int opgaver, string antal_fri)
        {
            this.navn = navn;
            this.opgaver = opgaver;
            this.antal_fri = antal_fri;
        }
    }
}
