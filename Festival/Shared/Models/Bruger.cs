using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Festival.Shared.Models
{
    public class Bruger
    {
        public int brugerId { get; set; }

        public string navn { get; set; }

        public int tlf { get; set; }
       
        public string email { get; set; }

        public int holdId { get; set; }

        public Bruger(int brugerId, string navn, int tlf, string email, int holdId)
        {
            this.brugerId = brugerId;

            this.navn = navn;

            this.tlf = tlf;

            this.email = email;

            this.holdId = holdId;

        }

        public Bruger()
        {

        }


    }
}
