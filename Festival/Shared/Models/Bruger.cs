using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sem2project.Shared.Models
{
    public class Bruger
    {
        public int brugerId { get; set; }
        public string navn { get; set; }
        public int tlf { get; set; }
        //public string login { get; set; }
        public string email { get; set; }
        public int holdId { get; set; }

        public Bruger(string navn, int tlf, string email, int holdId)
        {
            this.navn = navn;
            this.tlf = tlf;
            //this.login = login;
            this.email = email;
            this.holdId = holdId;

        }

        public Bruger()
        {

        }
    }
}
