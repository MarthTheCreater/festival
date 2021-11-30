using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Festival.Shared.Models
{
    public class Hold
    {
        public int holdId { get; set; }
        public string holdnavn { get; set; }
        public string opgave { get; set; }
        public int antal { get; set; }

        public Hold(int holdId, string holdnavn, string opgave, int antal)
        {
            this.holdId = holdId;
            this.holdnavn = holdnavn;
            this.opgave = opgave;
            this.antal = antal;
        }

        public Hold()
        {

        }
    }

}
