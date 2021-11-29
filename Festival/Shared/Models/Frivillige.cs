using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sem2project.Shared.Models
{
    public class Frivillige : Bruger
    {
        public string invi_id { get; set; }
        /*public Frivillige(string invi_id, string navn, int tlf_nr, string login, string email, int hold_id)
        {
            this.navn = navn;
            this.tlf_nr = tlf_nr;
            this.login = login;
            this.email = email;
            this.hold_id = hold_id;
            this.invi_id = invi_id;
        }
        */
    }
}
